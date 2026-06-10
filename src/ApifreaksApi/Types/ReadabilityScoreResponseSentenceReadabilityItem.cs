using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ReadabilityScoreResponseSentenceReadabilityItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The sentence text
    /// </summary>
    [JsonPropertyName("sentence")]
    public string? Sentence { get; set; }

    /// <summary>
    /// Readability grade for the sentence
    /// </summary>
    [JsonPropertyName("readability_grade")]
    public double? ReadabilityGrade { get; set; }

    /// <summary>
    /// Difficulty level for the sentence based on the target audience
    /// </summary>
    [JsonPropertyName("readability_level")]
    public ReadabilityScoreResponseSentenceReadabilityItemReadabilityLevel? ReadabilityLevel { get; set; }

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
