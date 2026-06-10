using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(HistoricalWeatherRequestPrecision.HistoricalWeatherRequestPrecisionSerializer)
)]
[Serializable]
public readonly record struct HistoricalWeatherRequestPrecision : IStringEnum
{
    public static readonly HistoricalWeatherRequestPrecision Daily = new(Values.Daily);

    public static readonly HistoricalWeatherRequestPrecision Hourly = new(Values.Hourly);

    public HistoricalWeatherRequestPrecision(string value)
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
    public static HistoricalWeatherRequestPrecision FromCustom(string value)
    {
        return new HistoricalWeatherRequestPrecision(value);
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

    public static bool operator ==(HistoricalWeatherRequestPrecision value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(HistoricalWeatherRequestPrecision value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(HistoricalWeatherRequestPrecision value) => value.Value;

    public static explicit operator HistoricalWeatherRequestPrecision(string value) => new(value);

    internal class HistoricalWeatherRequestPrecisionSerializer
        : JsonConverter<HistoricalWeatherRequestPrecision>
    {
        public override HistoricalWeatherRequestPrecision Read(
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
            return new HistoricalWeatherRequestPrecision(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            HistoricalWeatherRequestPrecision value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override HistoricalWeatherRequestPrecision ReadAsPropertyName(
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
            return new HistoricalWeatherRequestPrecision(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            HistoricalWeatherRequestPrecision value,
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
