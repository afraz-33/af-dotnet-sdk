using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record MarineWeatherResponseForecastValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Daily marine forecast data
    /// </summary>
    [JsonPropertyName("daily")]
    public MarineWeatherResponseForecastValueDaily? Daily { get; set; }

    /// <summary>
    /// Hourly marine forecast data
    /// </summary>
    [JsonPropertyName("hourly")]
    public IEnumerable<MarineWeatherResponseForecastValueHourlyItem>? Hourly { get; set; }

    /// <summary>
    /// Minutely marine forecast data
    /// </summary>
    [JsonPropertyName("minutely")]
    public IEnumerable<MarineWeatherResponseForecastValueMinutelyItem>? Minutely { get; set; }

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
