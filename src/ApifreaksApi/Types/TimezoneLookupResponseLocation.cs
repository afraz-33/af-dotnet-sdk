using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record TimezoneLookupResponseLocation : IJsonOnDeserialized, IJsonOnSerializing
{
    [JsonExtensionData]
    private readonly IDictionary<string, object?> _extensionData =
        new Dictionary<string, object?>();

    [JsonPropertyName("location_string")]
    public string? LocationString { get; set; }

    [JsonPropertyName("country_name")]
    public string? CountryName { get; set; }

    [JsonPropertyName("state_prov")]
    public string? StateProv { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    [JsonPropertyName("latitude")]
    public string? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public string? Longitude { get; set; }

    [JsonPropertyName("continent_code")]
    public string? ContinentCode { get; set; }

    [JsonPropertyName("continent_name")]
    public string? ContinentName { get; set; }

    [JsonPropertyName("country_code2")]
    public string? CountryCode2 { get; set; }

    [JsonPropertyName("country_code3")]
    public string? CountryCode3 { get; set; }

    [JsonPropertyName("country_name_official")]
    public string? CountryNameOfficial { get; set; }

    [JsonPropertyName("is_eu")]
    public bool? IsEu { get; set; }

    [JsonPropertyName("state_code")]
    public string? StateCode { get; set; }

    [JsonPropertyName("district")]
    public string? District { get; set; }

    [JsonPropertyName("zipcode")]
    public string? Zipcode { get; set; }

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
