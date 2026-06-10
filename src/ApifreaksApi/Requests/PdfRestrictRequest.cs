using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfRestrictRequest
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
    public PdfRestrictRequestFormat? Format { get; set; }

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
    /// The desired name for the output restricted PDF file. If not provided, a default name will be assigned.
    /// </summary>
    [JsonIgnore]
    public string? Output { get; set; }

    /// <summary>
    /// The password to unlock the input file if it is already secured. Provide the owner password if available; otherwise, the user password. The owner password takes precedence. Password Length should be between 6 and 128 characters.
    /// </summary>
    [JsonIgnore]
    public string? FilePassword { get; set; }

    /// <summary>
    /// Sets the password users will use to open the PDF. If this is not set, only the owner password will be configured, and anyone can open the PDF file with the provided restrictions enabled. Password Length should be between 6 and 128 characters.
    /// </summary>
    [JsonIgnore]
    public required string UserPassword { get; set; }

    /// <summary>
    /// Sets the password that allows full access to the PDF (e.g., removing restrictions). If not provided, the `user_password` (if set) will also be used as the owner password. Password Length should be between 6 and 128 characters.
    /// </summary>
    [JsonIgnore]
    public string? OwnerPassword { get; set; }

    /// <summary>
    /// A comma-separated list of restrictions to apply to the PDF. These define what the end-user is *not* allowed to do with the PDF. Available options are:
    ///
    ///
    /// * **print_high** – Disables high-quality printing.
    /// * **print_low** – Disables low-resolution printing.
    /// * **edit_document_assembly** – Prevents reordering or inserting pages.
    /// * **fill_form_fields** – Disallows filling in PDF form fields.
    /// * **edit_annotations** – Disables adding or modifying annotations or comments.
    /// * **modify_content** – Prevents modifying existing content in the PDF.
    /// * **copy_and_extract_content** – Disables copying text or images from the PDF.
    /// * **use_accessibility** – Prevents screen readers or accessibility tools from accessing content.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<PdfRestrictRequestRestrictionsItem> Restrictions { get; set; } =
        new List<PdfRestrictRequestRestrictionsItem>();

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
