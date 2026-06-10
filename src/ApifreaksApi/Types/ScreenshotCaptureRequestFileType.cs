using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(ScreenshotCaptureRequestFileType.ScreenshotCaptureRequestFileTypeSerializer))]
[Serializable]
public readonly record struct ScreenshotCaptureRequestFileType : IStringEnum
{
    public static readonly ScreenshotCaptureRequestFileType Png = new(Values.Png);

    public static readonly ScreenshotCaptureRequestFileType Jpeg = new(Values.Jpeg);

    public static readonly ScreenshotCaptureRequestFileType Webp = new(Values.Webp);

    public static readonly ScreenshotCaptureRequestFileType Pdf = new(Values.Pdf);

    public static readonly ScreenshotCaptureRequestFileType Mp4 = new(Values.Mp4);

    public static readonly ScreenshotCaptureRequestFileType Gif = new(Values.Gif);

    public static readonly ScreenshotCaptureRequestFileType Webm = new(Values.Webm);

    public ScreenshotCaptureRequestFileType(string value)
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
    public static ScreenshotCaptureRequestFileType FromCustom(string value)
    {
        return new ScreenshotCaptureRequestFileType(value);
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

    public static bool operator ==(ScreenshotCaptureRequestFileType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScreenshotCaptureRequestFileType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScreenshotCaptureRequestFileType value) => value.Value;

    public static explicit operator ScreenshotCaptureRequestFileType(string value) => new(value);

    internal class ScreenshotCaptureRequestFileTypeSerializer
        : JsonConverter<ScreenshotCaptureRequestFileType>
    {
        public override ScreenshotCaptureRequestFileType Read(
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
            return new ScreenshotCaptureRequestFileType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ScreenshotCaptureRequestFileType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ScreenshotCaptureRequestFileType ReadAsPropertyName(
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
            return new ScreenshotCaptureRequestFileType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ScreenshotCaptureRequestFileType value,
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
        public const string Png = "PNG";

        public const string Jpeg = "JPEG";

        public const string Webp = "WEBP";

        public const string Pdf = "PDF";

        public const string Mp4 = "mp4";

        public const string Gif = "gif";

        public const string Webm = "webm";
    }
}
