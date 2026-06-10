using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ZipcodeSearchByRadiusRequest
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
    public ZipcodeSearchByRadiusRequestFormat? Format { get; set; }

    /// <summary>
    /// Postal/Zip code to be used as the center point for the search.
    /// </summary>
    [JsonIgnore]
    public string? Code { get; set; }

    /// <summary>
    /// Latitude coordinate for the base location.
    /// </summary>
    [JsonIgnore]
    public float? Lat { get; set; }

    /// <summary>
    /// Longitude coordinate for the base location.
    /// </summary>
    [JsonIgnore]
    public float? Long { get; set; }

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format. Required only when using the code parameter.
    /// </summary>
    [JsonIgnore]
    public string? Country { get; set; }

    /// <summary>
    /// Search radius for the query. The maximum allowed values are: - 100 km - 100 mi - 109361 yd - 100000 m - 328084 ft - 3937007.75 in
    /// </summary>
    [JsonIgnore]
    public required float Radius { get; set; }

    /// <summary>
    /// Supported distance units are m, km, mi, ft, yd, in.
    /// </summary>
    [JsonIgnore]
    public ZipcodeSearchByRadiusRequestUnit? Unit { get; set; }

    /// <summary>
    /// Page no. to retrieve paginated results.
    /// </summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
