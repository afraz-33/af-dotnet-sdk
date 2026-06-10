using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainWhoisHistoryResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Determines whether the request was successfully processed or not.
    /// </summary>
    [JsonPropertyName("status")]
    public required bool Status { get; set; }

    /// <summary>
    /// Indicates that this response contains historical data.
    /// </summary>
    [JsonPropertyName("whois")]
    public required DomainWhoisHistoryResponseWhois Whois { get; set; }

    /// <summary>
    /// Shows the total number of records found for the queried domain.
    /// </summary>
    [JsonPropertyName("total_records")]
    public required string TotalRecords { get; set; }

    [JsonPropertyName("whois_domains_historical")]
    public IEnumerable<DomainWhoisHistoryResponseWhoisDomainsHistoricalItem> WhoisDomainsHistorical { get; set; } =
        new List<DomainWhoisHistoryResponseWhoisDomainsHistoricalItem>();

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
