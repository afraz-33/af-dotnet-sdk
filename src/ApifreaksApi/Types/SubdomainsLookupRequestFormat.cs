using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(SubdomainsLookupRequestFormat.SubdomainsLookupRequestFormatSerializer))]
[Serializable]
public readonly record struct SubdomainsLookupRequestFormat : IStringEnum
{
    public static readonly SubdomainsLookupRequestFormat Json = new(Values.Json);

    public static readonly SubdomainsLookupRequestFormat Xml = new(Values.Xml);

    public SubdomainsLookupRequestFormat(string value)
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
    public static SubdomainsLookupRequestFormat FromCustom(string value)
    {
        return new SubdomainsLookupRequestFormat(value);
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

    public static bool operator ==(SubdomainsLookupRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SubdomainsLookupRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SubdomainsLookupRequestFormat value) => value.Value;

    public static explicit operator SubdomainsLookupRequestFormat(string value) => new(value);

    internal class SubdomainsLookupRequestFormatSerializer
        : JsonConverter<SubdomainsLookupRequestFormat>
    {
        public override SubdomainsLookupRequestFormat Read(
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
            return new SubdomainsLookupRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SubdomainsLookupRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SubdomainsLookupRequestFormat ReadAsPropertyName(
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
            return new SubdomainsLookupRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SubdomainsLookupRequestFormat value,
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
