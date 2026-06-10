using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfCompressRequest
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
    public PdfCompressRequestFormat? Format { get; set; }

    /// <summary>
    /// The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file.
    /// </summary>
    [JsonIgnore]
    public string? FileId { get; set; }

    /// <summary>
    /// Name of the output PDF.
    /// </summary>
    [JsonIgnore]
    public string? Output { get; set; }

    /// <summary>
    /// Controls how aggressively the PDF is compressed. Lower levels preserve more quality, while higher levels reduce file size more.
    /// </summary>
    [JsonIgnore]
    public required PdfCompressRequestCompressionLevel CompressionLevel { get; set; }

    /// <summary>
    /// If set to true, the input file(s) will be deleted from the server immediately after the output is generated.
    /// </summary>
    [JsonIgnore]
    public bool? Destroy { get; set; }

    /// <summary>
    /// The URL to which the webhook notification will be sent after the task is completed.
    /// </summary>
    [JsonIgnore]
    public string? WebhookUrl { get; set; }

    /// <summary>
    /// If true, a notification will also be sent by email in case the webhook request fails all the retries.  The email notification will be sent to the requesting user or their organization’s admin if part of one.
    /// </summary>
    [JsonIgnore]
    public bool? WebhookFailureNotification { get; set; }

    /// <summary>
    /// Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    /// </summary>
    [JsonIgnore]
    public string? WebhookAuthorization { get; set; }

    public FileParameter? File { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
