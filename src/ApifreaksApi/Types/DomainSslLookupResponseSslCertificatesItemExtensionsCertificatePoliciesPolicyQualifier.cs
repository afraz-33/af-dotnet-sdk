using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslLookupResponseSslCertificatesItemExtensionsCertificatePoliciesPolicyQualifier
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("oid")]
    public string? Oid { get; set; }

    [JsonPropertyName("cpsUri")]
    public string? CpsUri { get; set; }

    [JsonPropertyName("userNotice")]
    public DomainSslLookupResponseSslCertificatesItemExtensionsCertificatePoliciesPolicyQualifierUserNotice? UserNotice { get; set; }

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
