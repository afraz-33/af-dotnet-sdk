using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainDnsReverseRequest
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
    public DomainDnsReverseRequestFormat? Format { get; set; }

    /// <summary>
    /// The type of reverse DNS lookup to perform. Determines how the value parameter is interpreted:
    /// - A: IPv4 CIDR block
    /// - AAAA: IPv6 CIDR block
    /// - MX: Mail provider domain
    /// - NS: Name server provider hostname
    /// - SOA: SOA record admin domain
    /// - SPF/TXT: Target verification strings
    /// - CNAME: Target hostname
    /// </summary>
    [JsonIgnore]
    public required DomainDnsReverseRequestType Type { get; set; }

    /// <summary>
    /// Provide an IP or CIDR for A/AAAA lookups, or a hostname/selector for MX, NS, SOA, SPF, TXT, and CNAME queries. Wildcard regex patterns are also supported (e.g., mail.google.com, m*.google.com, _spf.g*.com, s*.g*.com).
    /// </summary>
    [JsonIgnore]
    public required string Value { get; set; }

    /// <summary>
    /// Accepts 'true' or 'false'. "true" returns only records that exactly match the input (NS, MX, CNAME, SOA, SPF, TXT). "false" returns all matches (default when omitted).
    /// </summary>
    [JsonIgnore]
    public bool? Exact { get; set; }

    /// <summary>
    /// Page number to paginate through results (defaults to 1).
    /// </summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
