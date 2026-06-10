using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record WeatherTimeSeriesResponseHistoricalValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Daily historical data
    /// </summary>
    [JsonPropertyName("daily")]
    public WeatherTimeSeriesResponseHistoricalValueDaily? Daily { get; set; }

    /// <summary>
    /// Hourly historical data
    /// </summary>
    [JsonPropertyName("hourly")]
    public IEnumerable<WeatherTimeSeriesResponseHistoricalValueHourlyItem>? Hourly { get; set; }

    /// <summary>
    /// Astronomy data
    /// </summary>
    [JsonPropertyName("astronomy")]
    public WeatherTimeSeriesResponseHistoricalValueAstronomy? Astronomy { get; set; }

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
