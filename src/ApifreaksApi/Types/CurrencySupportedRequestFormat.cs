using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(CurrencySupportedRequestFormat.CurrencySupportedRequestFormatSerializer))]
[Serializable]
public readonly record struct CurrencySupportedRequestFormat : IStringEnum
{
    public static readonly CurrencySupportedRequestFormat Json = new(Values.Json);

    public static readonly CurrencySupportedRequestFormat Xml = new(Values.Xml);

    public CurrencySupportedRequestFormat(string value)
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
    public static CurrencySupportedRequestFormat FromCustom(string value)
    {
        return new CurrencySupportedRequestFormat(value);
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

    public static bool operator ==(CurrencySupportedRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CurrencySupportedRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CurrencySupportedRequestFormat value) => value.Value;

    public static explicit operator CurrencySupportedRequestFormat(string value) => new(value);

    internal class CurrencySupportedRequestFormatSerializer
        : JsonConverter<CurrencySupportedRequestFormat>
    {
        public override CurrencySupportedRequestFormat Read(
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
            return new CurrencySupportedRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CurrencySupportedRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CurrencySupportedRequestFormat ReadAsPropertyName(
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
            return new CurrencySupportedRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CurrencySupportedRequestFormat value,
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
