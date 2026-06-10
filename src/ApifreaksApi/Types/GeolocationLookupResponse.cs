using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeolocationLookupResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The IP address
    /// </summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>
    /// The hostname (if available)
    /// </summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("location")]
    public GeolocationLookupResponseLocation? Location { get; set; }

    [JsonPropertyName("country_metadata")]
    public GeolocationLookupResponseCountryMetadata? CountryMetadata { get; set; }

    [JsonPropertyName("network")]
    public GeolocationLookupResponseNetwork? Network { get; set; }

    [JsonPropertyName("currency")]
    public GeolocationLookupResponseCurrency? Currency { get; set; }

    [JsonPropertyName("security")]
    public GeolocationLookupResponseSecurity? Security { get; set; }

    [JsonPropertyName("abuse")]
    public IEnumerable<GeolocationLookupResponseAbuseItem>? Abuse { get; set; }

    [JsonPropertyName("time_zone")]
    public GeolocationLookupResponseTimeZone? TimeZone { get; set; }

    [JsonPropertyName("user_agent")]
    public GeolocationLookupResponseUserAgent? UserAgent { get; set; }

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
