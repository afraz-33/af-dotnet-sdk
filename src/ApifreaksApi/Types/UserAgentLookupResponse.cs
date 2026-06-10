using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record UserAgentLookupResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// User-agent string that is parsed for browser, device and operating system details.
    /// </summary>
    [JsonPropertyName("user_agent_string")]
    public required string UserAgentString { get; set; }

    /// <summary>
    /// Agent name or the actual browser name that was used.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Agent type or the browser type that was used. Possible values:
    /// 1. Browser
    /// 2. Browser Webview
    /// 3. Mobile App
    /// 4. Robot Mobile
    /// 5. Cloud Application
    /// 6. Email Client
    /// 7. Voice
    /// 8. Special
    /// 9. Testclient
    /// 10. Hacker
    /// 11. Unknown
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Agent version or the browser version
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    /// <summary>
    /// Agent version major or the browser version major
    /// </summary>
    [JsonPropertyName("version_major")]
    public required string VersionMajor { get; set; }

    [JsonPropertyName("device")]
    public required UserAgentLookupResponseDevice Device { get; set; }

    [JsonPropertyName("engine")]
    public required UserAgentLookupResponseEngine Engine { get; set; }

    [JsonPropertyName("operating_system")]
    public required UserAgentLookupResponseOperatingSystem OperatingSystem { get; set; }

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
