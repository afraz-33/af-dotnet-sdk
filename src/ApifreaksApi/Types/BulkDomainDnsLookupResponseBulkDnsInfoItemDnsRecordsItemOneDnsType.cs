using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType.BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsTypeSerializer)
)]
[Serializable]
public readonly record struct BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType
    : IStringEnum
{
    public static readonly BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType Cname =
        new(Values.Cname);

    public BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType(string value)
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
    public static BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType FromCustom(
        string value
    )
    {
        return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType(value);
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
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType value
    ) => value.Value;

    public static explicit operator BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType(
        string value
    ) => new(value);

    internal class BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsTypeSerializer
        : JsonConverter<BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType>
    {
        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType Read(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType ReadAsPropertyName(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOneDnsType value,
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
        public const string Cname = "CNAME";
    }
}
