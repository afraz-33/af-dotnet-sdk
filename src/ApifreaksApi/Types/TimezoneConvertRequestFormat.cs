using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(TimezoneConvertRequestFormat.TimezoneConvertRequestFormatSerializer))]
[Serializable]
public readonly record struct TimezoneConvertRequestFormat : IStringEnum
{
    public static readonly TimezoneConvertRequestFormat Json = new(Values.Json);

    public static readonly TimezoneConvertRequestFormat Xml = new(Values.Xml);

    public TimezoneConvertRequestFormat(string value)
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
    public static TimezoneConvertRequestFormat FromCustom(string value)
    {
        return new TimezoneConvertRequestFormat(value);
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

    public static bool operator ==(TimezoneConvertRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimezoneConvertRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimezoneConvertRequestFormat value) => value.Value;

    public static explicit operator TimezoneConvertRequestFormat(string value) => new(value);

    internal class TimezoneConvertRequestFormatSerializer
        : JsonConverter<TimezoneConvertRequestFormat>
    {
        public override TimezoneConvertRequestFormat Read(
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
            return new TimezoneConvertRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TimezoneConvertRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TimezoneConvertRequestFormat ReadAsPropertyName(
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
            return new TimezoneConvertRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TimezoneConvertRequestFormat value,
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

        public const string Xml = "xml";
    }
}
