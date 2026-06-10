using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AsnWhoisLookupResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asNumber")]
    public required string AsNumber { get; set; }

    [JsonPropertyName("asName")]
    public required string AsName { get; set; }

    [JsonPropertyName("orgName")]
    public required string OrgName { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("orgHandle")]
    public required string OrgHandle { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("allocationStatus")]
    public required string AllocationStatus { get; set; }

    [JsonPropertyName("numOfIPv4Routes")]
    public required string NumOfIPv4Routes { get; set; }

    [JsonPropertyName("numOfIPv6Routes")]
    public required string NumOfIPv6Routes { get; set; }

    [JsonPropertyName("whoisHost")]
    public required string WhoisHost { get; set; }

    [JsonPropertyName("dateAllocated")]
    public DateOnly? DateAllocated { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("routeObjects")]
    public IEnumerable<AsnWhoisLookupResponseRouteObjectsItem> RouteObjects { get; set; } =
        new List<AsnWhoisLookupResponseRouteObjectsItem>();

    [JsonPropertyName("whoisResponse")]
    public required string WhoisResponse { get; set; }

    [JsonPropertyName("downstreams")]
    public IEnumerable<AsnWhoisLookupResponseDownstreamsItem> Downstreams { get; set; } =
        new List<AsnWhoisLookupResponseDownstreamsItem>();

    [JsonPropertyName("parsedWhoisResponse")]
    public required AsnWhoisLookupResponseParsedWhoisResponse ParsedWhoisResponse { get; set; }

    [JsonPropertyName("upstreams")]
    public IEnumerable<AsnWhoisLookupResponseUpstreamsItem> Upstreams { get; set; } =
        new List<AsnWhoisLookupResponseUpstreamsItem>();

    [JsonPropertyName("peers")]
    public IEnumerable<AsnWhoisLookupResponsePeersItem> Peers { get; set; } =
        new List<AsnWhoisLookupResponsePeersItem>();

    [JsonPropertyName("contacts")]
    public required AsnWhoisLookupResponseContacts Contacts { get; set; }

    [JsonPropertyName("legacyRoutes")]
    public IEnumerable<string> LegacyRoutes { get; set; } = new List<string>();

    [JsonPropertyName("whois_raw_response")]
    public string? WhoisRawResponse { get; set; }

    [JsonPropertyName("r_whois_raw_response")]
    public string? RWhoisRawResponse { get; set; }

    [JsonPropertyName("query_time")]
    public string? QueryTime { get; set; }

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
