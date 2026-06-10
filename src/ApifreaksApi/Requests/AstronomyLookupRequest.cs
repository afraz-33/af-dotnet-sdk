using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AstronomyLookupRequest
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
    public AstronomyLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Location name or address
    /// </summary>
    [JsonIgnore]
    public string? Location { get; set; }

    /// <summary>
    /// Latitude for location coordinates
    /// </summary>
    [JsonIgnore]
    public float? Lat { get; set; }

    /// <summary>
    /// Longitude for location coordinates
    /// </summary>
    [JsonIgnore]
    public float? Long { get; set; }

    /// <summary>
    /// IP address for location detection
    /// </summary>
    [JsonIgnore]
    public string? Ip { get; set; }

    [JsonIgnore]
    public string? Lang { get; set; }

    /// <summary>
    /// Date for astronomy data (YYYY-MM-DD)
    /// </summary>
    [JsonIgnore]
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Timezone of the location for which astronomy data is required
    /// </summary>
    [JsonIgnore]
    public double? Elevation { get; set; }

    [JsonIgnore]
    public string? TimeZone { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
