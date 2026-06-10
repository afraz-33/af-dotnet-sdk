using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupResponseItemCountryMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The calling code of the country
    /// </summary>
    [JsonPropertyName("calling_code")]
    public string? CallingCode { get; set; }

    /// <summary>
    /// The top level domain of the country
    /// </summary>
    [JsonPropertyName("tld")]
    public string? Tld { get; set; }

    /// <summary>
    /// The languages spoken in the country
    /// </summary>
    [JsonPropertyName("languages")]
    public IEnumerable<string>? Languages { get; set; }

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
