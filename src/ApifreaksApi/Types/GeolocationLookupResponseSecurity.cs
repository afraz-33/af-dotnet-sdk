using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeolocationLookupResponseSecurity : IJsonOnDeserialized
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

    [JsonPropertyName("proxy_type")]
    public string? ProxyType { get; set; }

    [JsonPropertyName("proxy_provider")]
    public string? ProxyProvider { get; set; }

    [JsonPropertyName("is_anonymous")]
    public bool? IsAnonymous { get; set; }

    [JsonPropertyName("is_known_attacker")]
    public bool? IsKnownAttacker { get; set; }

    [JsonPropertyName("is_spam")]
    public bool? IsSpam { get; set; }

    [JsonPropertyName("is_bot")]
    public bool? IsBot { get; set; }

    [JsonPropertyName("is_cloud_provider")]
    public bool? IsCloudProvider { get; set; }

    [JsonPropertyName("cloud_provider")]
    public string? CloudProvider { get; set; }

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
