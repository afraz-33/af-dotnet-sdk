using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslLookupResponseSslCertificatesItemIssuer : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("commonName")]
    public required string CommonName { get; set; }

    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("incCountry")]
    public string? IncCountry { get; set; }

    [JsonPropertyName("incState")]
    public string? IncState { get; set; }

    [JsonPropertyName("businessCategory")]
    public string? BusinessCategory { get; set; }

    [JsonPropertyName("street")]
    public string? Street { get; set; }

    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

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
