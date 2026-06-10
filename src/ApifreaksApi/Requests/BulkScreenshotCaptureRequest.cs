using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkScreenshotCaptureRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    [JsonIgnore]
    public BulkScreenshotCaptureRequestFormat? Format { get; set; }

    /// <summary>
    /// List of website URLs to capture screenshots of
    /// </summary>
    [JsonPropertyName("urls")]
    public IEnumerable<BulkScreenshotCaptureRequestUrlsItem> Urls { get; set; } =
        new List<BulkScreenshotCaptureRequestUrlsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
