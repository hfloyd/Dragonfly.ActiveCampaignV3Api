namespace Dragonfly.ActiveCampaign.Helpers
{
    using System;
    using System.CodeDom;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Reflection;
    using System.Text.RegularExpressions;
    using Dragonfly.ActiveCampaign.Models;

    internal static class UrlHelper
    {
        const string FilterFieldPropertyName = "FilterField";

        const string FilterValuesPropertyName = "FilterValues";

        private static readonly ISet<string> knownProperties =
               new HashSet<string> { "Error", "UserDescription", "Version" };

        public static string ToQueryString(this object request)
        {
            //request is null
            if (request == null)
            {
                return string.Empty;
            }

            //request is a string
            var requestString = request as string;

            if (requestString != null)
            {
                return requestString;
            }

            //request is an ActiveCampaignRequest
            var acRequest = request as IActiveCampaignRequest;
            //Check for fields
            if (acRequest != null && acRequest.Fields.Any())
            {
                //return fields as QS
                var qsParams = acRequest.Fields.Select(i => i.Key + "=" + i.Value);
                return string.Join("&", qsParams);
            }

            // Get all properties on the object with json names
            var modelType = request.GetType();

            var jsonProps = PropertyHelper.GetJsonProperties(modelType);
            var properties =
                jsonProps
                    .Where(x => x.Key.CanRead)
                    .Where(x => x.Key.GetValue(request, null) != null)
                    .Where(x => x.Value != "")
                    //.ToDictionary(
                    //    k => k.Value,
                    //    v =>
                    //    {
                    //        var value = v.Key.GetValue(request, null);
                    //        return value.GetType().IsEnum ? (int)value : value;
                    //    })
                    .ToList();

            //Loop properties, adding to collection if valid
            var qsFields = new Dictionary<string, string>();
            var finalParamsList = new List<string>();

            foreach (var property in properties)
            {
                var jsonName = property.Value;
                var propValue = property.Key.GetValue(request, null);

                if (!(propValue is string) && propValue is IEnumerable)
                {
                    var paramVal = ConcatIEnums(property, request);
                    finalParamsList.Add(paramVal);
                }
                else if (propValue is int || propValue is long)
                {
                    //Only add non-zero number properties
                    if (Convert.ToInt64(propValue) != 0)
                    {
                        qsFields.Add(jsonName, propValue.ToString());
                    }
                }
                else
                {
                    qsFields.Add(jsonName, propValue.ToString());
                }

            }

            finalParamsList.AddRange(qsFields.Select(x => x.Key + "=" + x.Value));
            return string.Join("&", finalParamsList);

            //// Get names for all IEnumerable properties (excl. string)
            //var propertyNames = properties.Where(x => !(x.Value is string) && x.Value is IEnumerable).Select(x => x.Key).ToList();



            //var propertiesValues = properties.Where(p => p.Key != FilterFieldPropertyName).Select(x => ResolvePropertyName(x.Key, x.Value.ToString()));

            //return string.Join("&", propertiesValues);
        }

        private static string ConcatIEnums(KeyValuePair<PropertyInfo, string> KeyValuePair, object request)
        {
            // Concat all IEnumerable properties into a comma separated string
            var pInfo = KeyValuePair.Key;
            var jsonName = KeyValuePair.Value;
            var propValue = pInfo.GetValue(request, null);

            //Get the inner type of the IEnum
            var valueType = propValue.GetType();
            var valueElemType = valueType.IsGenericType ? valueType.GetGenericArguments()[0] : valueType.GetElementType();
            var isEnum = valueElemType.IsEnum;

            //Get the proper "ToString()" function
            Func<object, string> toString = x => isEnum ? ((int)x).ToString() : x.ToString();

            //Check that this is still valid to work on....
            var isEnumerable = propValue is IEnumerable;
            
            if (!valueElemType.IsPrimitive && valueElemType != typeof(string) && !isEnumerable)
            {
                return "";
            }

            //Cast to an IEnum from object
            var enumerable = propValue as IEnumerable;

            //Get a list of all values as strings with '&'
            Func<IEnumerable, IEnumerable<string>> enumerableValues = x => x.Cast<object>().Select(i => toString(i)).ToList();
            
            var tempValues = enumerableValues(enumerable).Select(x => x + "&").ToList();

            //Append Json param name and join all together into a single string
            string propertyName = jsonName;
            string returnValue;

            if (tempValues.Count() == 1)
            {
                returnValue = $"{jsonName}={string.Join("", tempValues)}";
            }
            else
            {
                returnValue = $"{jsonName}[]={string.Join(jsonName + "[]=", tempValues)}";
            }

            return returnValue.TrimEnd('&');

        }


        public static string ToQueryString(this IEnumerable enumerbale, string enumerableName)
        {
            return string.Join("&", enumerbale.Cast<object>().Select(x => string.Concat(enumerableName, "=", x.ToString())));
        }

        private static string ResolvePropertyName(string propertyName, string propertyValue)
        {
            if (propertyName == FilterValuesPropertyName)
            {
                return propertyValue;
            }

            return string.Concat(CamelCaseToUnderscorePropertyName(propertyName), "=", propertyValue);
        }

        private static string CamelCaseToUnderscorePropertyName(string propertyName)
        {
            if (propertyName == "LogContext")
            {
                return propertyName;
            }

            var newPropertyName =
                Regex.Replace(propertyName, @"([A-Z])([A-Z][a-z])|([a-z0-9])([A-Z])", "$1$3_$2$4").ToLower();

            if (knownProperties.Contains(propertyName))
            {
                newPropertyName = string.Concat("@", newPropertyName);
            }

            return newPropertyName;
        }
    }
}
