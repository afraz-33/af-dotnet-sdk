using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// Standard readability formula scores, keyed by metric name. Metrics that cannot be computed for the supplied text are omitted.
/// </summary>
[Serializable]
public record ReadabilityScoreResponseReadabilityScores : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Flesch Reading Ease
    /// </summary>
    [JsonPropertyName("flesch_reading_ease")]
    public ReadabilityScoreResponseReadabilityScoresFleschReadingEase? FleschReadingEase { get; set; }

    /// <summary>
    /// Flesch-Kincaid Grade Level
    /// </summary>
    [JsonPropertyName("flesch_kincaid_grade")]
    public ReadabilityScoreResponseReadabilityScoresFleschKincaidGrade? FleschKincaidGrade { get; set; }

    /// <summary>
    /// Gunning Fog Index
    /// </summary>
    [JsonPropertyName("gunning_fog")]
    public ReadabilityScoreResponseReadabilityScoresGunningFog? GunningFog { get; set; }

    /// <summary>
    /// SMOG Index
    /// </summary>
    [JsonPropertyName("smog_index")]
    public ReadabilityScoreResponseReadabilityScoresSmogIndex? SmogIndex { get; set; }

    /// <summary>
    /// Coleman-Liau Index
    /// </summary>
    [JsonPropertyName("coleman_liau_index")]
    public ReadabilityScoreResponseReadabilityScoresColemanLiauIndex? ColemanLiauIndex { get; set; }

    /// <summary>
    /// Automated Readability Index (ARI)
    /// </summary>
    [JsonPropertyName("automated_readability_index")]
    public ReadabilityScoreResponseReadabilityScoresAutomatedReadabilityIndex? AutomatedReadabilityIndex { get; set; }

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
