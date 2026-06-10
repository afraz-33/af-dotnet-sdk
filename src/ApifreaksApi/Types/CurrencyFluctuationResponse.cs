using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyFluctuationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Starting date of the interval (provided via input).
    /// </summary>
    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    /// <summary>
    /// Ending date of the interval (provided via input).
    /// </summary>
    [JsonPropertyName("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// Base currency with respect to which all fluctuations are calculated.
    /// </summary>
    [JsonPropertyName("base")]
    public required string Base { get; set; }

    /// <summary>
    /// A map of currency symbols to their fluctuation details.
    /// </summary>
    [JsonPropertyName("rateFluctuations")]
    public Dictionary<
        string,
        CurrencyFluctuationResponseRateFluctuationsValue
    > RateFluctuations { get; set; } =
        new Dictionary<string, CurrencyFluctuationResponseRateFluctuationsValue>();

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
