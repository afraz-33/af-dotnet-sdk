using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfCompressRequestFormat.PdfCompressRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfCompressRequestFormat : IStringEnum
{
    public static readonly PdfCompressRequestFormat Json = new(Values.Json);

    public static readonly PdfCompressRequestFormat Xml = new(Values.Xml);

    public PdfCompressRequestFormat(string value)
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
    public static PdfCompressRequestFormat FromCustom(string value)
    {
        return new PdfCompressRequestFormat(value);
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

    public static bool operator ==(PdfCompressRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfCompressRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfCompressRequestFormat value) => value.Value;

    public static explicit operator PdfCompressRequestFormat(string value) => new(value);

    internal class PdfCompressRequestFormatSerializer : JsonConverter<PdfCompressRequestFormat>
    {
        public override PdfCompressRequestFormat Read(
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
            return new PdfCompressRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfCompressRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfCompressRequestFormat ReadAsPropertyName(
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
            return new PdfCompressRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfCompressRequestFormat value,
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
