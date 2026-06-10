using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupResponseItemNetworkAsn : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The AS number
    /// </summary>
    [JsonPropertyName("as_number")]
    public string? AsNumber { get; set; }

    /// <summary>
    /// The organization name
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// The country code
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// The ASN name
    /// </summary>
    [JsonPropertyName("asn_name")]
    public string? AsnName { get; set; }

    /// <summary>
    /// The type of the ASN
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The domain associated with the ASN
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// The date when the ASN was allocated
    /// </summary>
    [JsonPropertyName("date_allocated")]
    public string? DateAllocated { get; set; }

    /// <summary>
    /// The allocation status of the ASN
    /// </summary>
    [JsonPropertyName("allocation_status")]
    public string? AllocationStatus { get; set; }

    /// <summary>
    /// The number of IPv4 routes associated with the ASN
    /// </summary>
    [JsonPropertyName("num_of_ipv4_routes")]
    public string? NumOfIpv4Routes { get; set; }

    /// <summary>
    /// The number of IPv6 routes associated with the ASN
    /// </summary>
    [JsonPropertyName("num_of_ipv6_routes")]
    public string? NumOfIpv6Routes { get; set; }

    /// <summary>
    /// The Regional Internet Registry (RIR) of the ASN
    /// </summary>
    [JsonPropertyName("rir")]
    public string? Rir { get; set; }

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
