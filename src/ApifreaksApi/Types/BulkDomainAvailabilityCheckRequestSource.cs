using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainAvailabilityCheckRequestSource.BulkDomainAvailabilityCheckRequestSourceSerializer)
)]
[Serializable]
public readonly record struct BulkDomainAvailabilityCheckRequestSource : IStringEnum
{
    public static readonly BulkDomainAvailabilityCheckRequestSource Dns = new(Values.Dns);

    public static readonly BulkDomainAvailabilityCheckRequestSource Whois = new(Values.Whois);

    public BulkDomainAvailabilityCheckRequestSource(string value)
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
    public static BulkDomainAvailabilityCheckRequestSource FromCustom(string value)
    {
        return new BulkDomainAvailabilityCheckRequestSource(value);
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
        BulkDomainAvailabilityCheckRequestSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainAvailabilityCheckRequestSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(BulkDomainAvailabilityCheckRequestSource value) =>
        value.Value;

    public static explicit operator BulkDomainAvailabilityCheckRequestSource(string value) =>
        new(value);

    internal class BulkDomainAvailabilityCheckRequestSourceSerializer
        : JsonConverter<BulkDomainAvailabilityCheckRequestSource>
    {
        public override BulkDomainAvailabilityCheckRequestSource Read(
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
            return new BulkDomainAvailabilityCheckRequestSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainAvailabilityCheckRequestSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainAvailabilityCheckRequestSource ReadAsPropertyName(
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
            return new BulkDomainAvailabilityCheckRequestSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainAvailabilityCheckRequestSource value,
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
