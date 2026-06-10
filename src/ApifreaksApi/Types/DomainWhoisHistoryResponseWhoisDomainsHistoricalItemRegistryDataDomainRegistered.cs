using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered.DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegisteredSerializer)
)]
[Serializable]
public readonly record struct DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered
    : IStringEnum
{
    public static readonly DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered Yes =
        new(Values.Yes);

    public static readonly DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered No =
        new(Values.No);

    public static readonly DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered Restricted =
        new(Values.Restricted);

    public DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered(
        string value
    )
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
    public static DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered FromCustom(
        string value
    )
    {
        return new DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered(
            value
        );
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
        DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered value
    ) => value.Value;

    public static explicit operator DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered(
        string value
    ) => new(value);

    internal class DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegisteredSerializer
        : JsonConverter<DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered>
    {
        public override DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered Read(
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
            return new DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered ReadAsPropertyName(
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
            return new DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainWhoisHistoryResponseWhoisDomainsHistoricalItemRegistryDataDomainRegistered value,
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
        public const string Yes = "yes";

        public const string No = "no";

        public const string Restricted = "restricted";
    }
}
