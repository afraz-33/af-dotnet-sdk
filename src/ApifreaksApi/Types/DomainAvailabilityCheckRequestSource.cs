using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainAvailabilityCheckRequestSource.DomainAvailabilityCheckRequestSourceSerializer)
)]
[Serializable]
public readonly record struct DomainAvailabilityCheckRequestSource : IStringEnum
{
    public static readonly DomainAvailabilityCheckRequestSource Dns = new(Values.Dns);

    public static readonly DomainAvailabilityCheckRequestSource Whois = new(Values.Whois);

    public DomainAvailabilityCheckRequestSource(string value)
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
    public static DomainAvailabilityCheckRequestSource FromCustom(string value)
    {
        return new DomainAvailabilityCheckRequestSource(value);
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

    public static bool operator ==(DomainAvailabilityCheckRequestSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DomainAvailabilityCheckRequestSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DomainAvailabilityCheckRequestSource value) =>
        value.Value;

    public static explicit operator DomainAvailabilityCheckRequestSource(string value) =>
        new(value);

    internal class DomainAvailabilityCheckRequestSourceSerializer
        : JsonConverter<DomainAvailabilityCheckRequestSource>
    {
        public override DomainAvailabilityCheckRequestSource Read(
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
            return new DomainAvailabilityCheckRequestSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainAvailabilityCheckRequestSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainAvailabilityCheckRequestSource ReadAsPropertyName(
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
            return new DomainAvailabilityCheckRequestSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainAvailabilityCheckRequestSource value,
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
        public const string Dns = "dns";

        public const string Whois = "whois";
    }
}
