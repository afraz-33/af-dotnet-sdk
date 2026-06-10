using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfUploadBinaryRequestFormat.PdfUploadBinaryRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfUploadBinaryRequestFormat : IStringEnum
{
    public static readonly PdfUploadBinaryRequestFormat Json = new(Values.Json);

    public static readonly PdfUploadBinaryRequestFormat Xml = new(Values.Xml);

    public PdfUploadBinaryRequestFormat(string value)
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
    public static PdfUploadBinaryRequestFormat FromCustom(string value)
    {
        return new PdfUploadBinaryRequestFormat(value);
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

    public static bool operator ==(PdfUploadBinaryRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfUploadBinaryRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfUploadBinaryRequestFormat value) => value.Value;

    public static explicit operator PdfUploadBinaryRequestFormat(string value) => new(value);

    internal class PdfUploadBinaryRequestFormatSerializer
        : JsonConverter<PdfUploadBinaryRequestFormat>
    {
        public override PdfUploadBinaryRequestFormat Read(
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
            return new PdfUploadBinaryRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfUploadBinaryRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfUploadBinaryRequestFormat ReadAsPropertyName(
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
            return new PdfUploadBinaryRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfUploadBinaryRequestFormat value,
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
