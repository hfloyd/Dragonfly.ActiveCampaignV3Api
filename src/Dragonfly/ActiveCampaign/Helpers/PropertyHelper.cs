namespace Dragonfly.ActiveCampaign.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;
    using Newtonsoft.Json;

    /// <summary>
    /// Allows access to properties of a Class
    /// example usage:
    ///var prop = PropertyHelper&lt;MyClass&gt;.GetProperty(x =&gt; x.MyProperty);
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class PropertyHelper<T>
    {
        public static string GetAllJsonFields()
        {
            Type modelType = typeof(T);
            return string.Join(",",
                modelType.GetProperties()
                    .Select(p => p.GetCustomAttribute<JsonPropertyAttribute>())
                    .Select(jp => jp.PropertyName));
        }


        public static Dictionary<PropertyInfo, string> GetJsonProperties()
        {
            Type modelType = typeof(T);

            var pairs = modelType
                .GetProperties()
                .Select(p => new
                {
                    Property = p,
                    Attribute = p
                        .GetCustomAttributes(
                            typeof(JsonPropertyAttribute), true)
                        .Cast<JsonPropertyAttribute>()
                        .FirstOrDefault()
                });

            var objProps = pairs
                .Where(p => p.Attribute != null)
                .ToDictionary(
                    p => p.Property,
                    p => p.Attribute.PropertyName);

            return objProps;
        }

        public static string GetJsonName(string ModelPropertyName)
        {
            Type modelType = typeof(T);
            var matches = modelType.GetProperties().Where(p => p.Name == ModelPropertyName).ToList();
            if (matches.Any())
            {
                var prop = matches.First();
                var attribute = prop.GetCustomAttributes(
                        typeof(JsonPropertyAttribute), true)
                    .Cast<JsonPropertyAttribute>()
                    .FirstOrDefault();

                if (attribute != null)
                {
                    return attribute.PropertyName;
                }
            }

            return "";
        }

        public static string GetJsonName<TValue>(Expression<Func<T, TValue>> selector)
        {
            PropertyInfo propInfo = null;

            Expression body = selector;
            if (body is LambdaExpression)
            {
                body = ((LambdaExpression)body).Body;
            }
            switch (body.NodeType)
            {
                case ExpressionType.MemberAccess:
                    propInfo = (PropertyInfo)((MemberExpression)body).Member;
                    break;
                default:
                    throw new InvalidOperationException();
            }

            if (propInfo != null)
            {
                var attribute = propInfo.GetCustomAttributes(
                        typeof(JsonPropertyAttribute), true)
                    .Cast<JsonPropertyAttribute>()
                    .FirstOrDefault();

                if (attribute != null)
                {
                    return attribute.PropertyName;
                }
            }

            return null;
        }

        public static PropertyInfo GetProperty<TValue>(Expression<Func<T, TValue>> selector)
        {
            Expression body = selector;
            if (body is LambdaExpression)
            {
                body = ((LambdaExpression)body).Body;
            }
            switch (body.NodeType)
            {
                case ExpressionType.MemberAccess:
                    var propInfo = (PropertyInfo)((MemberExpression)body).Member;
                    return propInfo;
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

    }

    /// <summary>
    /// Allows access to properties of a Class
    /// example usage:
    ///var prop = PropertyHelper.GetProperty(MyClass);
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class PropertyHelper
    {
        public static string GetAllJsonFields(Type ModelType)
        {
            Type modelType = ModelType;
            return string.Join(",",
                modelType.GetProperties()
                    .Select(p => p.GetCustomAttribute<JsonPropertyAttribute>())
                    .Select(jp => jp.PropertyName));
        }


        public static Dictionary<PropertyInfo, string> GetJsonProperties(Type ModelType)
        {
            Type modelType = ModelType;

            var pairs = modelType
                .GetProperties()
                .Select(p => new
                {
                    Property = p,
                    Attribute = p
                        .GetCustomAttributes(
                            typeof(JsonPropertyAttribute), true)
                        .Cast<JsonPropertyAttribute>()
                        .FirstOrDefault()
                });

            var objProps = pairs
                .Where(p => p.Attribute != null)
                .ToDictionary(
                    p => p.Property,
                    p => p.Attribute.PropertyName);

            return objProps;
        }

        public static string GetJsonName(Type ModelType, string ModelPropertyName)
        {
            Type modelType = ModelType;
            var matches = modelType.GetProperties().Where(p => p.Name == ModelPropertyName).ToList();
            if (matches.Any())
            {
                var prop = matches.First();
                var attribute = prop.GetCustomAttributes(
                        typeof(JsonPropertyAttribute), true)
                    .Cast<JsonPropertyAttribute>()
                    .FirstOrDefault();

                if (attribute != null)
                {
                    return attribute.PropertyName;
                }
            }

            return "";
        }

        public static string GetJsonName(this PropertyInfo Prop)
        {
            var attribute = Prop.GetCustomAttributes(
                    typeof(JsonPropertyAttribute), true)
                .Cast<JsonPropertyAttribute>()
                .FirstOrDefault();

            if (attribute != null)
            {
                return attribute.PropertyName;
            }

            return "";
        }



    }
}
