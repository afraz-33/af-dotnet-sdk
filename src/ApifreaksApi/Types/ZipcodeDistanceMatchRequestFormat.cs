using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(ZipcodeDistanceMatchRequestFormat.ZipcodeDistanceMatchRequestFormatSerializer)
)]
[Serializable]
public readonly record struct ZipcodeDistanceMatchRequestFormat : IStringEnum
{
    public static readonly ZipcodeDistanceMatchRequestFormat Json = new(Values.Json);

    public static readonly ZipcodeDistanceMatchRequestFormat Xml = new(Values.Xml);

    public ZipcodeDistanceMatchRequestFormat(string value)
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
    public static ZipcodeDistanceMatchRequestFormat FromCustom(string value)
    {
        return new ZipcodeDistanceMatchRequestFormat(value);
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

    public static bool operator ==(ZipcodeDistanceMatchRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ZipcodeDistanceMatchRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ZipcodeDistanceMatchRequestFormat value) => value.Value;

    public static explicit operator ZipcodeDistanceMatchRequestFormat(string value) => new(value);

    internal class ZipcodeDistanceMatchRequestFormatSerializer
        : JsonConverter<ZipcodeDistanceMatchRequestFormat>
    {
        public override ZipcodeDistanceMatchRequestFormat Read(
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
            return new ZipcodeDistanceMatchRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ZipcodeDistanceMatchRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ZipcodeDistanceMatchRequestFormat ReadAsPropertyName(
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
            return new ZipcodeDistanceMatchRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ZipcodeDistanceMatchRequestFormat value,
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
