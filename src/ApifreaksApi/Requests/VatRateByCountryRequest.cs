using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record VatRateByCountryRequest
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
    public VatRateByCountryRequestFormat? Format { get; set; }

    /// <summary>
    /// Country identifier in Alpha-2 (PK), Alpha-3 (PAK), or full name (Pakistan). Combine with the optional "state" query for sub-national VAT; values are case-insensitive and may use underscores instead of spaces.
    /// </summary>
    [JsonIgnore]
    public required string Country { get; set; }

    /// <summary>
    /// Optional state or region in Alpha-2 (NY) or full name (New_York). Use with "country" for state-level VAT; values are case-insensitive and may use underscores.
    /// </summary>
    [JsonIgnore]
    public string? State { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
