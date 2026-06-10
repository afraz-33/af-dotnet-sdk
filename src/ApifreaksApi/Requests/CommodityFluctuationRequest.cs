using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityFluctuationRequest
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
    public CommodityFluctuationRequestFormat? Format { get; set; }

    /// <summary>
    /// Comma-separated list of commodity symbols
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Symbols { get; set; } = new List<string>();

    /// <summary>
    /// Start date (YYYY-MM-DD)
    /// </summary>
    [JsonIgnore]
    public required DateOnly StartDate { get; set; }

    /// <summary>
    /// End date (YYYY-MM-DD)
    /// </summary>
    [JsonIgnore]
    public required DateOnly EndDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
