using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record TimezoneLookupRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response
    /// </summary>
    [JsonIgnore]
    public TimezoneLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// IPv4 or IPv6 address to extract timezone information.
    /// </summary>
    [JsonIgnore]
    public string? Ip { get; set; }

    /// <summary>
    /// Timezone name (e.g., "Asia/Kolkata") to retrieve information directly.
    /// </summary>
    [JsonIgnore]
    public string? Tz { get; set; }

    /// <summary>
    /// Location string (preferably city and country) to extract timezone.
    /// </summary>
    [JsonIgnore]
    public string? Location { get; set; }

    /// <summary>
    /// Latitude for geolocation lookup.
    /// </summary>
    [JsonIgnore]
    public float? Lat { get; set; }

    /// <summary>
    /// Longitude for geolocation lookup.
    /// </summary>
    [JsonIgnore]
    public float? Long { get; set; }

    /// <summary>
    /// Language code for response localization (default is "en").
    /// </summary>
    [JsonIgnore]
    public TimezoneLookupRequestLang? Lang { get; set; }

    /// <summary>
    /// 3-letter IATA airport code (e.g., JFK).
    /// </summary>
    [JsonIgnore]
    public string? IataCode { get; set; }

    /// <summary>
    /// 4-letter ICAO airport code (e.g., KJFK).
    /// </summary>
    [JsonIgnore]
    public string? IcaoCode { get; set; }

    /// <summary>
    /// 5-letter UN/LO city code.
    /// </summary>
    [JsonIgnore]
    public string? LoCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
