using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityFluctuationResponseRatesValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The price of the commodity on the start date of the interval.
    /// </summary>
    [JsonPropertyName("startRate")]
    public required double StartRate { get; set; }

    /// <summary>
    /// The price of the commodity on the end date of the interval.
    /// </summary>
    [JsonPropertyName("endRate")]
    public required double EndRate { get; set; }

    /// <summary>
    /// The absolute price difference between the end and start date. May be positive or negative.
    /// </summary>
    [JsonPropertyName("change")]
    public required double Change { get; set; }

    /// <summary>
    /// The percentage change in price from start to end date. May be positive or negative.
    /// </summary>
    [JsonPropertyName("changePercent")]
    public required double ChangePercent { get; set; }

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
