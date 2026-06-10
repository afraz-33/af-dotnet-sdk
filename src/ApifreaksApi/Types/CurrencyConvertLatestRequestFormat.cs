using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(CurrencyConvertLatestRequestFormat.CurrencyConvertLatestRequestFormatSerializer)
)]
[Serializable]
public readonly record struct CurrencyConvertLatestRequestFormat : IStringEnum
{
    public static readonly CurrencyConvertLatestRequestFormat Json = new(Values.Json);

    public static readonly CurrencyConvertLatestRequestFormat Xml = new(Values.Xml);

    public CurrencyConvertLatestRequestFormat(string value)
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
    public static CurrencyConvertLatestRequestFormat FromCustom(string value)
    {
        return new CurrencyConvertLatestRequestFormat(value);
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

    public static bool operator ==(CurrencyConvertLatestRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CurrencyConvertLatestRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CurrencyConvertLatestRequestFormat value) => value.Value;

    public static explicit operator CurrencyConvertLatestRequestFormat(string value) => new(value);

    internal class CurrencyConvertLatestRequestFormatSerializer
        : JsonConverter<CurrencyConvertLatestRequestFormat>
    {
        public override CurrencyConvertLatestRequestFormat Read(
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
            return new CurrencyConvertLatestRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CurrencyConvertLatestRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CurrencyConvertLatestRequestFormat ReadAsPropertyName(
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
            return new CurrencyConvertLatestRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CurrencyConvertLatestRequestFormat value,
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
