using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeolocationLookupResponseLocation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("continent_code")]
    public string? ContinentCode { get; set; }

    [JsonPropertyName("continent_name")]
    public string? ContinentName { get; set; }

    [JsonPropertyName("country_code2")]
    public string? CountryCode2 { get; set; }

    [JsonPropertyName("country_code3")]
    public string? CountryCode3 { get; set; }

    [JsonPropertyName("country_name")]
    public string? CountryName { get; set; }

    [JsonPropertyName("country_name_official")]
    public string? CountryNameOfficial { get; set; }

    [JsonPropertyName("country_capital")]
    public string? CountryCapital { get; set; }

    [JsonPropertyName("state_prov")]
    public string? StateProv { get; set; }

    [JsonPropertyName("state_code")]
    public string? StateCode { get; set; }

    [JsonPropertyName("district")]
    public string? District { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    [JsonPropertyName("accuracy_radius")]
    public string? AccuracyRadius { get; set; }

    [JsonPropertyName("confidence")]
    public string? Confidence { get; set; }

    [JsonPropertyName("dma_code")]
    public string? DmaCode { get; set; }

    [JsonPropertyName("zipcode")]
    public string? Zipcode { get; set; }

    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [JsonPropertyName("is_eu")]
    public bool? IsEu { get; set; }

    [JsonPropertyName("country_flag")]
    public string? CountryFlag { get; set; }

    [JsonPropertyName("geoname_id")]
    public string? GeonameId { get; set; }

    [JsonPropertyName("country_emoji")]
    public string? CountryEmoji { get; set; }

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
