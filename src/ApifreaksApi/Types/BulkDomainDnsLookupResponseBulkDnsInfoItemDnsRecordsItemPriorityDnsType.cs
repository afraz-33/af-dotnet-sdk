using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType.BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsTypeSerializer)
)]
[Serializable]
public readonly record struct BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType
    : IStringEnum
{
    public static readonly BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType Mx =
        new(Values.Mx);

    public BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType(string value)
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
    public static BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType FromCustom(
        string value
    )
    {
        return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType(value);
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
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType value
    ) => value.Value;

    public static explicit operator BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType(
        string value
    ) => new(value);

    internal class BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsTypeSerializer
        : JsonConverter<BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType>
    {
        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType Read(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType ReadAsPropertyName(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriorityDnsType value,
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
        public const string Mx = "MX";
    }
}
