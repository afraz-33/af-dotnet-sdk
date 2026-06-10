using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetCitiesResponseCitiesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    [JsonPropertyName("admin_unit")]
    public required GetCitiesResponseCitiesItemAdminUnit AdminUnit { get; set; }

    [JsonPropertyName("iso_alpha_2")]
    public required string IsoAlpha2 { get; set; }

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
