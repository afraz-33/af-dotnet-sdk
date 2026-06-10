using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(ScreenshotCaptureRequestScrollSpeed.ScreenshotCaptureRequestScrollSpeedSerializer)
)]
[Serializable]
public readonly record struct ScreenshotCaptureRequestScrollSpeed : IStringEnum
{
    public static readonly ScreenshotCaptureRequestScrollSpeed Normal = new(Values.Normal);

    public static readonly ScreenshotCaptureRequestScrollSpeed Fast = new(Values.Fast);

    public static readonly ScreenshotCaptureRequestScrollSpeed Slow = new(Values.Slow);

    public ScreenshotCaptureRequestScrollSpeed(string value)
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
    public static ScreenshotCaptureRequestScrollSpeed FromCustom(string value)
    {
        return new ScreenshotCaptureRequestScrollSpeed(value);
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

    public static bool operator ==(ScreenshotCaptureRequestScrollSpeed value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScreenshotCaptureRequestScrollSpeed value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScreenshotCaptureRequestScrollSpeed value) =>
        value.Value;

    public static explicit operator ScreenshotCaptureRequestScrollSpeed(string value) => new(value);

    internal class ScreenshotCaptureRequestScrollSpeedSerializer
        : JsonConverter<ScreenshotCaptureRequestScrollSpeed>
    {
        public override ScreenshotCaptureRequestScrollSpeed Read(
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
            return new ScreenshotCaptureRequestScrollSpeed(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ScreenshotCaptureRequestScrollSpeed value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ScreenshotCaptureRequestScrollSpeed ReadAsPropertyName(
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
            return new ScreenshotCaptureRequestScrollSpeed(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ScreenshotCaptureRequestScrollSpeed value,
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
        public const string Normal = "normal";

        public const string Fast = "fast";

        public const string Slow = "slow";
    }
}
