using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GeocoderSearchRequestFormat.GeocoderSearchRequestFormatSerializer))]
[Serializable]
public readonly record struct GeocoderSearchRequestFormat : IStringEnum
{
    public static readonly GeocoderSearchRequestFormat Json = new(Values.Json);

    public GeocoderSearchRequestFormat(string value)
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
    public static GeocoderSearchRequestFormat FromCustom(string value)
    {
        return new GeocoderSearchRequestFormat(value);
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

    public static bool operator ==(GeocoderSearchRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GeocoderSearchRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GeocoderSearchRequestFormat value) => value.Value;

    public static explicit operator GeocoderSearchRequestFormat(string value) => new(value);

    internal class GeocoderSearchRequestFormatSerializer
        : JsonConverter<GeocoderSearchRequestFormat>
    {
        public override GeocoderSearchRequestFormat Read(
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
            return new GeocoderSearchRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GeocoderSearchRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GeocoderSearchRequestFormat ReadAsPropertyName(
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
            return new GeocoderSearchRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GeocoderSearchRequestFormat value,
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
