using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(TimezoneLookupRequestFormat.TimezoneLookupRequestFormatSerializer))]
[Serializable]
public readonly record struct TimezoneLookupRequestFormat : IStringEnum
{
    public static readonly TimezoneLookupRequestFormat Json = new(Values.Json);

    public static readonly TimezoneLookupRequestFormat Xml = new(Values.Xml);

    public TimezoneLookupRequestFormat(string value)
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
    public static TimezoneLookupRequestFormat FromCustom(string value)
    {
        return new TimezoneLookupRequestFormat(value);
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

    public static bool operator ==(TimezoneLookupRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TimezoneLookupRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TimezoneLookupRequestFormat value) => value.Value;

    public static explicit operator TimezoneLookupRequestFormat(string value) => new(value);

    internal class TimezoneLookupRequestFormatSerializer
        : JsonConverter<TimezoneLookupRequestFormat>
    {
        public override TimezoneLookupRequestFormat Read(
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
            return new TimezoneLookupRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TimezoneLookupRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TimezoneLookupRequestFormat ReadAsPropertyName(
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
            return new TimezoneLookupRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TimezoneLookupRequestFormat value,
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
