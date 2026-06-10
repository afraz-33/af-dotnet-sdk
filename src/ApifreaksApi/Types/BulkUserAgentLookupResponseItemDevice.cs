using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkUserAgentLookupResponseItemDevice : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Device name or the hardware that was used
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Device type or the hardware type. Possible values:
    /// 1. Desktop
    /// 2. Mobile
    /// 3. Tablet
    /// 4. Phone
    /// 5. Watch
    /// 6. Virtual Reality
    /// 7. eReader
    /// 8. Set-top box
    /// 9. TV
    /// 10. Game Console
    /// 11. Handheld Game Console
    /// 12. Voice
    /// 13. Robot
    /// 14. Robot Mobile
    /// 15. Robot Imitator
    /// 16. Hacker
    /// 17. Anonymized
    /// 18. Unknown
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Device brand or the hardware brand name
    /// </summary>
    [JsonPropertyName("brand")]
    public required string Brand { get; set; }

    /// <summary>
    /// Device's CPU model or machine CPU
    /// </summary>
    [JsonPropertyName("cpu")]
    public required string Cpu { get; set; }

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
