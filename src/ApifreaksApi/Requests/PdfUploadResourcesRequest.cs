using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfUploadResourcesRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Specifies the desired format for the API response. Choose 'json' for a JSON object or 'xml' for an XML structure.
    /// </summary>
    [JsonIgnore]
    public PdfUploadResourcesRequestFormat? Format { get; set; }

    public IEnumerable<FileParameter>? File { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
