using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record VatSupportedCountriesRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response. Default is JSON.
    /// </summary>
    [JsonIgnore]
    public VatSupportedCountriesRequestFormat? Format { get; set; }

    /// <summary>
    /// Type of supported country. Supported values: IBAN, SWIFT, VAT. By default, it returns all supported countries for all types.
    /// </summary>
    [JsonIgnore]
    public VatSupportedCountriesRequestType? Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
