using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AstronomyLookupResponseAstronomy : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Time zone to receive all time-based data in your preferred local time.
    /// </summary>
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Date for astronomy data (YYYY-MM-DD)
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// Current time (HH:mm:ss.SSS)
    /// </summary>
    [JsonPropertyName("current_time")]
    public required string CurrentTime { get; set; }

    /// <summary>
    /// Midnight time (HH:mm)
    /// </summary>
    [JsonPropertyName("mid_night")]
    public required string MidNight { get; set; }

    /// <summary>
    /// Time when night ends (HH:mm)
    /// </summary>
    [JsonPropertyName("night_end")]
    public required string NightEnd { get; set; }

    [JsonPropertyName("morning")]
    public required AstronomyLookupResponseAstronomyMorning Morning { get; set; }

    /// <summary>
    /// Sunrise time (HH:mm)
    /// </summary>
    [JsonPropertyName("sunrise")]
    public required string Sunrise { get; set; }

    /// <summary>
    /// Sunset time (HH:mm)
    /// </summary>
    [JsonPropertyName("sunset")]
    public required string Sunset { get; set; }

    [JsonPropertyName("evening")]
    public required AstronomyLookupResponseAstronomyEvening Evening { get; set; }

    /// <summary>
    /// Time when night begins (HH:mm)
    /// </summary>
    [JsonPropertyName("night_begin")]
    public required string NightBegin { get; set; }

    /// <summary>
    /// Current status of the sun
    /// </summary>
    [JsonPropertyName("sun_status")]
    public required string SunStatus { get; set; }

    /// <summary>
    /// Solar noon time (HH:mm)
    /// </summary>
    [JsonPropertyName("solar_noon")]
    public required string SolarNoon { get; set; }

    /// <summary>
    /// Length of the day (HH:mm)
    /// </summary>
    [JsonPropertyName("day_length")]
    public required string DayLength { get; set; }

    /// <summary>
    /// Sun altitude angle
    /// </summary>
    [JsonPropertyName("sun_altitude")]
    public required float SunAltitude { get; set; }

    /// <summary>
    /// Distance from Earth to Sun
    /// </summary>
    [JsonPropertyName("sun_distance")]
    public required float SunDistance { get; set; }

    /// <summary>
    /// Sun azimuth angle
    /// </summary>
    [JsonPropertyName("sun_azimuth")]
    public required float SunAzimuth { get; set; }

    /// <summary>
    /// Moon phase
    /// </summary>
    [JsonPropertyName("moon_phase")]
    public required string MoonPhase { get; set; }

    /// <summary>
    /// Moonrise time (HH:mm)
    /// </summary>
    [JsonPropertyName("moonrise")]
    public required string Moonrise { get; set; }

    /// <summary>
    /// Moonset time (HH:mm)
    /// </summary>
    [JsonPropertyName("moonset")]
    public required string Moonset { get; set; }

    /// <summary>
    /// Current status of the moon
    /// </summary>
    [JsonPropertyName("moon_status")]
    public required string MoonStatus { get; set; }

    /// <summary>
    /// Moon altitude angle
    /// </summary>
    [JsonPropertyName("moon_altitude")]
    public required float MoonAltitude { get; set; }

    /// <summary>
    /// Distance from Earth to Moon
    /// </summary>
    [JsonPropertyName("moon_distance")]
    public required float MoonDistance { get; set; }

    /// <summary>
    /// Moon azimuth angle
    /// </summary>
    [JsonPropertyName("moon_azimuth")]
    public required float MoonAzimuth { get; set; }

    /// <summary>
    /// Moon parallactic angle
    /// </summary>
    [JsonPropertyName("moon_parallactic_angle")]
    public required float MoonParallacticAngle { get; set; }

    /// <summary>
    /// Moon illumination percentage
    /// </summary>
    [JsonPropertyName("moon_illumination_percentage")]
    public required string MoonIlluminationPercentage { get; set; }

    /// <summary>
    /// Moon angle
    /// </summary>
    [JsonPropertyName("moon_angle")]
    public required float MoonAngle { get; set; }

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
