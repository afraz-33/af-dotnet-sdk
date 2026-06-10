using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record IpWhoisLookupRequest
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
    public IpWhoisLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// The IP address (IPv4 or IPv6) for which WHOIS data is requested.
    /// </summary>
    [JsonIgnore]
    public required string Ip { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
