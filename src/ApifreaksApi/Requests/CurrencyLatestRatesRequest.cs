using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyLatestRatesRequest
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
    public CurrencyLatestRatesRequestFormat? Format { get; set; }

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
    /// Exchange rates update period (1d=daily, 1h=hourly, 10m=10 minutes, 1m=1 minute)
    /// </summary>
    [JsonIgnore]
    public CurrencyLatestRatesRequestUpdates? Updates { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
