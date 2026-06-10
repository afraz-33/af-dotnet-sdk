using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CommodityLatestRatesRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the Response
    /// </summary>
    [JsonIgnore]
    public CommodityLatestRatesRequestFormat? Format { get; set; }

    /// <summary>
    /// Comma separated list of desired commodities symbols *(e.g. XAU,XAG,WTI,BRENT)* **Required**
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Symbols { get; set; } = new List<string>();

    /// <summary>
    /// Exchange rates update period. Possible values are: (1) `10m` - 10 minute update (2) `1m` - 1 minute update **Required**
    /// </summary>
    [JsonIgnore]
    public required CommodityLatestRatesRequestUpdates Updates { get; set; }

    /// <summary>
    /// Specifies the target currency for the exchange rate; default quote currency is the market currency of commodity *(e.g. USD, EUR, INR)*
    /// </summary>
    [JsonIgnore]
    public string? Quote { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
