using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityTimeSeriesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// API request success indicator. "true" for successful requests.
    /// </summary>
    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    /// <summary>
    /// Unix timestamp indicating when the response was generated.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double? Timestamp { get; set; }

    /// <summary>
    /// Map containing detailed information for all the requested commodities keyed by commodity symbol.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, CommodityTimeSeriesResponseMetadataValue>? Metadata { get; set; }

    /// <summary>
    /// The start date of the time series data in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    /// <summary>
    /// The end date of the time series data in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// Date-indexed map; each key is a date (YYYY-MM-DD) whose value maps commodity symbols to OHLC data.
    /// </summary>
    [JsonPropertyName("rates")]
    public Dictionary<
        string,
        Dictionary<string, CommodityTimeSeriesResponseRatesValueValue>
    > Rates { get; set; } =
        new Dictionary<string, Dictionary<string, CommodityTimeSeriesResponseRatesValueValue>>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
