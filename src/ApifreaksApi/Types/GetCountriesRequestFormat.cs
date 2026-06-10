using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GetCountriesRequestFormat.GetCountriesRequestFormatSerializer))]
[Serializable]
public readonly record struct GetCountriesRequestFormat : IStringEnum
{
    public static readonly GetCountriesRequestFormat Json = new(Values.Json);

    public static readonly GetCountriesRequestFormat Xml = new(Values.Xml);

    public GetCountriesRequestFormat(string value)
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
    public static GetCountriesRequestFormat FromCustom(string value)
    {
        return new GetCountriesRequestFormat(value);
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

    public static bool operator ==(GetCountriesRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetCountriesRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetCountriesRequestFormat value) => value.Value;

    public static explicit operator GetCountriesRequestFormat(string value) => new(value);

    internal class GetCountriesRequestFormatSerializer : JsonConverter<GetCountriesRequestFormat>
    {
        public override GetCountriesRequestFormat Read(
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
            return new GetCountriesRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetCountriesRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetCountriesRequestFormat ReadAsPropertyName(
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
            return new GetCountriesRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetCountriesRequestFormat value,
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
