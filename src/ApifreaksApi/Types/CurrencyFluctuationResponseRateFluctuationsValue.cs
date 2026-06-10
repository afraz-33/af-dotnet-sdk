using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyFluctuationResponseRateFluctuationsValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Starting rate of the currency during the interval.
    /// </summary>
    [JsonPropertyName("startRate")]
    public required string StartRate { get; set; }

    /// <summary>
    /// Ending rate of the currency during the interval.
    /// </summary>
    [JsonPropertyName("endRate")]
    public required string EndRate { get; set; }

    /// <summary>
    /// Absolute change in currency rate over the interval.
    /// </summary>
    [JsonPropertyName("change")]
    public required string Change { get; set; }

    /// <summary>
    /// Percentage change in currency rate over the interval.
    /// </summary>
    [JsonPropertyName("percentChange")]
    public required string PercentChange { get; set; }

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
