using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered.BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegisteredSerializer)
)]
[Serializable]
public readonly record struct BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered
    : IStringEnum
{
    public static readonly BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered Yes =
        new(Values.Yes);

    public static readonly BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered No =
        new(Values.No);

    public static readonly BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered Restricted =
        new(Values.Restricted);

    public BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered(string value)
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
    public static BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered FromCustom(
        string value
    )
    {
        return new BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered(value);
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
        BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered value
    ) => value.Value;

    public static explicit operator BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered(
        string value
    ) => new(value);

    internal class BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegisteredSerializer
        : JsonConverter<BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered>
    {
        public override BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered Read(
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
            return new BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered ReadAsPropertyName(
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
            return new BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainWhoisLookupResponseBulkWhoisResponseItemDomainRegistered value,
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
