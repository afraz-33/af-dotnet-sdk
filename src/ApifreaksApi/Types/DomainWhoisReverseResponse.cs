using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace ApifreaksApi;

[Serializable]
public record DomainWhoisReverseResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("totalResult")]
    public int? TotalResult { get; set; }

    [JsonPropertyName("totalPages")]
    public int? TotalPages { get; set; }

    [JsonPropertyName("currentPage")]
    public int? CurrentPage { get; set; }

    [JsonPropertyName("whois_domains_historical")]
    public IEnumerable<
        OneOf<
            DomainWhoisReverseResponseWhoisDomainsHistoricalItemAdministrativeContact,
            DomainWhoisReverseResponseWhoisDomainsHistoricalItemCompanyname
        >
    >? WhoisDomainsHistorical { get; set; }

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
