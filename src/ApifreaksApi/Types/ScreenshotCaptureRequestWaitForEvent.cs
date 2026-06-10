using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(ScreenshotCaptureRequestWaitForEvent.ScreenshotCaptureRequestWaitForEventSerializer)
)]
[Serializable]
public readonly record struct ScreenshotCaptureRequestWaitForEvent : IStringEnum
{
    public static readonly ScreenshotCaptureRequestWaitForEvent Load = new(Values.Load);

    public static readonly ScreenshotCaptureRequestWaitForEvent Domcontentloaded = new(
        Values.Domcontentloaded
    );

    public static readonly ScreenshotCaptureRequestWaitForEvent Networkidle = new(
        Values.Networkidle
    );

    public ScreenshotCaptureRequestWaitForEvent(string value)
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
    public static ScreenshotCaptureRequestWaitForEvent FromCustom(string value)
    {
        return new ScreenshotCaptureRequestWaitForEvent(value);
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

    public static bool operator ==(ScreenshotCaptureRequestWaitForEvent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScreenshotCaptureRequestWaitForEvent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScreenshotCaptureRequestWaitForEvent value) =>
        value.Value;

    public static explicit operator ScreenshotCaptureRequestWaitForEvent(string value) =>
        new(value);

    internal class ScreenshotCaptureRequestWaitForEventSerializer
        : JsonConverter<ScreenshotCaptureRequestWaitForEvent>
    {
        public override ScreenshotCaptureRequestWaitForEvent Read(
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
            return new ScreenshotCaptureRequestWaitForEvent(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ScreenshotCaptureRequestWaitForEvent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ScreenshotCaptureRequestWaitForEvent ReadAsPropertyName(
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
            return new ScreenshotCaptureRequestWaitForEvent(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ScreenshotCaptureRequestWaitForEvent value,
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
        public const string Load = "load";

        public const string Domcontentloaded = "domcontentloaded";

        public const string Networkidle = "networkidle";
    }
}
