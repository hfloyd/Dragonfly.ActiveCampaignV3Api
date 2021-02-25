namespace Dragonfly.ActiveCampaign.Helpers
{
    using System.Reflection;
    using Newtonsoft.Json.Serialization;

 //   internal class NullToEmptyStringValueProvider : IValueProvider
	//{
	//	private readonly PropertyInfo memberInfo;

	//	public NullToEmptyStringValueProvider(PropertyInfo memberInfo)
	//	{
	//		this.memberInfo = memberInfo;
	//	}

	//	public object GetValue(object target)
	//	{
	//		var result = memberInfo.GetValue(target) as string;

	//		if (memberInfo.PropertyType == typeof(string) && string.IsNullOrWhiteSpace(result))
	//		{
	//			result = null;
	//		}

	//		return result;

	//	}

	//	public void SetValue(object target, object value)
	//	{
	//		var stringValue = value as string;

	//		if (stringValue != null)
	//		{
	//			value = string.IsNullOrWhiteSpace(stringValue) ? null : stringValue;
	//		}

	//		memberInfo.SetValue(target, value);
	//	}
	//}
}