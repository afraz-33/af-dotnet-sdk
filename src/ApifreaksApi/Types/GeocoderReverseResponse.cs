using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeocoderReverseResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// WGS84 latitude value for the location.
    /// </summary>
    [JsonPropertyName("lat")]
    public required float Lat { get; set; }

    /// <summary>
    /// WGS84 longitude value for the location.
    /// </summary>
    [JsonPropertyName("lon")]
    public required float Lon { get; set; }

    /// <summary>
    /// Name for the primary place searched.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// High-level category of the place, e.g. amenity, place, natural, building, highway.
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>
    /// Specific kind within the category, e.g. fast_food, city, park, residential, house_number.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Array describing the POI (point of interest) and closely related elements at this location.
    /// </summary>
    [JsonPropertyName("poi")]
    public IEnumerable<GeocoderReverseResponsePoiItem>? Poi { get; set; }

    /// <summary>
    /// Street or road name.
    /// </summary>
    [JsonPropertyName("street")]
    public string? Street { get; set; }

    /// <summary>
    /// Intra-city area below city level, e.g. suburb, borough, quarter, ward, district, sector, zone, tehsil, taluka, neighbourhood.
    /// </summary>
    [JsonPropertyName("area")]
    public string? Area { get; set; }

    /// <summary>
    /// Postal code of the area.
    /// </summary>
    [JsonPropertyName("postcode")]
    public string? Postcode { get; set; }

    /// <summary>
    /// Settlement label appropriate to the country, e.g. city, town, municipality.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// Second-tier administrative area, e.g. county, district, shire, prefecture.
    /// </summary>
    [JsonPropertyName("county")]
    public string? County { get; set; }

    /// <summary>
    /// Subdivision code when available, typically ISO-3166-2 like US-TX or PK-PB.
    /// </summary>
    [JsonPropertyName("state_code")]
    public string? StateCode { get; set; }

    /// <summary>
    /// First-tier administrative area; varies by country, e.g. state, region, province, division, autonomous community.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// Two-letter country code in upper case, ISO-3166-1 alpha-2.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// Country name of the searched place.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; set; }

    /// <summary>
    /// Single-line, human-readable address of the location.
    /// </summary>
    [JsonPropertyName("full_address")]
    public required string FullAddress { get; set; }

    /// <summary>
    /// Extent of the feature as `[lat_min, lat_max, lon_min, lon_max]` (south, north, west, east) in WGS84 decimal degrees.
    /// </summary>
    [JsonPropertyName("bounding_box")]
    public IEnumerable<string> BoundingBox { get; set; } = new List<string>();

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
