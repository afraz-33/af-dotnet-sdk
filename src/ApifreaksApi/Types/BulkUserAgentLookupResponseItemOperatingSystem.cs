using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkUserAgentLookupResponseItemOperatingSystem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Operating system name or the base software name that runs on the hardware.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Operating system type. Possible values:
    /// 1. Desktop
    /// 2. Mobile
    /// 3. Game Console
    /// 4. Embedded
    /// 5. Cloud
    /// 6. Hacker
    /// 7. Anonymized
    /// 8. Unknown
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Operating system version
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    /// <summary>
    /// Operating system version major
    /// </summary>
    [JsonPropertyName("version_major")]
    public required string VersionMajor { get; set; }

    /// <summary>
    /// Operating system build
    /// </summary>
    [JsonPropertyName("build")]
    public required string Build { get; set; }

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
