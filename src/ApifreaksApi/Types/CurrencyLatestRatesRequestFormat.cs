using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(CurrencyLatestRatesRequestFormat.CurrencyLatestRatesRequestFormatSerializer))]
[Serializable]
public readonly record struct CurrencyLatestRatesRequestFormat : IStringEnum
{
    public static readonly CurrencyLatestRatesRequestFormat Json = new(Values.Json);

    public static readonly CurrencyLatestRatesRequestFormat Xml = new(Values.Xml);

    public CurrencyLatestRatesRequestFormat(string value)
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
    public static CurrencyLatestRatesRequestFormat FromCustom(string value)
    {
        return new CurrencyLatestRatesRequestFormat(value);
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

    public static bool operator ==(CurrencyLatestRatesRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CurrencyLatestRatesRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CurrencyLatestRatesRequestFormat value) => value.Value;

    public static explicit operator CurrencyLatestRatesRequestFormat(string value) => new(value);

    internal class CurrencyLatestRatesRequestFormatSerializer
        : JsonConverter<CurrencyLatestRatesRequestFormat>
    {
        public override CurrencyLatestRatesRequestFormat Read(
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
            return new CurrencyLatestRatesRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CurrencyLatestRatesRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CurrencyLatestRatesRequestFormat ReadAsPropertyName(
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
            return new CurrencyLatestRatesRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CurrencyLatestRatesRequestFormat value,
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
