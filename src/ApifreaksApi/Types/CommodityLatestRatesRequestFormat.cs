using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(CommodityLatestRatesRequestFormat.CommodityLatestRatesRequestFormatSerializer)
)]
[Serializable]
public readonly record struct CommodityLatestRatesRequestFormat : IStringEnum
{
    public static readonly CommodityLatestRatesRequestFormat Json = new(Values.Json);

    public CommodityLatestRatesRequestFormat(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static CommodityLatestRatesRequestFormat FromCustom(string value)
    {
        return new CommodityLatestRatesRequestFormat(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(CommodityLatestRatesRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CommodityLatestRatesRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CommodityLatestRatesRequestFormat value) => value.Value;

    public static explicit operator CommodityLatestRatesRequestFormat(string value) => new(value);

    internal class CommodityLatestRatesRequestFormatSerializer
        : JsonConverter<CommodityLatestRatesRequestFormat>
    {
        public override CommodityLatestRatesRequestFormat Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new CommodityLatestRatesRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CommodityLatestRatesRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CommodityLatestRatesRequestFormat ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new CommodityLatestRatesRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CommodityLatestRatesRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Json = "json";
    }
}
