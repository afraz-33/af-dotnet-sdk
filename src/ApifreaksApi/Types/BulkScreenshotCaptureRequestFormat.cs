using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkScreenshotCaptureRequestFormat.BulkScreenshotCaptureRequestFormatSerializer)
)]
[Serializable]
public readonly record struct BulkScreenshotCaptureRequestFormat : IStringEnum
{
    public static readonly BulkScreenshotCaptureRequestFormat Json = new(Values.Json);

    public BulkScreenshotCaptureRequestFormat(string value)
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
    public static BulkScreenshotCaptureRequestFormat FromCustom(string value)
    {
        return new BulkScreenshotCaptureRequestFormat(value);
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

    public static bool operator ==(BulkScreenshotCaptureRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BulkScreenshotCaptureRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BulkScreenshotCaptureRequestFormat value) => value.Value;

    public static explicit operator BulkScreenshotCaptureRequestFormat(string value) => new(value);

    internal class BulkScreenshotCaptureRequestFormatSerializer
        : JsonConverter<BulkScreenshotCaptureRequestFormat>
    {
        public override BulkScreenshotCaptureRequestFormat Read(
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
            return new BulkScreenshotCaptureRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkScreenshotCaptureRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkScreenshotCaptureRequestFormat ReadAsPropertyName(
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
            return new BulkScreenshotCaptureRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkScreenshotCaptureRequestFormat value,
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
    }
}
