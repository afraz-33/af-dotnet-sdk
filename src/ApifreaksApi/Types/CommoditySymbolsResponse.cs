using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommoditySymbolsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Indicates whether the API request was successful.
    /// </summary>
    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    /// <summary>
    /// An array of commodity symbol objects.
    /// </summary>
    [JsonPropertyName("symbols")]
    public IEnumerable<CommoditySymbolsResponseSymbolsItem> Symbols { get; set; } =
        new List<CommoditySymbolsResponseSymbolsItem>();

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
