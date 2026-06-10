using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered.DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegisteredSerializer)
)]
[Serializable]
public readonly record struct DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered
    : IStringEnum
{
    public static readonly DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered Yes =
        new(Values.Yes);

    public static readonly DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered No =
        new(Values.No);

    public static readonly DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered Restricted =
        new(Values.Restricted);

    public DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered(string value)
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
    public static DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered FromCustom(
        string value
    )
    {
        return new DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered(value);
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
        DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered value
    ) => value.Value;

    public static explicit operator DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered(
        string value
    ) => new(value);

    internal class DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegisteredSerializer
        : JsonConverter<DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered>
    {
        public override DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered Read(
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
            return new DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered ReadAsPropertyName(
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
            return new DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainWhoisHistoryResponseWhoisDomainsHistoricalItemDomainRegistered value,
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
