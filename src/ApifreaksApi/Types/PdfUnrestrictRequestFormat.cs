using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfUnrestrictRequestFormat.PdfUnrestrictRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfUnrestrictRequestFormat : IStringEnum
{
    public static readonly PdfUnrestrictRequestFormat Json = new(Values.Json);

    public static readonly PdfUnrestrictRequestFormat Xml = new(Values.Xml);

    public PdfUnrestrictRequestFormat(string value)
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
    public static PdfUnrestrictRequestFormat FromCustom(string value)
    {
        return new PdfUnrestrictRequestFormat(value);
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

    public static bool operator ==(PdfUnrestrictRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfUnrestrictRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfUnrestrictRequestFormat value) => value.Value;

    public static explicit operator PdfUnrestrictRequestFormat(string value) => new(value);

    internal class PdfUnrestrictRequestFormatSerializer : JsonConverter<PdfUnrestrictRequestFormat>
    {
        public override PdfUnrestrictRequestFormat Read(
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
            return new PdfUnrestrictRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfUnrestrictRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfUnrestrictRequestFormat ReadAsPropertyName(
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
            return new PdfUnrestrictRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfUnrestrictRequestFormat value,
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
