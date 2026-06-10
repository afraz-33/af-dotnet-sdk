using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(CurrencyConvertHistoricalRequestFormat.CurrencyConvertHistoricalRequestFormatSerializer)
)]
[Serializable]
public readonly record struct CurrencyConvertHistoricalRequestFormat : IStringEnum
{
    public static readonly CurrencyConvertHistoricalRequestFormat Json = new(Values.Json);

    public static readonly CurrencyConvertHistoricalRequestFormat Xml = new(Values.Xml);

    public CurrencyConvertHistoricalRequestFormat(string value)
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
    public static CurrencyConvertHistoricalRequestFormat FromCustom(string value)
    {
        return new CurrencyConvertHistoricalRequestFormat(value);
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

    public static bool operator ==(CurrencyConvertHistoricalRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CurrencyConvertHistoricalRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CurrencyConvertHistoricalRequestFormat value) =>
        value.Value;

    public static explicit operator CurrencyConvertHistoricalRequestFormat(string value) =>
        new(value);

    internal class CurrencyConvertHistoricalRequestFormatSerializer
        : JsonConverter<CurrencyConvertHistoricalRequestFormat>
    {
        public override CurrencyConvertHistoricalRequestFormat Read(
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
            return new CurrencyConvertHistoricalRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CurrencyConvertHistoricalRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CurrencyConvertHistoricalRequestFormat ReadAsPropertyName(
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
            return new CurrencyConvertHistoricalRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CurrencyConvertHistoricalRequestFormat value,
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

        public const string Xml = "xml";
    }
}
