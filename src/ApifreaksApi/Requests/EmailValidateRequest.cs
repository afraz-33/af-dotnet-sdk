using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record EmailValidateRequest
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
    public EmailValidateRequestFormat? Format { get; set; }

    /// <summary>
    /// Email address to validate
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// Name of the email address
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// IP address of the email address
    /// </summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
