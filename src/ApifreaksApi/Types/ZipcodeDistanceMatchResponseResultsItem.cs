using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ZipcodeDistanceMatchResponseResultsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// First ZIP/postal code in the pair
    /// </summary>
    [JsonPropertyName("code_1")]
    public string? Code1 { get; set; }

    /// <summary>
    /// Second ZIP/postal code in the pair
    /// </summary>
    [JsonPropertyName("code_2")]
    public string? Code2 { get; set; }

    /// <summary>
    /// Distance between the ZIP/postal code pair
    /// </summary>
    [JsonPropertyName("distance")]
    public float? Distance { get; set; }

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
