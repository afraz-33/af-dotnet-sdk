using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencySupportedResponseSupportedCurrenciesMapValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; set; }

    [JsonPropertyName("currencyName")]
    public required string CurrencyName { get; set; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("countryName")]
    public required string CountryName { get; set; }

    [JsonPropertyName("status")]
    public required CurrencySupportedResponseSupportedCurrenciesMapValueStatus Status { get; set; }

    [JsonPropertyName("availableFrom")]
    public required string AvailableFrom { get; set; }

    [JsonPropertyName("availableUntil")]
    public required string AvailableUntil { get; set; }

    [JsonPropertyName("icon")]
    public required string Icon { get; set; }

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
