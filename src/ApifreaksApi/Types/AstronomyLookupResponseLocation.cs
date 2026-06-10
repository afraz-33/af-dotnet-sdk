using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AstronomyLookupResponseLocation : IJsonOnDeserialized, IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    /// <summary>
    /// The complete geographical location (returned when looking up by the location parameter).
    /// </summary>
    [JsonPropertyName("location_string")]
    public string? LocationString { get; set; }

    [JsonPropertyName("continent_code")]
    public string? ContinentCode { get; set; }

    [JsonPropertyName("continent_name")]
    public string? ContinentName { get; set; }

    [JsonPropertyName("country_code2")]
    public string? CountryCode2 { get; set; }

    [JsonPropertyName("country_code3")]
    public string? CountryCode3 { get; set; }

    [JsonPropertyName("country_name")]
    public required string CountryName { get; set; }

    [JsonPropertyName("country_name_official")]
    public string? CountryNameOfficial { get; set; }

    [JsonPropertyName("is_eu")]
    public bool? IsEu { get; set; }

    [JsonPropertyName("state_prov")]
    public required string StateProv { get; set; }

    [JsonPropertyName("state_code")]
    public string? StateCode { get; set; }

    [JsonPropertyName("district")]
    public string? District { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("zipcode")]
    public string? Zipcode { get; set; }

    [JsonPropertyName("latitude")]
    public required string Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public required string Longitude { get; set; }

    [JsonPropertyName("locality")]
    public required string Locality { get; set; }

    [JsonPropertyName("elevation")]
    public required string Elevation { get; set; }

    [JsonIgnore]
    public AdditionalProperties AdditionalProperties { get; set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    void IJsonOnSerializing.OnSerializing() =>
        AdditionalProperties.CopyToExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
