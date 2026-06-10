using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeolocationLookupRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response.
    /// </summary>
    [JsonIgnore]
    public GeolocationLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// IPv4, IPv6, or hostname for geolocation lookup
    /// </summary>
    [JsonIgnore]
    public string? Ip { get; set; }

    /// <summary>
    /// Response language for location fields
    /// </summary>
    [JsonIgnore]
    public GeolocationLookupRequestLang? Lang { get; set; }

    /// <summary>
    /// Comma separated list of fields to include in response
    /// </summary>
    [JsonIgnore]
    public string? Fields { get; set; }

    /// <summary>
    /// Comma separated list of fields to exclude from response
    /// </summary>
    [JsonIgnore]
    public string? Excludes { get; set; }

    /// <summary>
    /// Additional data to include (location, network, security, currency, time_zone, user_agent, country_metadata , hostname, liveHostname, hostnameFallbackLivet)
    /// </summary>
    [JsonIgnore]
    public string? Include { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
