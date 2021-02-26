namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class FieldsList
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Result for GetSingle()
        /// </summary>
        [JsonProperty("field")]
        public Field Field { get; set; }

        /// <summary>
        /// Result for GetList()
        /// </summary>
        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        [JsonProperty("fieldOptions")]
        public List<FieldOption> FieldOptions { get; set; }

        [JsonProperty("fieldRels")]
        public List<FieldRel> FieldRelations { get; set; }

        #region Sideloading Params

        public enum LinkedData
        {
            FieldOptions,
            FieldRelations
        }

        internal static IEnumerable<string> GetLinkedDataParamsList(IEnumerable<LinkedData> DataList)
        {
            var list = new List<string>();

            foreach (var item in DataList)
            {
                switch (item)
                {
                    case LinkedData.FieldOptions:
                        list.Add("options");
                        break;
                    case LinkedData.FieldRelations:
                        list.Add("relations");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return list;
        }

        #endregion
    }


}
