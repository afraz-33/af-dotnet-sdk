using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record VatRateByIpRequest
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
    public VatRateByIpRequestFormat? Format { get; set; }

    /// <summary>
    /// IPv4 or IPv6 address to look up VAT rate for. If omitted, the originating IP address will be used.
    /// </summary>
    [JsonIgnore]
    public string? IpAddress { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
