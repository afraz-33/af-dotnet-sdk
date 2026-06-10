using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupResponseItemNetwork : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("asn")]
    public BulkGeolocationLookupResponseItemNetworkAsn? Asn { get; set; }

    /// <summary>
    /// The type of the connection
    /// </summary>
    [JsonPropertyName("connection_type")]
    public string? ConnectionType { get; set; }

    [JsonPropertyName("company")]
    public BulkGeolocationLookupResponseItemNetworkCompany? Company { get; set; }

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
