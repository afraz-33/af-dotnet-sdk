using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeocoderReverseRequest
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
    public GeocoderReverseRequestFormat? Format { get; set; }

    /// <summary>
    /// WGS84 latitude value ranging from -90 to 90.
    /// </summary>
    [JsonIgnore]
    public required double Lat { get; set; }

    /// <summary>
    /// WGS84 longitude value ranging from -180 to 180.
    /// </summary>
    [JsonIgnore]
    public required double Lon { get; set; }

    /// <summary>
    /// Preferred language order for showing search results. This may either be a simple comma-separated list of language codes or a single entry. The results will be in the 1st language which is matched from the header. As a fallback if the results are not supported in the given language, en will be used.
    /// </summary>
    [JsonIgnore]
    public string? AcceptLanguage { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
