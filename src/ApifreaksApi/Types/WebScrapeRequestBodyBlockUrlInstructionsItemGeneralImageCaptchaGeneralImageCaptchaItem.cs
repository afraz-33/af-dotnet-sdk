using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("imagePath")]
    public string? ImagePath { get; set; }

    [JsonPropertyName("textField")]
    public string? TextField { get; set; }

    [JsonPropertyName("imageUpdatePath")]
    public string? ImageUpdatePath { get; set; }

    [JsonPropertyName("captchaFailedPath")]
    public string? CaptchaFailedPath { get; set; }

    [JsonPropertyName("model")]
    public WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel? Model { get; set; }

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
