using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record VatValidateRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Specify the desired response format. Options: 'json' (default) or 'xml'.
    /// </summary>
    [JsonIgnore]
    public VatValidateRequestFormat? Format { get; set; }

    /// <summary>
    /// EU or UK VAT number to validate.
    /// </summary>
    [JsonIgnore]
    public required string VatNumber { get; set; }

    /// <summary>
    /// Requester EU or UK VAT number.
    /// </summary>
    [JsonIgnore]
    public string? RequesterVatNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
