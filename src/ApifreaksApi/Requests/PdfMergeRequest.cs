using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfMergeRequest
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
    public PdfMergeRequestFormat? Format { get; set; }

    /// <summary>
    /// An array of unique file IDs referencing PDF files previously uploaded to the API Freaks server. Use this parameter to merge existing files without re-uploading them. Provide multiple IDs to merge files in the specified order.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> FileId { get; set; } = new List<string>();

    /// <summary>
    /// If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    /// </summary>
    [JsonIgnore]
    public bool? Destroy { get; set; }

    /// <summary>
    /// Specifies the desired name for the resulting merged PDF file. If not provided, a default name will be assigned.
    /// </summary>
    [JsonIgnore]
    public string? Output { get; set; }

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

    public IEnumerable<FileParameter>? File { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
