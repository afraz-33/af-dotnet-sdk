using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyLatestRatesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// For the latest currencies exchange rates endpoint, it is the date and time with timezone (UTC) at which these rates were recorded. For historical currencies exchange rates endpoint, it is the specific date in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// Base currency used for calculating exchange rates.
    /// </summary>
    [JsonPropertyName("base")]
    public required string Base { get; set; }

    /// <summary>
    /// A map of currency codes to their exchange rate against the base currency.
    /// </summary>
    [JsonPropertyName("rates")]
    public Dictionary<string, string> Rates { get; set; } = new Dictionary<string, string>();

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
