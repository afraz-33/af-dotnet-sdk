using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// Defines what data to extract and how to extract it.
/// </summary>
[Serializable]
public record WebScrapeRequestBodyBlockUrlInstructionsItemExtractExtract : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// CSS selector or XPath to extract HTML content. Example: "/html/body"
    /// </summary>
    [JsonPropertyName("html")]
    public string? Html { get; set; }

    /// <summary>
    /// CSS selector or XPath to extract text content. Example: "/html/body/div/div[2]/text"
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// CSS selector or XPath to extract user data. Example: "/html/body/div/div[2]"
    /// </summary>
    [JsonPropertyName("user_data")]
    public string? UserData { get; set; }

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
