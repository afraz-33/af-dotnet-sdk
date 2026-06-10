using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainDnsHistoryResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("totalRecords")]
    public int? TotalRecords { get; set; }

    [JsonPropertyName("totalPages")]
    public int? TotalPages { get; set; }

    [JsonPropertyName("currentPage")]
    public int? CurrentPage { get; set; }

    [JsonPropertyName("historicalDnsRecords")]
    public IEnumerable<DomainDnsHistoryResponseHistoricalDnsRecordsItem>? HistoricalDnsRecords { get; set; }

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
