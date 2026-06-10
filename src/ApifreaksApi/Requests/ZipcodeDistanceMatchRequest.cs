using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ZipcodeDistanceMatchRequest
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
    public ZipcodeDistanceMatchRequestFormat? Format { get; set; }

    /// <summary>
    /// Comma-separated list of postal/zip codes. Maximum 100 values allowed.
    /// </summary>
    [JsonPropertyName("codes")]
    public IEnumerable<string> Codes { get; set; } = new List<string>();

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; set; }

    /// <summary>
    /// Maximum allowed distance between postal code pairs.
    /// </summary>
    [JsonPropertyName("distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// Supported distance units are m, km, mi, ft, yd, in.
    /// </summary>
    [JsonPropertyName("unit")]
    public ZipcodeDistanceMatchRequestUnit? Unit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
