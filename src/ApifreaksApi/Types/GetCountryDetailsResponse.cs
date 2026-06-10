using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetCountryDetailsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("iso_alpha_2")]
    public required string IsoAlpha2 { get; set; }

    [JsonPropertyName("iso_alpha_3")]
    public required string IsoAlpha3 { get; set; }

    [JsonPropertyName("iso_numeric")]
    public required int IsoNumeric { get; set; }

    [JsonPropertyName("phone_code")]
    public required int PhoneCode { get; set; }

    [JsonPropertyName("capital")]
    public required string Capital { get; set; }

    [JsonPropertyName("top_level_domain")]
    public required string TopLevelDomain { get; set; }

    [JsonPropertyName("native_name")]
    public required string NativeName { get; set; }

    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("subregion")]
    public required string Subregion { get; set; }

    [JsonPropertyName("nationality")]
    public required string Nationality { get; set; }

    [JsonPropertyName("flag_emoji")]
    public required string FlagEmoji { get; set; }

    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; set; }

    [JsonPropertyName("currency_name")]
    public required string CurrencyName { get; set; }

    [JsonPropertyName("currency_symbol")]
    public required string CurrencySymbol { get; set; }

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
