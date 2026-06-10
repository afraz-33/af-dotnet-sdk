using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace ApifreaksApi;

[Serializable]
public record WebScrapeRequestBodyOne : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of sequential instructions to execute after receiving the static HTML response. Supported methods include `postForm`, `getForm`, and `extract`.
    /// </summary>
    [JsonPropertyName("instructions")]
    public IEnumerable<
        OneOf<
            WebScrapeRequestBodyOneInstructionsItemPostForm,
            WebScrapeRequestBodyOneInstructionsItemGetForm,
            WebScrapeRequestBodyOneInstructionsItemExtract,
            WebScrapeRequestBodyOneInstructionsItemGetPage
        >
    > Instructions { get; set; } =
        new List<
            OneOf<
                WebScrapeRequestBodyOneInstructionsItemPostForm,
                WebScrapeRequestBodyOneInstructionsItemGetForm,
                WebScrapeRequestBodyOneInstructionsItemExtract,
                WebScrapeRequestBodyOneInstructionsItemGetPage
            >
        >();

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
