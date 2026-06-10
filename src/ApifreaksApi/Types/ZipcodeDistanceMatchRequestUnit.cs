using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(ZipcodeDistanceMatchRequestUnit.ZipcodeDistanceMatchRequestUnitSerializer))]
[Serializable]
public readonly record struct ZipcodeDistanceMatchRequestUnit : IStringEnum
{
    public static readonly ZipcodeDistanceMatchRequestUnit M = new(Values.M);

    public static readonly ZipcodeDistanceMatchRequestUnit Km = new(Values.Km);

    public static readonly ZipcodeDistanceMatchRequestUnit Mi = new(Values.Mi);

    public static readonly ZipcodeDistanceMatchRequestUnit Ft = new(Values.Ft);

    public static readonly ZipcodeDistanceMatchRequestUnit Yd = new(Values.Yd);

    public static readonly ZipcodeDistanceMatchRequestUnit In = new(Values.In);

    public ZipcodeDistanceMatchRequestUnit(string value)
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
    public static ZipcodeDistanceMatchRequestUnit FromCustom(string value)
    {
        return new ZipcodeDistanceMatchRequestUnit(value);
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

    public static bool operator ==(ZipcodeDistanceMatchRequestUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ZipcodeDistanceMatchRequestUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ZipcodeDistanceMatchRequestUnit value) => value.Value;

    public static explicit operator ZipcodeDistanceMatchRequestUnit(string value) => new(value);

    internal class ZipcodeDistanceMatchRequestUnitSerializer
        : JsonConverter<ZipcodeDistanceMatchRequestUnit>
    {
        public override ZipcodeDistanceMatchRequestUnit Read(
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
            return new ZipcodeDistanceMatchRequestUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ZipcodeDistanceMatchRequestUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ZipcodeDistanceMatchRequestUnit ReadAsPropertyName(
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
            return new ZipcodeDistanceMatchRequestUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ZipcodeDistanceMatchRequestUnit value,
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
        public const string M = "m";

        public const string Km = "km";

        public const string Mi = "mi";

        public const string Ft = "ft";

        public const string Yd = "yd";

        public const string In = "in";
    }
}
