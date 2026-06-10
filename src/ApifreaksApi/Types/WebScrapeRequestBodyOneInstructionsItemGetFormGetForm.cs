using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// Submits a form using GET method. Provide the form's XPath/CSS selector and input values.
/// </summary>
[Serializable]
public record WebScrapeRequestBodyOneInstructionsItemGetFormGetForm : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("selector")]
    public string? Selector { get; set; }

    [JsonPropertyName("data")]
    public WebScrapeRequestBodyOneInstructionsItemGetFormGetFormData? Data { get; set; }

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
