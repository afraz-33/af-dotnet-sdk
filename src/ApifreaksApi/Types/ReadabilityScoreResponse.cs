using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ReadabilityScoreResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Standard readability formula scores, keyed by metric name. Metrics that cannot be computed for the supplied text are omitted.
    /// </summary>
    [JsonPropertyName("readability_scores")]
    public ReadabilityScoreResponseReadabilityScores? ReadabilityScores { get; set; }

    /// <summary>
    /// Per-sentence readability breakdown
    /// </summary>
    [JsonPropertyName("sentence_readability")]
    public IEnumerable<ReadabilityScoreResponseSentenceReadabilityItem>? SentenceReadability { get; set; }

    /// <summary>
    /// Overall readability grade, calculated as the average of sentence readability scores
    /// </summary>
    [JsonPropertyName("readability_grade")]
    public double? ReadabilityGrade { get; set; }

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
