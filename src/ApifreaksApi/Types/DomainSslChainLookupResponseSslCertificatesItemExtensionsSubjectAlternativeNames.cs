using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslChainLookupResponseSslCertificatesItemExtensionsSubjectAlternativeNames
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("dnsNames")]
    public IEnumerable<string>? DnsNames { get; set; }

    [JsonPropertyName("emailAddresses")]
    public IEnumerable<string>? EmailAddresses { get; set; }

    [JsonPropertyName("ipAddresses")]
    public IEnumerable<string>? IpAddresses { get; set; }

    [JsonPropertyName("uris")]
    public IEnumerable<string>? Uris { get; set; }

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
