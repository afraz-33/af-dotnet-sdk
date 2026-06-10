using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeolocationLookupResponseUserAgent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("user_agent_string")]
    public string? UserAgentString { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("version_major")]
    public string? VersionMajor { get; set; }

    [JsonPropertyName("device")]
    public GeolocationLookupResponseUserAgentDevice? Device { get; set; }

    [JsonPropertyName("engine")]
    public GeolocationLookupResponseUserAgentEngine? Engine { get; set; }

    [JsonPropertyName("operating_system")]
    public GeolocationLookupResponseUserAgentOperatingSystem? OperatingSystem { get; set; }

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
