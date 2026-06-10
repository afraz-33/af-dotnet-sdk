using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkScreenshotCaptureResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("status")]
    public required string Status { get; set; }

    [JsonPropertyName("meta_data")]
    public required BulkScreenshotCaptureResponseMetaData MetaData { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<BulkScreenshotCaptureResponseResultsItem> Results { get; set; } =
        new List<BulkScreenshotCaptureResponseResultsItem>();

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
