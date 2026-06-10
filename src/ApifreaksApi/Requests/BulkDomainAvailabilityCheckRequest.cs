using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkDomainAvailabilityCheckRequest
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
    public BulkDomainAvailabilityCheckRequestFormat? Format { get; set; }

    /// <summary>
    /// Specify the data source for domain availability checks. Use "dns" for DNS-based lookups or "whois" for WHOIS-based lookups. By default, "dns" is used.
    /// </summary>
    [JsonIgnore]
    public BulkDomainAvailabilityCheckRequestSource? Source { get; set; }

    /// <summary>
    /// List of domain names to check.
    /// </summary>
    [JsonPropertyName("domainNames")]
    public IEnumerable<string> DomainNames { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
