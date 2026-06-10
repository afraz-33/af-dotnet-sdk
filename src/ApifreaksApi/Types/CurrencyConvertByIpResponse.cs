using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyConvertByIpResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Date and time with timezone (UTC) representing the exact time at which the conversion rate was recorded.
    /// </summary>
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <summary>
    /// Base currency code whose amount will be converted.
    /// </summary>
    [JsonPropertyName("from")]
    public required string From { get; set; }

    /// <summary>
    /// Desired currency code for the converted amount.
    /// </summary>
    [JsonPropertyName("to")]
    public required string To { get; set; }

    /// <summary>
    /// Current conversion rate with the base currency as the desired converted currency and the quote currency as the 'from' currency code.
    /// </summary>
    [JsonPropertyName("rate")]
    public required string Rate { get; set; }

    /// <summary>
    /// IP Address whose country's currency will be extracted and used as 'to'. Defaults to the request IP if not provided.
    /// </summary>
    [JsonPropertyName("ipAddress")]
    public required string IpAddress { get; set; }

    /// <summary>
    /// The amount to be converted.
    /// </summary>
    [JsonPropertyName("givenAmount")]
    public required string GivenAmount { get; set; }

    /// <summary>
    /// Converted amount in the desired currency.
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
