using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslLookupResponseSslCertificatesItemExtensions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("authorityKeyIdentifier")]
    public required string AuthorityKeyIdentifier { get; set; }

    [JsonPropertyName("subjectKeyIdentifier")]
    public required string SubjectKeyIdentifier { get; set; }

    [JsonPropertyName("keyUsages")]
    public IEnumerable<string> KeyUsages { get; set; } = new List<string>();

    [JsonPropertyName("extendedKeyUsages")]
    public IEnumerable<string> ExtendedKeyUsages { get; set; } = new List<string>();

    [JsonPropertyName("crlDistributionPoints")]
    public IEnumerable<string>? CrlDistributionPoints { get; set; }

    [JsonPropertyName("authorityInfoAccess")]
    public required DomainSslLookupResponseSslCertificatesItemExtensionsAuthorityInfoAccess AuthorityInfoAccess { get; set; }

    [JsonPropertyName("subjectAlternativeNames")]
    public DomainSslLookupResponseSslCertificatesItemExtensionsSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    [JsonPropertyName("certificatePolicies")]
    public required DomainSslLookupResponseSslCertificatesItemExtensionsCertificatePolicies CertificatePolicies { get; set; }

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
