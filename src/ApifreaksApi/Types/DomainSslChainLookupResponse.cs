using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslChainLookupResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("domainName")]
    public required string DomainName { get; set; }

    [JsonPropertyName("queryTime")]
    public required DateTime QueryTime { get; set; }

    [JsonPropertyName("sslCertificates")]
    public IEnumerable<DomainSslChainLookupResponseSslCertificatesItem> SslCertificates { get; set; } =
        new List<DomainSslChainLookupResponseSslCertificatesItem>();

    [JsonPropertyName("sslRaw")]
    public string? SslRaw { get; set; }

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
