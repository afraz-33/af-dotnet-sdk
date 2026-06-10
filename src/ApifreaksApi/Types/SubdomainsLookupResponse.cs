using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record SubdomainsLookupResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

    [JsonPropertyName("status")]
    public required bool Status { get; set; }

    [JsonPropertyName("query_time")]
    public required string QueryTime { get; set; }

    [JsonPropertyName("current_page")]
    public required int CurrentPage { get; set; }

    [JsonPropertyName("total_pages")]
    public required int TotalPages { get; set; }

    [JsonPropertyName("total_records")]
    public required int TotalRecords { get; set; }

    [JsonPropertyName("subdomains")]
    public IEnumerable<SubdomainsLookupResponseSubdomainsItem> Subdomains { get; set; } =
        new List<SubdomainsLookupResponseSubdomainsItem>();

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
