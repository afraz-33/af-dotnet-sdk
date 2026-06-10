using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetCountriesResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("countries")]
    public IEnumerable<GetCountriesResponseCountriesItem> Countries { get; set; } =
        new List<GetCountriesResponseCountriesItem>();

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
