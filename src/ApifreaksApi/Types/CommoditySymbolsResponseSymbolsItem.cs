using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommoditySymbolsResponseSymbolsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique ticker symbol for the commodity (e.g., "XAU", "NG-FUT").
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; set; }

    /// <summary>
    /// The full name of the commodity (e.g., "Gold", "Natural Gas Futures").
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The category the commodity belongs to (e.g., "Metals", "Energy").
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }

    /// <summary>
    /// The current status of the commodity. Possible value: "active".
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// The rate at which this commodity's price is updated.
    /// </summary>
    [JsonPropertyName("updateInterval")]
    public required CommoditySymbolsResponseSymbolsItemUpdateInterval UpdateInterval { get; set; }

    [JsonPropertyName("currency")]
    public required CommoditySymbolsResponseSymbolsItemCurrency Currency { get; set; }

    [JsonPropertyName("unit")]
    public required CommoditySymbolsResponseSymbolsItemUnit Unit { get; set; }

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
