using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfRotateRequest
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
    public PdfRotateRequestFormat? Format { get; set; }

    /// <summary>
    /// The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    /// </summary>
    [JsonIgnore]
    public string? FileId { get; set; }

    /// <summary>
    /// If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    /// </summary>
    [JsonIgnore]
    public bool? Destroy { get; set; }

    /// <summary>
    /// The desired name for the output PDF file after rotation. If not provided, a default name will be assigned.
    /// </summary>
    [JsonIgnore]
    public string? Output { get; set; }

    /// <summary>
    /// Specifies which pages to rotate. Accepts individual page numbers (e.g., '1,7') and/or ascending page ranges (e.g., '3-5'). Use commas to separate entries and hyphens for ranges. Reverse ranges (e.g., '5-3') are not allowed. Alternatively, provide only one of the following keywords: 'even' (rotate all even-numbered pages), 'odd' (rotate all odd-numbered pages), 'last' (rotate only the last page), or 'all' (rotate all pages). Examples: '1,3-5', 'odd', 'all'. Mixing special keywords with specific pages/ranges is not allowed.
    /// </summary>
    [JsonIgnore]
    public string? Pages { get; set; }

    /// <summary>
    /// The angle in degrees to rotate the selected pages. Must be one of the following values: 0, 90, 180, 270, -90, -180, or -270. All rotations are applied clockwise.
    /// </summary>
    [JsonIgnore]
    public required int Rotate { get; set; }

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
