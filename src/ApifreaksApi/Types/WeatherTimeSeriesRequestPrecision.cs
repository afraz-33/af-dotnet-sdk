using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(WeatherTimeSeriesRequestPrecision.WeatherTimeSeriesRequestPrecisionSerializer)
)]
[Serializable]
public readonly record struct WeatherTimeSeriesRequestPrecision : IStringEnum
{
    public static readonly WeatherTimeSeriesRequestPrecision Daily = new(Values.Daily);

    public static readonly WeatherTimeSeriesRequestPrecision Hourly = new(Values.Hourly);

    public WeatherTimeSeriesRequestPrecision(string value)
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
    public static WeatherTimeSeriesRequestPrecision FromCustom(string value)
    {
        return new WeatherTimeSeriesRequestPrecision(value);
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

    public static bool operator ==(WeatherTimeSeriesRequestPrecision value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WeatherTimeSeriesRequestPrecision value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WeatherTimeSeriesRequestPrecision value) => value.Value;

    public static explicit operator WeatherTimeSeriesRequestPrecision(string value) => new(value);

    internal class WeatherTimeSeriesRequestPrecisionSerializer
        : JsonConverter<WeatherTimeSeriesRequestPrecision>
    {
        public override WeatherTimeSeriesRequestPrecision Read(
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
            return new WeatherTimeSeriesRequestPrecision(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WeatherTimeSeriesRequestPrecision value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WeatherTimeSeriesRequestPrecision ReadAsPropertyName(
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
            return new WeatherTimeSeriesRequestPrecision(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WeatherTimeSeriesRequestPrecision value,
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
    }
}
