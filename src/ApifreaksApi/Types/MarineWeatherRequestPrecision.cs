using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(MarineWeatherRequestPrecision.MarineWeatherRequestPrecisionSerializer))]
[Serializable]
public readonly record struct MarineWeatherRequestPrecision : IStringEnum
{
    public static readonly MarineWeatherRequestPrecision Daily = new(Values.Daily);

    public static readonly MarineWeatherRequestPrecision Hourly = new(Values.Hourly);

    public static readonly MarineWeatherRequestPrecision Minutely = new(Values.Minutely);

    public MarineWeatherRequestPrecision(string value)
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
    public static MarineWeatherRequestPrecision FromCustom(string value)
    {
        return new MarineWeatherRequestPrecision(value);
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

    public static bool operator ==(MarineWeatherRequestPrecision value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MarineWeatherRequestPrecision value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MarineWeatherRequestPrecision value) => value.Value;

    public static explicit operator MarineWeatherRequestPrecision(string value) => new(value);

    internal class MarineWeatherRequestPrecisionSerializer
        : JsonConverter<MarineWeatherRequestPrecision>
    {
        public override MarineWeatherRequestPrecision Read(
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
            return new MarineWeatherRequestPrecision(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MarineWeatherRequestPrecision value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MarineWeatherRequestPrecision ReadAsPropertyName(
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
            return new MarineWeatherRequestPrecision(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MarineWeatherRequestPrecision value,
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
        public const string Daily = "daily";

        public const string Hourly = "hourly";

        public const string Minutely = "minutely";
    }
}
