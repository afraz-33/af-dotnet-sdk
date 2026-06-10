using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(AirQualityRequestPrecision.AirQualityRequestPrecisionSerializer))]
[Serializable]
public readonly record struct AirQualityRequestPrecision : IStringEnum
{
    public static readonly AirQualityRequestPrecision Hourly = new(Values.Hourly);

    public AirQualityRequestPrecision(string value)
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
    public static AirQualityRequestPrecision FromCustom(string value)
    {
        return new AirQualityRequestPrecision(value);
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

    public static bool operator ==(AirQualityRequestPrecision value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AirQualityRequestPrecision value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AirQualityRequestPrecision value) => value.Value;

    public static explicit operator AirQualityRequestPrecision(string value) => new(value);

    internal class AirQualityRequestPrecisionSerializer : JsonConverter<AirQualityRequestPrecision>
    {
        public override AirQualityRequestPrecision Read(
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
            return new AirQualityRequestPrecision(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AirQualityRequestPrecision value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AirQualityRequestPrecision ReadAsPropertyName(
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
            return new AirQualityRequestPrecision(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AirQualityRequestPrecision value,
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
        public const string Hourly = "hourly";
    }
}
