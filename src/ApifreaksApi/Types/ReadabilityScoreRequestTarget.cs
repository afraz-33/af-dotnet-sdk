using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(ReadabilityScoreRequestTarget.ReadabilityScoreRequestTargetSerializer))]
[Serializable]
public readonly record struct ReadabilityScoreRequestTarget : IStringEnum
{
    public static readonly ReadabilityScoreRequestTarget General = new(Values.General);

    public static readonly ReadabilityScoreRequestTarget Professional = new(Values.Professional);

    public static readonly ReadabilityScoreRequestTarget Academic = new(Values.Academic);

    public static readonly ReadabilityScoreRequestTarget Technical = new(Values.Technical);

    public ReadabilityScoreRequestTarget(string value)
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
    public static ReadabilityScoreRequestTarget FromCustom(string value)
    {
        return new ReadabilityScoreRequestTarget(value);
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

    public static bool operator ==(ReadabilityScoreRequestTarget value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReadabilityScoreRequestTarget value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReadabilityScoreRequestTarget value) => value.Value;

    public static explicit operator ReadabilityScoreRequestTarget(string value) => new(value);

    internal class ReadabilityScoreRequestTargetSerializer
        : JsonConverter<ReadabilityScoreRequestTarget>
    {
        public override ReadabilityScoreRequestTarget Read(
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
            return new ReadabilityScoreRequestTarget(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReadabilityScoreRequestTarget value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReadabilityScoreRequestTarget ReadAsPropertyName(
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
            return new ReadabilityScoreRequestTarget(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReadabilityScoreRequestTarget value,
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
        public const string General = "general";

        public const string Professional = "professional";

        public const string Academic = "academic";

        public const string Technical = "technical";
    }
}
