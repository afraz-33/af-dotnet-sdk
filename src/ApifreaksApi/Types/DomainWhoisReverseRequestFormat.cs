using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(DomainWhoisReverseRequestFormat.DomainWhoisReverseRequestFormatSerializer))]
[Serializable]
public readonly record struct DomainWhoisReverseRequestFormat : IStringEnum
{
    public static readonly DomainWhoisReverseRequestFormat Json = new(Values.Json);

    public static readonly DomainWhoisReverseRequestFormat Xml = new(Values.Xml);

    public DomainWhoisReverseRequestFormat(string value)
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
    public static DomainWhoisReverseRequestFormat FromCustom(string value)
    {
        return new DomainWhoisReverseRequestFormat(value);
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

    public static bool operator ==(DomainWhoisReverseRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DomainWhoisReverseRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DomainWhoisReverseRequestFormat value) => value.Value;

    public static explicit operator DomainWhoisReverseRequestFormat(string value) => new(value);

    internal class DomainWhoisReverseRequestFormatSerializer
        : JsonConverter<DomainWhoisReverseRequestFormat>
    {
        public override DomainWhoisReverseRequestFormat Read(
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
            return new DomainWhoisReverseRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainWhoisReverseRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainWhoisReverseRequestFormat ReadAsPropertyName(
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
            return new DomainWhoisReverseRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainWhoisReverseRequestFormat value,
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
