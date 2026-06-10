using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyConvertLatestRequest
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
    public CurrencyConvertLatestRequestFormat? Format { get; set; }

    /// <summary>
    /// Source currency code
    /// </summary>
    [JsonIgnore]
    public required string From { get; set; }

    /// <summary>
    /// Target currency code
    /// </summary>
    [JsonIgnore]
    public required string To { get; set; }

    /// <summary>
    /// Amount to convert
    /// </summary>
    [JsonIgnore]
    public double? Amount { get; set; }

    /// <summary>
    /// Exchange rates update period (1d=daily, 1h=hourly, 10m=10 minutes, 1m=1 minute)
    /// </summary>
    [JsonIgnore]
    public CurrencyConvertLatestRequestUpdates? Updates { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
