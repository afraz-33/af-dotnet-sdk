using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfDownloadResourceRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    [JsonIgnore]
    public PdfDownloadResourceRequestFormat? Format { get; set; }

    /// <summary>
    /// The unique identifier of the file or ZIP archive to download.
    /// </summary>
    [JsonIgnore]
    public required string ResourceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
