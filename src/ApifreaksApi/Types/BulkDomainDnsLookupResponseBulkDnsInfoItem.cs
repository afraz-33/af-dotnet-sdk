using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace ApifreaksApi;

[Serializable]
public record BulkDomainDnsLookupResponseBulkDnsInfoItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Indicates whether the query was processed successfully.
    /// </summary>
    [JsonPropertyName("status")]
    public required bool Status { get; set; }

    /// <summary>
    /// Time at which the query was made (Format:YYYY-MM-DD HH:mm:ss).
    /// </summary>
    [JsonPropertyName("queryTime")]
    public required DateTime QueryTime { get; set; }

    /// <summary>
    /// Queried domain.
    /// </summary>
    [JsonPropertyName("domainName")]
    public required string DomainName { get; set; }

    /// <summary>
    /// Indicates whether the domain is registered.
    /// </summary>
    [JsonPropertyName("domainRegistered")]
    public required bool DomainRegistered { get; set; }

    [JsonPropertyName("dnsTypes")]
    public required BulkDomainDnsLookupResponseBulkDnsInfoItemDnsTypes DnsTypes { get; set; }

    /// <summary>
    /// List of DNS records, each based on its type.
    /// </summary>
    [JsonPropertyName("dnsRecords")]
    public IEnumerable<
        OneOf<
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAddress,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOne,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriority,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemSingleName,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdmin,
            BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStrings
        >
    > DnsRecords { get; set; } =
        new List<
            OneOf<
                BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAddress,
                BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemOne,
                BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemPriority,
                BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemSingleName,
                BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAdmin,
                BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemStrings
            >
        >();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
