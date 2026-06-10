using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfSplitRequest
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
    public PdfSplitRequestFormat? Format { get; set; }

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
    /// The desired base name for the output PDF files after splitting. If not provided, a default naming convention will be used.
    /// </summary>
    [JsonIgnore]
    public string? Output { get; set; }

    /// <summary>
    /// Defines the page numbers or ranges where the PDF should be split. Provide individual pages and/or ranges in any order (for example: "1-4,9-5,16-last"). Separate entries with commas and use hyphens for ranges.
    ///
    /// Special keywords (use alone):
    ///
    /// • `even` — split at every even-numbered page
    ///
    /// • `odd` — split at every odd-numbered page
    ///
    /// • `all` — split the PDF into single-page files
    ///
    /// The keyword `last` can be used anywhere in the string, in combination with page numbers or ranges (for example: "5-last", "last-2", "1,last,9").
    ///
    /// Examples:
    /// - "1,4-2,last"
    /// - "odd"
    /// - "all"
    /// - "last,2-5"
    ///
    /// Invalid example: "1,odd" (mixing a keyword other than "last" with specific pages/ranges is not allowed). You can pass multiple pages entries to produce multiple output files.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Pages { get; set; } = new List<string>();

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
