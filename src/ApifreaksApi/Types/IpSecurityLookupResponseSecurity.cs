using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record IpSecurityLookupResponseSecurity : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("threat_score")]
    public double? ThreatScore { get; set; }

    [JsonPropertyName("is_tor")]
    public bool? IsTor { get; set; }

    [JsonPropertyName("is_proxy")]
    public bool? IsProxy { get; set; }

    [JsonPropertyName("proxy_provider_names")]
    public IEnumerable<string>? ProxyProviderNames { get; set; }

    [JsonPropertyName("proxy_confidence_score")]
    public double? ProxyConfidenceScore { get; set; }

    [JsonPropertyName("proxy_last_seen")]
    public string? ProxyLastSeen { get; set; }

    [JsonPropertyName("is_residential_proxy")]
    public bool? IsResidentialProxy { get; set; }

    [JsonPropertyName("is_vpn")]
    public bool? IsVpn { get; set; }

    [JsonPropertyName("vpn_provider_names")]
    public IEnumerable<string>? VpnProviderNames { get; set; }

    [JsonPropertyName("vpn_confidence_score")]
    public double? VpnConfidenceScore { get; set; }

    [JsonPropertyName("vpn_last_seen")]
    public string? VpnLastSeen { get; set; }

    [JsonPropertyName("is_relay")]
    public bool? IsRelay { get; set; }

    [JsonPropertyName("relay_provider_name")]
    public string? RelayProviderName { get; set; }

    [JsonPropertyName("is_anonymous")]
    public bool? IsAnonymous { get; set; }

    [JsonPropertyName("is_known_attacker")]
    public bool? IsKnownAttacker { get; set; }

    [JsonPropertyName("is_bot")]
    public bool? IsBot { get; set; }

    [JsonPropertyName("is_spam")]
    public bool? IsSpam { get; set; }

    [JsonPropertyName("is_cloud_provider")]
    public bool? IsCloudProvider { get; set; }

    [JsonPropertyName("cloud_provider_name")]
    public string? CloudProviderName { get; set; }

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
