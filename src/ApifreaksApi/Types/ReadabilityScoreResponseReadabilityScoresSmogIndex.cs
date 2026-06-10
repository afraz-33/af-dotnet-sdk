using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// SMOG Index
/// </summary>
[Serializable]
public record ReadabilityScoreResponseReadabilityScoresSmogIndex : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The metric score
    /// </summary>
    [JsonPropertyName("score")]
    public double? Score { get; set; }

    /// <summary>
    /// Human-readable difficulty level for that metric
    /// </summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

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
