using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GetFlagsRequestType.GetFlagsRequestTypeSerializer))]
[Serializable]
public readonly record struct GetFlagsRequestType : IStringEnum
{
    public static readonly GetFlagsRequestType Country = new(Values.Country);

    public static readonly GetFlagsRequestType Organization = new(Values.Organization);

    public GetFlagsRequestType(string value)
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
    public static GetFlagsRequestType FromCustom(string value)
    {
        return new GetFlagsRequestType(value);
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

    public static bool operator ==(GetFlagsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetFlagsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetFlagsRequestType value) => value.Value;

    public static explicit operator GetFlagsRequestType(string value) => new(value);

    internal class GetFlagsRequestTypeSerializer : JsonConverter<GetFlagsRequestType>
    {
        public override GetFlagsRequestType Read(
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
            return new GetFlagsRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetFlagsRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetFlagsRequestType ReadAsPropertyName(
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
            return new GetFlagsRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetFlagsRequestType value,
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
        public const string Country = "country";

        public const string Organization = "organization";
    }
}
