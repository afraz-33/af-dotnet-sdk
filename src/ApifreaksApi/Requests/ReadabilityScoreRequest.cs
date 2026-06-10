using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ReadabilityScoreRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Target audience used to tune sentence difficulty levels
    /// </summary>
    [JsonIgnore]
    public ReadabilityScoreRequestTarget? Target { get; set; }

    /// <summary>
    /// Comma-separated response sections to omit. Possible values are readability_scores, sentence_readability, readability_grade
    /// </summary>
    [JsonIgnore]
    public string? Exclude { get; set; }

    /// <summary>
    /// Text to analyze for readability
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
