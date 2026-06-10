using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ZipcodeDistanceRequest
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
    public ZipcodeDistanceRequestFormat? Format { get; set; }

    /// <summary>
    /// Comma separated list of postal / zip codes with which base point is compared w.r.t. Max 100 zip codes can be provided.
    /// </summary>
    [JsonPropertyName("compare")]
    public IEnumerable<string> Compare { get; set; } = new List<string>();

    /// <summary>
    /// Postal/Zip code to be used as the base point.
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// Latitude coordinate for the base location.
    /// </summary>
    [JsonPropertyName("lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// Longitude coordinate for the base location.
    /// </summary>
    [JsonPropertyName("long")]
    public double? Long { get; set; }

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; set; }

    /// <summary>
    /// Supported distance units are m, km, mi, ft, yd, in.
    /// </summary>
    [JsonPropertyName("unit")]
    public ZipcodeDistanceRequestUnit? Unit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
