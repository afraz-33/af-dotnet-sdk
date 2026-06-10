using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(WebScrapeRequestFormat.WebScrapeRequestFormatSerializer))]
[Serializable]
public readonly record struct WebScrapeRequestFormat : IStringEnum
{
    public static readonly WebScrapeRequestFormat Json = new(Values.Json);

    public WebScrapeRequestFormat(string value)
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
    public static WebScrapeRequestFormat FromCustom(string value)
    {
        return new WebScrapeRequestFormat(value);
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

    public static bool operator ==(WebScrapeRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebScrapeRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebScrapeRequestFormat value) => value.Value;

    public static explicit operator WebScrapeRequestFormat(string value) => new(value);

    internal class WebScrapeRequestFormatSerializer : JsonConverter<WebScrapeRequestFormat>
    {
        public override WebScrapeRequestFormat Read(
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
            return new WebScrapeRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WebScrapeRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WebScrapeRequestFormat ReadAsPropertyName(
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
            return new WebScrapeRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WebScrapeRequestFormat value,
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
