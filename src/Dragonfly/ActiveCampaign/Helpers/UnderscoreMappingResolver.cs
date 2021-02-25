namespace Dragonfly.ActiveCampaign.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Dragonfly.ActiveCampaign.Extensions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    internal class UnderscoreMappingResolver : DefaultContractResolver
	{
		//protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		//{
		//	return type.GetProperties()
		//			.Select(p =>
		//			{
		//				var jp = CreateProperty(p, memberSerialization);
		//				jp.ValueProvider = new NullToEmptyStringValueProvider(p);
		//				return jp;
		//			}).ToList();
		//}

		//protected override string ResolvePropertyName(string propertyName)
		//{
		//	var camelCaseToUnderscore = propertyName.CamelCaseToUnderscore();

		//	return camelCaseToUnderscore;
		//}
	}
}