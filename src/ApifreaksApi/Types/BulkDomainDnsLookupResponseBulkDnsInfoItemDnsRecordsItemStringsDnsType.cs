using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType.BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsTypeSerializer)
)]
[Serializable]
public readonly record struct BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType
    : IStringEnum
{
    public static readonly BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType Txt =
        new(Values.Txt);

    public static readonly BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType Spf =
        new(Values.Spf);

    public BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType(string value)
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
    public static BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType FromCustom(
        string value
    )
    {
        return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType(value);
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
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType value
    ) => value.Value;

    public static explicit operator BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType(
        string value
    ) => new(value);

    internal class BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsTypeSerializer
        : JsonConverter<BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType>
    {
        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType Read(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType ReadAsPropertyName(
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
            return new BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStringsDnsType value,
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
        public const string Txt = "TXT";

        public const string Spf = "SPF";
    }
}
