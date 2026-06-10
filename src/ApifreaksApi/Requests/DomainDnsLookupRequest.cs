using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainDnsLookupRequest
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
    public DomainDnsLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Hostname or URL whose DNS records are required.
    /// </summary>
    [JsonIgnore]
    public string? HostName { get; set; }

    /// <summary>
    /// The IP address for requested DNS's PTR record. 'type' parameter must be set to 'all'.
    /// </summary>
    [JsonIgnore]
    public string? IpAddress { get; set; }

    /// <summary>
    /// A comma-separated list of DNS record types for lookup. Possible values: A, AAAA, MX, NS, SOA, SPF, TXT, CNAME, or all. When ipAddress is provided, type must be "all".
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Type { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
