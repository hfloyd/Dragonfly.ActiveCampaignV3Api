namespace Dragonfly.ActiveCampaign.Extensions
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal static class StringExtensions
    {
        private static readonly ISet<string> knownProperties =
            new HashSet<string> { "Error", "UserDescription", "Version" };

        //public static string CamelCaseToUnderscore(this string source)
        //{
        //    if (source == "LogContext")
        //    {
        //        return source;
        //    }

        //    var newPropertyName =
        //        Regex.Replace(source, @"([A-Z])([A-Z][a-z])|([a-z0-9])([A-Z])", "$1$3_$2$4").ToLower();

        //    if (knownProperties.Contains(source))
        //    {
        //        newPropertyName = string.Concat("@", newPropertyName);
        //    }

        //    return newPropertyName;
        //}
    }
}