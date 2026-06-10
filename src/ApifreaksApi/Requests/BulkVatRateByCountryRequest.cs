using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkVatRateByCountryRequest
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
    public BulkVatRateByCountryRequestFormat? Format { get; set; }

    [JsonPropertyName("countries")]
    public IEnumerable<BulkVatRateByCountryRequestCountriesItem> Countries { get; set; } =
        new List<BulkVatRateByCountryRequestCountriesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
