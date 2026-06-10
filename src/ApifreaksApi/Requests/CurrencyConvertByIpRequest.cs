using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyConvertByIpRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response.
    /// </summary>
    [JsonIgnore]
    public CurrencyConvertByIpRequestFormat? Format { get; set; }

    /// <summary>
    /// Exchange rates update period (1d=daily, 1h=hourly, 10m=10 minutes, 1m=1 minute)
    /// </summary>
    [JsonIgnore]
    public CurrencyConvertByIpRequestUpdates? Updates { get; set; }

    /// <summary>
    /// From currency symbol
    /// </summary>
    [JsonIgnore]
    public required string From { get; set; }

    /// <summary>
    /// IPv4 or IPv6 geolocated currency
    /// </summary>
    [JsonIgnore]
    public string? Ip { get; set; }

    /// <summary>
    /// Amount to convert
    /// </summary>
    [JsonIgnore]
    public double? Amount { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
