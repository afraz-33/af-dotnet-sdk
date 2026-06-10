using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered.DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegisteredSerializer)
)]
[Serializable]
public readonly record struct DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered
    : IStringEnum
{
    public static readonly DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered Yes =
        new(Values.Yes);

    public static readonly DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered No =
        new(Values.No);

    public static readonly DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered Restricted =
        new(Values.Restricted);

    public DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered(
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
    public static DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered FromCustom(
        string value
    )
    {
        return new DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered(
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
        DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered value
    ) => value.Value;

    public static explicit operator DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered(
        string value
    ) => new(value);

    internal class DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegisteredSerializer
        : JsonConverter<DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered>
    {
        public override DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered Read(
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
            return new DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered ReadAsPropertyName(
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
            return new DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContactDomainRegistered value,
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
