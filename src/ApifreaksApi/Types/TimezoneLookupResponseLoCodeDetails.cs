using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record TimezoneLookupResponseLoCodeDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("lo_code")]
    public required string LoCode { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("longitude")]
    public required string Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public required string Latitude { get; set; }

    [JsonPropertyName("state_code")]
    public required string StateCode { get; set; }

    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("country_name")]
    public required string CountryName { get; set; }

    [JsonPropertyName("location_type")]
    public required string LocationType { get; set; }

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
