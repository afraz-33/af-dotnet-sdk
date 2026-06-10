using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record WeatherForecastResponseForecastValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Daily forecast data
    /// </summary>
    [JsonPropertyName("daily")]
    public WeatherForecastResponseForecastValueDaily? Daily { get; set; }

    /// <summary>
    /// Hourly forecast data
    /// </summary>
    [JsonPropertyName("hourly")]
    public IEnumerable<WeatherForecastResponseForecastValueHourlyItem>? Hourly { get; set; }

    /// <summary>
    /// Minutely forecast data
    /// </summary>
    [JsonPropertyName("minutely")]
    public IEnumerable<WeatherForecastResponseForecastValueMinutelyItem>? Minutely { get; set; }

    /// <summary>
    /// Astronomy data
    /// </summary>
    [JsonPropertyName("astronomy")]
    public WeatherForecastResponseForecastValueAstronomy? Astronomy { get; set; }

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
