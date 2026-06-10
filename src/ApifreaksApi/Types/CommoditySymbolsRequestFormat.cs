using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(CommoditySymbolsRequestFormat.CommoditySymbolsRequestFormatSerializer))]
[Serializable]
public readonly record struct CommoditySymbolsRequestFormat : IStringEnum
{
    public static readonly CommoditySymbolsRequestFormat Json = new(Values.Json);

    public CommoditySymbolsRequestFormat(string value)
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
    public static CommoditySymbolsRequestFormat FromCustom(string value)
    {
        return new CommoditySymbolsRequestFormat(value);
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

    public static bool operator ==(CommoditySymbolsRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CommoditySymbolsRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CommoditySymbolsRequestFormat value) => value.Value;

    public static explicit operator CommoditySymbolsRequestFormat(string value) => new(value);

    internal class CommoditySymbolsRequestFormatSerializer
        : JsonConverter<CommoditySymbolsRequestFormat>
    {
        public override CommoditySymbolsRequestFormat Read(
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
            return new CommoditySymbolsRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CommoditySymbolsRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CommoditySymbolsRequestFormat ReadAsPropertyName(
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
            return new CommoditySymbolsRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CommoditySymbolsRequestFormat value,
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
