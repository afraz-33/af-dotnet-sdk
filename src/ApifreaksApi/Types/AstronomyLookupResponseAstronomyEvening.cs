using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AstronomyLookupResponseAstronomyEvening : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("golden_hour_begin")]
    public string? GoldenHourBegin { get; set; }

    [JsonPropertyName("golden_hour_end")]
    public string? GoldenHourEnd { get; set; }

    [JsonPropertyName("blue_hour_begin")]
    public string? BlueHourBegin { get; set; }

    [JsonPropertyName("blue_hour_end")]
    public string? BlueHourEnd { get; set; }

    [JsonPropertyName("civil_twilight_begin")]
    public string? CivilTwilightBegin { get; set; }

    [JsonPropertyName("civil_twilight_end")]
    public string? CivilTwilightEnd { get; set; }

    [JsonPropertyName("nautical_twilight_begin")]
    public string? NauticalTwilightBegin { get; set; }

    [JsonPropertyName("nautical_twilight_end")]
    public string? NauticalTwilightEnd { get; set; }

    [JsonPropertyName("astronomical_twilight_begin")]
    public string? AstronomicalTwilightBegin { get; set; }

    [JsonPropertyName("astronomical_twilight_end")]
    public string? AstronomicalTwilightEnd { get; set; }

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
