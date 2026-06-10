using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyConvertHistoricalRequest
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
    public CurrencyConvertHistoricalRequestFormat? Format { get; set; }

    /// <summary>
    /// From currency symbol
    /// </summary>
    [JsonIgnore]
    public required string From { get; set; }

    /// <summary>
    /// To currency symbol
    /// </summary>
    [JsonIgnore]
    public required string To { get; set; }

    /// <summary>
    /// The Amount to be converted
    /// </summary>
    [JsonIgnore]
    public double? Amount { get; set; }

    /// <summary>
    /// specific date (format YYYY-MM-DD) of which exchange rates is used.
    /// </summary>
    [JsonIgnore]
    public required DateOnly Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
