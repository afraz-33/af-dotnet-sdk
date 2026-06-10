using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GetFlagsRequestShape.GetFlagsRequestShapeSerializer))]
[Serializable]
public readonly record struct GetFlagsRequestShape : IStringEnum
{
    public static readonly GetFlagsRequestShape Flat = new(Values.Flat);

    public static readonly GetFlagsRequestShape Round = new(Values.Round);

    public GetFlagsRequestShape(string value)
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
    public static GetFlagsRequestShape FromCustom(string value)
    {
        return new GetFlagsRequestShape(value);
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

    public static bool operator ==(GetFlagsRequestShape value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetFlagsRequestShape value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetFlagsRequestShape value) => value.Value;

    public static explicit operator GetFlagsRequestShape(string value) => new(value);

    internal class GetFlagsRequestShapeSerializer : JsonConverter<GetFlagsRequestShape>
    {
        public override GetFlagsRequestShape Read(
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
            return new GetFlagsRequestShape(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetFlagsRequestShape value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetFlagsRequestShape ReadAsPropertyName(
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
            return new GetFlagsRequestShape(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetFlagsRequestShape value,
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
        public const string Flat = "flat";

        public const string Round = "round";
    }
}
