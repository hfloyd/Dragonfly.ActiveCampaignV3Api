namespace Dragonfly.ActiveCampaign.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                BatchIdConverter.Singleton,
                ActiverssIntervalConverter.Singleton,
                //LastStepConverter.Singleton,
                ReminderFieldConverter.Singleton,
                ReminderFormatConverter.Singleton,
                //ReminderLastCronRunConverter.Singleton,
                ReminderOffsetSignConverter.Singleton,
                OffsetTypeConverter.Singleton,
                ReminderTypeConverter.Singleton,
                ResponderTypeConverter.Singleton,
                SplitTypeConverter.Singleton,
                TrackLinksConverter.Singleton,
                TypeEnumConverter.Singleton,
                SendTypeConverter.Singleton,
                WaitTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class DtOffsetConverter : JsonConverter
    {
        private const string NullDateString = "0000-00-00 00:00:00";
        private const string NullDateStringForAc = "0000-00-00";

        public override bool CanConvert(Type t) => t == typeof(DateTimeOffset) || t == typeof(DateTimeOffset?);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            try
            {
                var value = serializer.Deserialize<DateTimeOffset>(reader);
                return value;
            }
            catch (Exception e)
            {
                var valueAsString = serializer.Deserialize<string>(reader);
                if (valueAsString == "0000-00-00")
                {
                    return DateTimeOffset.MinValue;
                }
                else
                {
                    throw new Exception($"Unable to convert value '{valueAsString}' to DateTimeOffset: {e.Message}");
                }
            }
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            else if ((DateTimeOffset)untypedValue == DateTimeOffset.MinValue)
            {
                serializer.Serialize(writer, NullDateStringForAc);
                return;
            }
            else if (untypedValue.ToString() == NullDateString)
            {
                serializer.Serialize(writer, NullDateStringForAc);
                return;
            }
            else
            {
                serializer.Serialize(writer, untypedValue.ToString());
                return;
            }

        }

    }

    internal class BatchIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BatchId) || t == typeof(BatchId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "completed")
            {
                return BatchId.Completed;
            }
            throw new Exception("Cannot unmarshal type BatchId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BatchId)untypedValue;
            if (value == BatchId.Completed)
            {
                serializer.Serialize(writer, "completed");
                return;
            }
            throw new Exception("Cannot marshal type BatchId");
        }

        public static readonly BatchIdConverter Singleton = new BatchIdConverter();
    }

    internal class ParseStringToLongConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception($"Unable to convert value '{value}' to long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringToLongConverter Singleton = new ParseStringToLongConverter();
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringToLongConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringToLongConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class ActiverssIntervalConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ActiverssInterval) || t == typeof(ActiverssInterval?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "day1")
            {
                return ActiverssInterval.Day1;
            }
            throw new Exception("Cannot unmarshal type ActiverssInterval");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ActiverssInterval)untypedValue;
            if (value == ActiverssInterval.Day1)
            {
                serializer.Serialize(writer, "day1");
                return;
            }
            throw new Exception("Cannot marshal type ActiverssInterval");
        }

        public static readonly ActiverssIntervalConverter Singleton = new ActiverssIntervalConverter();
    }

    //internal class LastStepConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(Laststep) || t == typeof(Laststep?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        switch (value)
    //        {
    //            case "designer":
    //                return LastStep.Designer;
    //            case "result":
    //                return LastStep.Result;
    //            case "summary":
    //                return LastStep.Summary;
    //        }
    //        throw new Exception("Cannot unmarshal type LastStep");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (LastStep)untypedValue;
    //        switch (value)
    //        {
    //            case LastStep.Designer:
    //                serializer.Serialize(writer, "designer");
    //                return;
    //            case LastStep.Result:
    //                serializer.Serialize(writer, "result");
    //                return;
    //            case LastStep.Summary:
    //                serializer.Serialize(writer, "summary");
    //                return;
    //        }
    //        throw new Exception("Cannot marshal type Laststep");
    //    }

    //    public static readonly LastStepConverter Singleton = new LastStepConverter();
    //}

    internal class ReminderFieldConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ReminderField) || t == typeof(ReminderField?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "sdate")
            {
                return ReminderField.Sdate;
            }
            throw new Exception("Cannot unmarshal type ReminderField");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ReminderField)untypedValue;
            if (value == ReminderField.Sdate)
            {
                serializer.Serialize(writer, "sdate");
                return;
            }
            throw new Exception("Cannot marshal type ReminderField");
        }

        public static readonly ReminderFieldConverter Singleton = new ReminderFieldConverter();
    }

    internal class ReminderFormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ReminderFormat) || t == typeof(ReminderFormat?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return ReminderFormat.Empty;
                case "yyyy-mm-dd":
                    return ReminderFormat.YyyyMmDd;
            }
            throw new Exception("Cannot unmarshal type ReminderFormat");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ReminderFormat)untypedValue;
            switch (value)
            {
                case ReminderFormat.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case ReminderFormat.YyyyMmDd:
                    serializer.Serialize(writer, "yyyy-mm-dd");
                    return;
            }
            throw new Exception("Cannot marshal type ReminderFormat");
        }

        public static readonly ReminderFormatConverter Singleton = new ReminderFormatConverter();
    }

    //internal class ReminderLastCronRunConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(ReminderLastCronRun) || t == typeof(ReminderLastCronRun?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        if (value == "-001-11-30T00:00:00-06:00")
    //        {
    //            return ReminderLastCronRun.The0011130T0000000600;
    //        }
    //        throw new Exception("Cannot unmarshal type ReminderLastCronRun");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (ReminderLastCronRun)untypedValue;
    //        if (value == ReminderLastCronRun.The0011130T0000000600)
    //        {
    //            serializer.Serialize(writer, "-001-11-30T00:00:00-06:00");
    //            return;
    //        }
    //        throw new Exception("Cannot marshal type ReminderLastCronRun");
    //    }

    //    public static readonly ReminderLastCronRunConverter Singleton = new ReminderLastCronRunConverter();
    //}

    internal class ReminderOffsetSignConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ReminderOffsetSign) || t == typeof(ReminderOffsetSign?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "+")
            {
                return ReminderOffsetSign.Empty;
            }
            throw new Exception("Cannot unmarshal type ReminderOffsetSign");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ReminderOffsetSign)untypedValue;
            if (value == ReminderOffsetSign.Empty)
            {
                serializer.Serialize(writer, "+");
                return;
            }
            throw new Exception("Cannot marshal type ReminderOffsetSign");
        }

        public static readonly ReminderOffsetSignConverter Singleton = new ReminderOffsetSignConverter();
    }

    internal class OffsetTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OffsetType) || t == typeof(OffsetType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "day")
            {
                return OffsetType.Day;
            }
            throw new Exception("Cannot unmarshal type OffsetType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OffsetType)untypedValue;
            if (value == OffsetType.Day)
            {
                serializer.Serialize(writer, "day");
                return;
            }
            throw new Exception("Cannot marshal type OffsetType");
        }

        public static readonly OffsetTypeConverter Singleton = new OffsetTypeConverter();
    }

    internal class ReminderTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ReminderType) || t == typeof(ReminderType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "month_day")
            {
                return ReminderType.MonthDay;
            }
            throw new Exception("Cannot unmarshal type ReminderType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ReminderType)untypedValue;
            if (value == ReminderType.MonthDay)
            {
                serializer.Serialize(writer, "month_day");
                return;
            }
            throw new Exception("Cannot marshal type ReminderType");
        }

        public static readonly ReminderTypeConverter Singleton = new ReminderTypeConverter();
    }

    internal class ResponderTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ResponderType) || t == typeof(ResponderType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "subscribe")
            {
                return ResponderType.Subscribe;
            }
            throw new Exception("Cannot unmarshal type ResponderType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ResponderType)untypedValue;
            if (value == ResponderType.Subscribe)
            {
                serializer.Serialize(writer, "subscribe");
                return;
            }
            throw new Exception("Cannot marshal type ResponderType");
        }

        public static readonly ResponderTypeConverter Singleton = new ResponderTypeConverter();
    }

    internal class SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Source) || t == typeof(Source?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "copy":
                    return Source.Copy;
                case "web":
                    return Source.Web;
            }
            throw new Exception("Cannot unmarshal type Source");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Source)untypedValue;
            switch (value)
            {
                case Source.Copy:
                    serializer.Serialize(writer, "copy");
                    return;
                case Source.Web:
                    serializer.Serialize(writer, "web");
                    return;
            }
            throw new Exception("Cannot marshal type Source");
        }

        public static readonly SourceConverter Singleton = new SourceConverter();
    }

    internal class SplitTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SplitType) || t == typeof(SplitType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "even")
            {
                return SplitType.Even;
            }
            throw new Exception("Cannot unmarshal type SplitType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SplitType)untypedValue;
            if (value == SplitType.Even)
            {
                serializer.Serialize(writer, "even");
                return;
            }
            throw new Exception("Cannot marshal type SplitType");
        }

        public static readonly SplitTypeConverter Singleton = new SplitTypeConverter();
    }
    internal class TrackLinksConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TrackLinks) || t == typeof(TrackLinks?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "all":
                    return TrackLinks.All;
                case "mime":
                    return TrackLinks.Mime;
                case "none":
                    return TrackLinks.None;
            }
            throw new Exception("Cannot unmarshal type Tracklinks");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TrackLinks)untypedValue;
            switch (value)
            {
                case TrackLinks.All:
                    serializer.Serialize(writer, "all");
                    return;
                case TrackLinks.Mime:
                    serializer.Serialize(writer, "mime");
                    return;
                case TrackLinks.None:
                    serializer.Serialize(writer, "none");
                    return;
            }
            throw new Exception("Cannot marshal type TrackLinks");
        }

        public static readonly TrackLinksConverter Singleton = new TrackLinksConverter();
    }

    internal class DecodingChoiceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return integerValue;
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return l;
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value);
            return;
        }

        public static readonly DecodingChoiceConverter Singleton = new DecodingChoiceConverter();
    }

    internal class SendTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SendType) || t == typeof(SendType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return SendType.Empty;
                case "imm":
                    return SendType.Imm;
            }
            throw new Exception("Cannot unmarshal type SendType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SendType)untypedValue;
            switch (value)
            {
                case SendType.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case SendType.Imm:
                    serializer.Serialize(writer, "imm");
                    return;
            }
            throw new Exception("Cannot marshal type SendType");
        }

        public static readonly SendTypeConverter Singleton = new SendTypeConverter();
    }
    internal class WaitTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WaitType) || t == typeof(WaitType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "for":
                    return WaitType.For;
                case "until":
                    return WaitType.Until;
            }
            throw new Exception("Cannot unmarshal type WaitType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WaitType)untypedValue;
            switch (value)
            {
                case WaitType.For:
                    serializer.Serialize(writer, "for");
                    return;
                case WaitType.Until:
                    serializer.Serialize(writer, "until");
                    return;
            }
            throw new Exception("Cannot marshal type WaitType");
        }

        public static readonly WaitTypeConverter Singleton = new WaitTypeConverter();
    }
    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "single")
            {
                return TypeEnum.Single;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Single)
            {
                serializer.Serialize(writer, "single");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
    internal class TestingConverter : JsonConverter
    {
        public static readonly TestingConverter Singleton = new TestingConverter();
        public override bool CanConvert(Type t)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);

            return value;
            //long l;
            //if (Int64.TryParse(value, out l))
            //{
            //    return l;
            //}
            //throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }


    }
}
