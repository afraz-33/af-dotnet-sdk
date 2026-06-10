using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityFluctuationResponse : IJsonOnDeserialized
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
    public Dictionary<string, CommodityFluctuationResponseMetadataValue>? Metadata { get; set; }

    /// <summary>
    /// The start date of the fluctuation interval in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    /// <summary>
    /// The end date of the fluctuation interval in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// Map keyed by commodity symbol; value contains fluctuation metrics.
    /// </summary>
    [JsonPropertyName("rates")]
    public Dictionary<string, CommodityFluctuationResponseRatesValue> Rates { get; set; } =
        new Dictionary<string, CommodityFluctuationResponseRatesValue>();

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
