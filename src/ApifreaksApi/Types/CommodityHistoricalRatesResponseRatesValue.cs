using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityHistoricalRatesResponseRatesValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date for which commodity prices were fetched. Format: YYYY-MM-DD.
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// The opening price of the commodity on the given date.
    /// </summary>
    [JsonPropertyName("open")]
    public required double Open { get; set; }

    /// <summary>
    /// The highest price of the commodity recorded on the given date.
    /// </summary>
    [JsonPropertyName("high")]
    public required double High { get; set; }

    /// <summary>
    /// The lowest price of the commodity recorded on the given date.
    /// </summary>
    [JsonPropertyName("low")]
    public required double Low { get; set; }

    /// <summary>
    /// The closing price of the commodity on the given date.
    /// </summary>
    [JsonPropertyName("close")]
    public required double Close { get; set; }

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
