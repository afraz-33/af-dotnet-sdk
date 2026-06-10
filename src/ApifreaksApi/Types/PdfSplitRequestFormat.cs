using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfSplitRequestFormat.PdfSplitRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfSplitRequestFormat : IStringEnum
{
    public static readonly PdfSplitRequestFormat Json = new(Values.Json);

    public static readonly PdfSplitRequestFormat Xml = new(Values.Xml);

    public PdfSplitRequestFormat(string value)
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
    public static PdfSplitRequestFormat FromCustom(string value)
    {
        return new PdfSplitRequestFormat(value);
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

    public static bool operator ==(PdfSplitRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfSplitRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfSplitRequestFormat value) => value.Value;

    public static explicit operator PdfSplitRequestFormat(string value) => new(value);

    internal class PdfSplitRequestFormatSerializer : JsonConverter<PdfSplitRequestFormat>
    {
        public override PdfSplitRequestFormat Read(
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
            return new PdfSplitRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfSplitRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfSplitRequestFormat ReadAsPropertyName(
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
            return new PdfSplitRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfSplitRequestFormat value,
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
