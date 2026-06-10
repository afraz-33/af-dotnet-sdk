using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(DomainDnsLookupRequestFormat.DomainDnsLookupRequestFormatSerializer))]
[Serializable]
public readonly record struct DomainDnsLookupRequestFormat : IStringEnum
{
    public static readonly DomainDnsLookupRequestFormat Json = new(Values.Json);

    public static readonly DomainDnsLookupRequestFormat Xml = new(Values.Xml);

    public DomainDnsLookupRequestFormat(string value)
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
    public static DomainDnsLookupRequestFormat FromCustom(string value)
    {
        return new DomainDnsLookupRequestFormat(value);
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

    public static bool operator ==(DomainDnsLookupRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DomainDnsLookupRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DomainDnsLookupRequestFormat value) => value.Value;

    public static explicit operator DomainDnsLookupRequestFormat(string value) => new(value);

    internal class DomainDnsLookupRequestFormatSerializer
        : JsonConverter<DomainDnsLookupRequestFormat>
    {
        public override DomainDnsLookupRequestFormat Read(
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
            return new DomainDnsLookupRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsLookupRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsLookupRequestFormat ReadAsPropertyName(
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
            return new DomainDnsLookupRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsLookupRequestFormat value,
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
