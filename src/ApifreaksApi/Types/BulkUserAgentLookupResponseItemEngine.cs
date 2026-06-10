using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkUserAgentLookupResponseItemEngine : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Layout engine name or the underlying core that converts the HTML into visual
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Layout engine type. Possible values:
    /// 1. Browser
    /// 2. Mobile App
    /// 3. Hacker
    /// 4. Robot
    /// 5. Unknown
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Layout engine version
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    /// <summary>
    /// Layout engine version major
    /// </summary>
    [JsonPropertyName("version_major")]
    public required string VersionMajor { get; set; }

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
