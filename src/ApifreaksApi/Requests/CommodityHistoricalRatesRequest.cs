using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityHistoricalRatesRequest
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
    public CommodityHistoricalRatesRequestFormat? Format { get; set; }

    /// <summary>
    /// Historical date (YYYY-MM-DD)
    /// </summary>
    [JsonIgnore]
    public required DateOnly Date { get; set; }

    /// <summary>
    /// Comma-separated list of commodity symbols
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Symbols { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
