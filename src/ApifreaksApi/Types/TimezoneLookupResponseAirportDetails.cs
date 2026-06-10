using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record TimezoneLookupResponseAirportDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("longitude")]
    public required string Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public required string Latitude { get; set; }

    [JsonPropertyName("elevation_ft")]
    public required double ElevationFt { get; set; }

    [JsonPropertyName("continent_code")]
    public required string ContinentCode { get; set; }

    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("state_code")]
    public required string StateCode { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("iata_code")]
    public required string IataCode { get; set; }

    [JsonPropertyName("icao_code")]
    public required string IcaoCode { get; set; }

    [JsonPropertyName("faa_code")]
    public required string FaaCode { get; set; }

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
