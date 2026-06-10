using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkEmailValidateRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response
    /// </summary>
    [JsonIgnore]
    public BulkEmailValidateRequestFormat? Format { get; set; }

    /// <summary>
    /// Array of email objects for bulk validation
    /// </summary>
    [JsonPropertyName("emailData")]
    public IEnumerable<BulkEmailValidateRequestEmailDataItem> EmailData { get; set; } =
        new List<BulkEmailValidateRequestEmailDataItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
