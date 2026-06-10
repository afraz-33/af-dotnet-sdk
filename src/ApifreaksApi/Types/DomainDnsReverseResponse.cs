using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainDnsReverseResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("totalRecords")]
    public required int TotalRecords { get; set; }

    [JsonPropertyName("totalPages")]
    public required int TotalPages { get; set; }

    [JsonPropertyName("currentPage")]
    public required int CurrentPage { get; set; }

    [JsonPropertyName("reverseDnsRecords")]
    public IEnumerable<DomainDnsReverseResponseReverseDnsRecordsItem> ReverseDnsRecords { get; set; } =
        new List<DomainDnsReverseResponseReverseDnsRecordsItem>();

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
