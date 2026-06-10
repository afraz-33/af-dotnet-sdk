using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyHistoricalRatesRequest
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
    public CurrencyHistoricalRatesRequestFormat? Format { get; set; }

    /// <summary>
    /// Base currency for rate calculations
    /// </summary>
    [JsonIgnore]
    public string? Base { get; set; }

    /// <summary>
    /// Comma separated list of desired currency codes
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Symbols { get; set; } = new List<string>();

    /// <summary>
    /// Specific date in YYYY-MM-DD format
    /// </summary>
    [JsonIgnore]
    public required DateOnly Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
