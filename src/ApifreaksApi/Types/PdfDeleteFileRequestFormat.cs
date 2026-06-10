using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfDeleteFileRequestFormat.PdfDeleteFileRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfDeleteFileRequestFormat : IStringEnum
{
    public static readonly PdfDeleteFileRequestFormat Json = new(Values.Json);

    public static readonly PdfDeleteFileRequestFormat Xml = new(Values.Xml);

    public PdfDeleteFileRequestFormat(string value)
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
    public static PdfDeleteFileRequestFormat FromCustom(string value)
    {
        return new PdfDeleteFileRequestFormat(value);
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

    public static bool operator ==(PdfDeleteFileRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfDeleteFileRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfDeleteFileRequestFormat value) => value.Value;

    public static explicit operator PdfDeleteFileRequestFormat(string value) => new(value);

    internal class PdfDeleteFileRequestFormatSerializer : JsonConverter<PdfDeleteFileRequestFormat>
    {
        public override PdfDeleteFileRequestFormat Read(
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
            return new PdfDeleteFileRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfDeleteFileRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfDeleteFileRequestFormat ReadAsPropertyName(
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
            return new PdfDeleteFileRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfDeleteFileRequestFormat value,
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
