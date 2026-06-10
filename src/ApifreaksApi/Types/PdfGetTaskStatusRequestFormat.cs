using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfGetTaskStatusRequestFormat.PdfGetTaskStatusRequestFormatSerializer))]
[Serializable]
public readonly record struct PdfGetTaskStatusRequestFormat : IStringEnum
{
    public static readonly PdfGetTaskStatusRequestFormat Json = new(Values.Json);

    public static readonly PdfGetTaskStatusRequestFormat Xml = new(Values.Xml);

    public PdfGetTaskStatusRequestFormat(string value)
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
    public static PdfGetTaskStatusRequestFormat FromCustom(string value)
    {
        return new PdfGetTaskStatusRequestFormat(value);
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

    public static bool operator ==(PdfGetTaskStatusRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfGetTaskStatusRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfGetTaskStatusRequestFormat value) => value.Value;

    public static explicit operator PdfGetTaskStatusRequestFormat(string value) => new(value);

    internal class PdfGetTaskStatusRequestFormatSerializer
        : JsonConverter<PdfGetTaskStatusRequestFormat>
    {
        public override PdfGetTaskStatusRequestFormat Read(
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
            return new PdfGetTaskStatusRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfGetTaskStatusRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfGetTaskStatusRequestFormat ReadAsPropertyName(
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
            return new PdfGetTaskStatusRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfGetTaskStatusRequestFormat value,
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
