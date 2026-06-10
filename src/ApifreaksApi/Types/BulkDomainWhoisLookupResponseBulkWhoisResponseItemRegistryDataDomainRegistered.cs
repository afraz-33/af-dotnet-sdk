using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered.BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegisteredSerializer)
)]
[Serializable]
public readonly record struct BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered
    : IStringEnum
{
    public static readonly BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered Yes =
        new(Values.Yes);

    public static readonly BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered No =
        new(Values.No);

    public static readonly BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered Restricted =
        new(Values.Restricted);

    public BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered(
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
    public static BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered FromCustom(
        string value
    )
    {
        return new BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered(
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
        BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered value
    ) => value.Value;

    public static explicit operator BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered(
        string value
    ) => new(value);

    internal class BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegisteredSerializer
        : JsonConverter<BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered>
    {
        public override BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered Read(
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
            return new BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered ReadAsPropertyName(
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
            return new BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainWhoisLookupResponseBulkWhoisResponseItemRegistryDataDomainRegistered value,
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
