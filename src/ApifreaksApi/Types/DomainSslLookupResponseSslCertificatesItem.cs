using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslLookupResponseSslCertificatesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("chainOrder")]
    public required string ChainOrder { get; set; }

    [JsonPropertyName("authenticationType")]
    public required string AuthenticationType { get; set; }

    [JsonPropertyName("validityStartDate")]
    public required string ValidityStartDate { get; set; }

    [JsonPropertyName("validityEndDate")]
    public required string ValidityEndDate { get; set; }

    [JsonPropertyName("serialNumber")]
    public required string SerialNumber { get; set; }

    [JsonPropertyName("signatureAlgorithm")]
    public required string SignatureAlgorithm { get; set; }

    [JsonPropertyName("subject")]
    public required DomainSslLookupResponseSslCertificatesItemSubject Subject { get; set; }

    [JsonPropertyName("issuer")]
    public required DomainSslLookupResponseSslCertificatesItemIssuer Issuer { get; set; }

    [JsonPropertyName("publicKey")]
    public required DomainSslLookupResponseSslCertificatesItemPublicKey PublicKey { get; set; }

    [JsonPropertyName("extensions")]
    public required DomainSslLookupResponseSslCertificatesItemExtensions Extensions { get; set; }

    /// <summary>
    /// Raw certificate in PEM format
    /// </summary>
    [JsonPropertyName("pemRaw")]
    public string? PemRaw { get; set; }

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
