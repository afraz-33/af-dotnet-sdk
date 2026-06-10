using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencySupportedResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A map of all supported currencies, keyed by currency code.
    /// </summary>
    [JsonPropertyName("supportedCurrenciesMap")]
    public Dictionary<
        string,
        CurrencySupportedResponseSupportedCurrenciesMapValue
    > SupportedCurrenciesMap { get; set; } =
        new Dictionary<string, CurrencySupportedResponseSupportedCurrenciesMapValue>();

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
