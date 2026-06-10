using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType.BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsTypeSerializer)
)]
[Serializable]
public readonly record struct BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType
    : IStringEnum
{
    public static readonly BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType Soa =
        new(Values.Soa);

    public BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType(string value)
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
    public static BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType FromCustom(
        string value
    )
    {
        return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType(value);
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
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType value
    ) => value.Value;

    public static explicit operator BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType(
        string value
    ) => new(value);

    internal class BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsTypeSerializer
        : JsonConverter<BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType>
    {
        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType Read(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType ReadAsPropertyName(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdminDnsType value,
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
        public const string Soa = "SOA";
    }
}
