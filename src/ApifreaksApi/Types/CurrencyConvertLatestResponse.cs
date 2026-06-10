using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyConvertLatestResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// For the latest rates converter, it is the date and time with timezone (UTC) when the rate was recorded. For historical converter, it is the date provided in the input (format: YYYY-MM-DD).
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// Base currency code (the currency being converted from).
    /// </summary>
    [JsonPropertyName("from")]
    public required string From { get; set; }

    /// <summary>
    /// Desired currency code (the currency to convert to).
    /// </summary>
    [JsonPropertyName("to")]
    public required string To { get; set; }

    /// <summary>
    /// Conversion rate from base currency to desired currency.
    /// </summary>
    [JsonPropertyName("rate")]
    public required string Rate { get; set; }

    /// <summary>
    /// The amount in base currency to be converted.
    /// </summary>
    [JsonPropertyName("givenAmount")]
    public required string GivenAmount { get; set; }

    /// <summary>
    /// The result of the conversion in the desired currency.
    /// </summary>
    [JsonPropertyName("convertedAmount")]
    public required string ConvertedAmount { get; set; }

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
