using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupResponseItem : IJsonOnDeserialized
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
    public BulkGeolocationLookupResponseItemLocation? Location { get; set; }

    [JsonPropertyName("country_metadata")]
    public BulkGeolocationLookupResponseItemCountryMetadata? CountryMetadata { get; set; }

    [JsonPropertyName("network")]
    public BulkGeolocationLookupResponseItemNetwork? Network { get; set; }

    [JsonPropertyName("currency")]
    public BulkGeolocationLookupResponseItemCurrency? Currency { get; set; }

    [JsonPropertyName("security")]
    public BulkGeolocationLookupResponseItemSecurity? Security { get; set; }

    [JsonPropertyName("abuse")]
    public IEnumerable<BulkGeolocationLookupResponseItemAbuseItem>? Abuse { get; set; }

    [JsonPropertyName("time_zone")]
    public BulkGeolocationLookupResponseItemTimeZone? TimeZone { get; set; }

    [JsonPropertyName("user_agent")]
    public BulkGeolocationLookupResponseItemUserAgent? UserAgent { get; set; }

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
