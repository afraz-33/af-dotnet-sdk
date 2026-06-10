using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GetFlagsRequestSize.GetFlagsRequestSizeSerializer))]
[Serializable]
public readonly record struct GetFlagsRequestSize : IStringEnum
{
    public static readonly GetFlagsRequestSize SixteenPx = new(Values.SixteenPx);

    public static readonly GetFlagsRequestSize TwentyFourPx = new(Values.TwentyFourPx);

    public static readonly GetFlagsRequestSize ThirtyTwoPx = new(Values.ThirtyTwoPx);

    public static readonly GetFlagsRequestSize FortyEightPx = new(Values.FortyEightPx);

    public static readonly GetFlagsRequestSize SixtyFourPx = new(Values.SixtyFourPx);

    public GetFlagsRequestSize(string value)
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
    public static GetFlagsRequestSize FromCustom(string value)
    {
        return new GetFlagsRequestSize(value);
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

    public static bool operator ==(GetFlagsRequestSize value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetFlagsRequestSize value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetFlagsRequestSize value) => value.Value;

    public static explicit operator GetFlagsRequestSize(string value) => new(value);

    internal class GetFlagsRequestSizeSerializer : JsonConverter<GetFlagsRequestSize>
    {
        public override GetFlagsRequestSize Read(
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
            return new GetFlagsRequestSize(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetFlagsRequestSize value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetFlagsRequestSize ReadAsPropertyName(
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
            return new GetFlagsRequestSize(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetFlagsRequestSize value,
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
        public const string SixteenPx = "16px";

        public const string TwentyFourPx = "24px";

        public const string ThirtyTwoPx = "32px";

        public const string FortyEightPx = "48px";

        public const string SixtyFourPx = "64px";
    }
}
