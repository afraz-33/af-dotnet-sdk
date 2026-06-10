using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainAvailabilityCheckRequestFormat.DomainAvailabilityCheckRequestFormatSerializer)
)]
[Serializable]
public readonly record struct DomainAvailabilityCheckRequestFormat : IStringEnum
{
    public static readonly DomainAvailabilityCheckRequestFormat Json = new(Values.Json);

    public static readonly DomainAvailabilityCheckRequestFormat Xml = new(Values.Xml);

    public DomainAvailabilityCheckRequestFormat(string value)
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
    public static DomainAvailabilityCheckRequestFormat FromCustom(string value)
    {
        return new DomainAvailabilityCheckRequestFormat(value);
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

    public static bool operator ==(DomainAvailabilityCheckRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DomainAvailabilityCheckRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DomainAvailabilityCheckRequestFormat value) =>
        value.Value;

    public static explicit operator DomainAvailabilityCheckRequestFormat(string value) =>
        new(value);

    internal class DomainAvailabilityCheckRequestFormatSerializer
        : JsonConverter<DomainAvailabilityCheckRequestFormat>
    {
        public override DomainAvailabilityCheckRequestFormat Read(
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
            return new DomainAvailabilityCheckRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainAvailabilityCheckRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainAvailabilityCheckRequestFormat ReadAsPropertyName(
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
            return new DomainAvailabilityCheckRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainAvailabilityCheckRequestFormat value,
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
