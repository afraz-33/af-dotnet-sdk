using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel.ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevelSerializer)
)]
[Serializable]
public readonly record struct ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel
    : IStringEnum
{
    public static readonly ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel VeryEasy =
        new(Values.VeryEasy);

    public static readonly ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel Easy =
        new(Values.Easy);

    public static readonly ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel Medium =
        new(Values.Medium);

    public static readonly ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel Hard =
        new(Values.Hard);

    public static readonly ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel VeryHard =
        new(Values.VeryHard);

    public ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel(string value)
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
    public static ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel FromCustom(
        string value
    )
    {
        return new ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel(value);
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

    public static bool operator ==(
        ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel value
    ) => value.Value;

    public static explicit operator ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel(
        string value
    ) => new(value);

    internal class ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevelSerializer
        : JsonConverter<ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel>
    {
        public override ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel Read(
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
            return new ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel ReadAsPropertyName(
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
            return new ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel value,
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
        public const string VeryEasy = "Very Easy";

        public const string Easy = "Easy";

        public const string Medium = "Medium";

        public const string Hard = "Hard";

        public const string VeryHard = "Very Hard";
    }
}
