using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfUploadBinaryRequest
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
    public PdfUploadBinaryRequestFormat? Format { get; set; }

    /// <summary>
    /// The desired name for the uploaded PDF file. This name will be used for storage on the server.
    ///
    ///
    ///  **NOTE**: Please ensure file_name has extension `.pdf`.
    /// </summary>
    [JsonIgnore]
    public required string FileName { get; set; }

    [JsonIgnore]
    public required Stream Body { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
