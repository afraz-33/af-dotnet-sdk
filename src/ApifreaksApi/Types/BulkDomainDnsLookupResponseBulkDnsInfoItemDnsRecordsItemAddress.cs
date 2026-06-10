using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAddress : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public required int Type { get; set; }

    [JsonPropertyName("dnsType")]
    public required BulkDomainDnsLookupResponseBulkDnsInfoItemDnsRecordsItemAddressDnsType DnsType { get; set; }

    [JsonPropertyName("ttl")]
    public required int Ttl { get; set; }

    [JsonPropertyName("rawText")]
    public required string RawText { get; set; }

    [JsonPropertyName("rRsetType")]
    public required int RRsetType { get; set; }

    /// <summary>
    /// IPv4 or IPv6 address
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

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
