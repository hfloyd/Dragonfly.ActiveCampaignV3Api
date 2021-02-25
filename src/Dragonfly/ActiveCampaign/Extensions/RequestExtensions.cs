namespace Dragonfly.ActiveCampaign.Extensions
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Helpers;
    using Dragonfly.ActiveCampaign.Models;

    internal static class RequestExtensions
	{
		public static NameValueCollection GetNamedValueCollection<T>(this ActiveCampaignRequest<T> request)
		{
			const string PValuePropertyName = "PValues";

			const string FilterFieldPropertyName = "FilterField";

			const string FilterValuePropertyName = "FilterValues";

            const string FieldsPropertyName = "Fields";

            var formFields = new NameValueCollection();

			var properties = request
						.GetType()
						.GetProperties()
						.ToList();

			properties
				.Where(p => p.Name != FilterFieldPropertyName)
				.ToList()
				.ForEach(
					pi =>
					{
						var propertyValue = pi.GetValue(request, null);

						if (propertyValue == null)
						{
							return;
						}

						var propertyName = pi.Name;

						if (propertyName == PValuePropertyName)
						{
							propertyName = $"p[{propertyValue}]";
						}

						if (propertyName == FilterValuePropertyName)
						{
							var filterField = properties.Single(p => p.Name == FilterFieldPropertyName).GetValue(request, null);

							propertyName = $"filters[{filterField}]";
						}

                        if (propertyName == FieldsPropertyName)
                        {
                            var fieldsValues = (IDictionary<string, string>)properties.Single(p => p.Name == FieldsPropertyName).GetValue(request, null);

                            foreach (var field in fieldsValues)
                            {
                                var fieldName = $"field[%{field.Key}%, 0]";

                                var fieldValue = field.Value;

                                formFields.Add(fieldName, fieldValue);
                            }

                            return;
                        }

						//propertyName = propertyName.CamelCaseToUnderscore();
						propertyName = pi.GetJsonName();

						if (pi.PropertyType.IsArray)
                        {
                            foreach (var value in (IEnumerable)propertyValue)
                            {
                                formFields.Add(propertyName, value.ToString());
                            }

                            return;
                        }

                        formFields.Add(propertyName, propertyValue.ToString());
					});

			return formFields;
		}
	}
}