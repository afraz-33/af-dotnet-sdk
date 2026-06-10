using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GetCitiesRequestFormat.GetCitiesRequestFormatSerializer))]
[Serializable]
public readonly record struct GetCitiesRequestFormat : IStringEnum
{
    public static readonly GetCitiesRequestFormat Json = new(Values.Json);

    public static readonly GetCitiesRequestFormat Xml = new(Values.Xml);

    public GetCitiesRequestFormat(string value)
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
    public static GetCitiesRequestFormat FromCustom(string value)
    {
        return new GetCitiesRequestFormat(value);
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

    public static bool operator ==(GetCitiesRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetCitiesRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetCitiesRequestFormat value) => value.Value;

    public static explicit operator GetCitiesRequestFormat(string value) => new(value);

    internal class GetCitiesRequestFormatSerializer : JsonConverter<GetCitiesRequestFormat>
    {
        public override GetCitiesRequestFormat Read(
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
            return new GetCitiesRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCitiesRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCitiesRequestFormat ReadAsPropertyName(
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
            return new GetCitiesRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCitiesRequestFormat value,
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
