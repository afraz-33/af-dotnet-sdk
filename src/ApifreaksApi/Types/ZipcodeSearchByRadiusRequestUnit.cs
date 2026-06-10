using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(ZipcodeSearchByRadiusRequestUnit.ZipcodeSearchByRadiusRequestUnitSerializer))]
[Serializable]
public readonly record struct ZipcodeSearchByRadiusRequestUnit : IStringEnum
{
    public static readonly ZipcodeSearchByRadiusRequestUnit M = new(Values.M);

    public static readonly ZipcodeSearchByRadiusRequestUnit Km = new(Values.Km);

    public static readonly ZipcodeSearchByRadiusRequestUnit Mi = new(Values.Mi);

    public static readonly ZipcodeSearchByRadiusRequestUnit Ft = new(Values.Ft);

    public static readonly ZipcodeSearchByRadiusRequestUnit Yd = new(Values.Yd);

    public static readonly ZipcodeSearchByRadiusRequestUnit In = new(Values.In);

    public ZipcodeSearchByRadiusRequestUnit(string value)
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
    public static ZipcodeSearchByRadiusRequestUnit FromCustom(string value)
    {
        return new ZipcodeSearchByRadiusRequestUnit(value);
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

    public static bool operator ==(ZipcodeSearchByRadiusRequestUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ZipcodeSearchByRadiusRequestUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ZipcodeSearchByRadiusRequestUnit value) => value.Value;

    public static explicit operator ZipcodeSearchByRadiusRequestUnit(string value) => new(value);

    internal class ZipcodeSearchByRadiusRequestUnitSerializer
        : JsonConverter<ZipcodeSearchByRadiusRequestUnit>
    {
        public override ZipcodeSearchByRadiusRequestUnit Read(
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
            return new ZipcodeSearchByRadiusRequestUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ZipcodeSearchByRadiusRequestUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ZipcodeSearchByRadiusRequestUnit ReadAsPropertyName(
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
            return new ZipcodeSearchByRadiusRequestUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ZipcodeSearchByRadiusRequestUnit value,
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
