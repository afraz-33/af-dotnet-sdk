using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeocoderSearchRequest
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
    public GeocoderSearchRequestFormat? Format { get; set; }

    /// <summary>
    /// Free-form search query, e.g. Wembley Stadium, London
    /// </summary>
    [JsonIgnore]
    public required string Query { get; set; }

    /// <summary>
    /// Max number of results to return (1–40). May return fewer if matches are weak.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Minimum latitude for the viewbox. Must be ≤ max_lat and between -90 and 90.
    /// </summary>
    [JsonIgnore]
    public float? MinLat { get; set; }

    /// <summary>
    /// Maximum latitude for the viewbox. Must be ≥ min_lat and between -90 and 90.
    /// </summary>
    [JsonIgnore]
    public float? MaxLat { get; set; }

    /// <summary>
    /// Minimum longitude for the viewbox. Must be ≤ max_lon and between -180 and 180.
    /// </summary>
    [JsonIgnore]
    public float? MinLon { get; set; }

    /// <summary>
    /// Maximum longitude for the viewbox. Must be ≥ min_lon and between -180 and 180.
    /// </summary>
    [JsonIgnore]
    public float? MaxLon { get; set; }

    /// <summary>
    /// Preferred language order for showing search results. This may either be a simple comma-separated list of language codes or a single entry. The results will be in the 1st language which is matched from the header. As a fallback if the results are not supported in the given language, 'en' will be used.
    /// </summary>
    [JsonIgnore]
    public string? AcceptLanguage { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
