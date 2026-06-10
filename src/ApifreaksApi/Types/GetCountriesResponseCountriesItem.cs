using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetCountriesResponseCountriesItem : IJsonOnDeserialized
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

    [JsonPropertyName("capital")]
    public required string Capital { get; set; }

    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("subregion")]
    public required string Subregion { get; set; }

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
