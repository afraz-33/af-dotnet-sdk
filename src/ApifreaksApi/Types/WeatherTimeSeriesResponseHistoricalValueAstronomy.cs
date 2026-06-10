using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// Astronomy data
/// </summary>
[Serializable]
public record WeatherTimeSeriesResponseHistoricalValueAstronomy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Calendar date in YYYY-MM-DD format for the astronomical data.
    /// </summary>
    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    /// <summary>
    /// Time of true solar midnight in HH:MM format.
    /// </summary>
    [JsonPropertyName("mid_night")]
    public required string MidNight { get; set; }

    /// <summary>
    /// Time when astronomical twilight ends and dawn begins in HH:MM format.
    /// </summary>
    [JsonPropertyName("night_end")]
    public required string NightEnd { get; set; }

    /// <summary>
    /// Time when the Sun becomes visible above the horizon in HH:MM format.
    /// </summary>
    [JsonPropertyName("sunrise")]
    public required string Sunrise { get; set; }

    /// <summary>
    /// Time when the Sun reaches its highest point in the sky in HH:MM format.
    /// </summary>
    [JsonPropertyName("solar_noon")]
    public required string SolarNoon { get; set; }

    /// <summary>
    /// Time when the Sun disappears below the horizon in HH:MM format.
    /// </summary>
    [JsonPropertyName("sunset")]
    public required string Sunset { get; set; }

    /// <summary>
    /// Time when astronomical twilight begins and night starts in HH:MM format.
    /// </summary>
    [JsonPropertyName("night_begin")]
    public required string NightBegin { get; set; }

    /// <summary>
    /// Total duration of daylight in HH:MM format.
    /// </summary>
    [JsonPropertyName("day_length")]
    public required string DayLength { get; set; }

    /// <summary>
    /// Current position of the Sun relative to the horizon (above_horizon, below_horizon, or -).
    /// </summary>
    [JsonPropertyName("sun_status")]
    public required string SunStatus { get; set; }

    /// <summary>
    /// Current lunar phase (NEW_MOON, WAXING_CRESCENT, FULL_MOON, WANING_GIBBOUS, etc.).
    /// </summary>
    [JsonPropertyName("moon_phase")]
    public required string MoonPhase { get; set; }

    /// <summary>
    /// Time when the Moon becomes visible above the horizon in HH:MM format.
    /// </summary>
    [JsonPropertyName("moonrise")]
    public required string Moonrise { get; set; }

    /// <summary>
    /// Time when the Moon disappears below the horizon in HH:MM format.
    /// </summary>
    [JsonPropertyName("moonset")]
    public required string Moonset { get; set; }

    /// <summary>
    /// Current visibility status of the Moon (visible, not_visible, or -).
    /// </summary>
    [JsonPropertyName("moon_status")]
    public required string MoonStatus { get; set; }

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
