using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfEncryptRequestFormat.PdfEncryptRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfEncryptRequestFormat : IStringEnum
{
    public static readonly PdfEncryptRequestFormat Json = new(Values.Json);

    public static readonly PdfEncryptRequestFormat Xml = new(Values.Xml);

    public PdfEncryptRequestFormat(string value)
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
    public static PdfEncryptRequestFormat FromCustom(string value)
    {
        return new PdfEncryptRequestFormat(value);
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

    public static bool operator ==(PdfEncryptRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfEncryptRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfEncryptRequestFormat value) => value.Value;

    public static explicit operator PdfEncryptRequestFormat(string value) => new(value);

    internal class PdfEncryptRequestFormatSerializer : JsonConverter<PdfEncryptRequestFormat>
    {
        public override PdfEncryptRequestFormat Read(
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
            return new PdfEncryptRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfEncryptRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfEncryptRequestFormat ReadAsPropertyName(
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
            return new PdfEncryptRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfEncryptRequestFormat value,
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
