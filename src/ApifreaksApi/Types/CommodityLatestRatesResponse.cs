using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityLatestRatesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// API request success indicator. 'true' for successful requests.
    /// </summary>
    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    /// <summary>
    /// Unix timestamp indicating when the response was generated.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required double Timestamp { get; set; }

    /// <summary>
    /// Map containing rate data for all the requested commodities.
    /// </summary>
    [JsonPropertyName("rates")]
    public Dictionary<string, double> Rates { get; set; } = new Dictionary<string, double>();

    /// <summary>
    /// Map containing detailed information for all the requested commodities keyed by commodity symbol.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, CommodityLatestRatesResponseMetadataValue> Metadata { get; set; } =
        new Dictionary<string, CommodityLatestRatesResponseMetadataValue>();

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
