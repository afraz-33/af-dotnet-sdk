using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyTimeSeriesResponseHistoricalRatesListItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date of the specific exchange rates.
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// A map of currency symbols to their respective exchange rates for the given date.
    /// </summary>
    [JsonPropertyName("rates")]
    public Dictionary<string, string> Rates { get; set; } = new Dictionary<string, string>();

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
