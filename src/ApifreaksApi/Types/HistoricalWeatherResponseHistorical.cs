using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// Historical data object of the provided date
/// </summary>
[Serializable]
public record HistoricalWeatherResponseHistorical : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Daily historical data
    /// </summary>
    [JsonPropertyName("daily")]
    public HistoricalWeatherResponseHistoricalDaily? Daily { get; set; }

    /// <summary>
    /// Hourly historical data
    /// </summary>
    [JsonPropertyName("hourly")]
    public IEnumerable<HistoricalWeatherResponseHistoricalHourlyItem>? Hourly { get; set; }

    /// <summary>
    /// Astronomy data
    /// </summary>
    [JsonPropertyName("astronomy")]
    public HistoricalWeatherResponseHistoricalAstronomy? Astronomy { get; set; }

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
