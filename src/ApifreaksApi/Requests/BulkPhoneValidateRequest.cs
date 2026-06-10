using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkPhoneValidateRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Specifies the desired format for the API response. Choose 'json' for a JSON object. If not provided, the API defaults to JSON format.
    /// </summary>
    [JsonIgnore]
    public BulkPhoneValidateRequestFormat? Format { get; set; }

    /// <summary>
    /// Array of phone number objects. Maximum 100 per request.
    /// </summary>
    [JsonPropertyName("numbers")]
    public IEnumerable<BulkPhoneValidateRequestNumbersItem> Numbers { get; set; } =
        new List<BulkPhoneValidateRequestNumbersItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
