using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// The number represented in four standardized formats. Only returned for valid numbers.
/// </summary>
[Serializable]
public record BulkPhoneValidateResponseItemFormats : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// E.164 format for storage and APIs.
    /// </summary>
    [JsonPropertyName("E164")]
    public string? E164 { get; set; }

    /// <summary>
    /// Human-readable international format.
    /// </summary>
    [JsonPropertyName("International")]
    public string? International { get; set; }

    /// <summary>
    /// Local format as dialed within the country.
    /// </summary>
    [JsonPropertyName("National")]
    public string? National { get; set; }

    /// <summary>
    /// URI format for tel: links.
    /// </summary>
    [JsonPropertyName("RFC3966")]
    public string? Rfc3966 { get; set; }

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
