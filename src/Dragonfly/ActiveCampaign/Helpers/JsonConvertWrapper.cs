namespace Dragonfly.ActiveCampaign.Helpers
{
    using Newtonsoft.Json;

    public static class JsonConvertWrapper
	{
		private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
		    {
			    //ContractResolver = new UnderscoreMappingResolver(),
			    NullValueHandling = NullValueHandling.Ignore,
			    DefaultValueHandling = DefaultValueHandling.Ignore
		    };

		public static T DeserializeObject<T>(string json)
		{
			var result = JsonConvert.DeserializeObject<T>(json, settings);

			return result;
		}
	}
}