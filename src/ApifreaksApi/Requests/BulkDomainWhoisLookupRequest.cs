using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkDomainWhoisLookupRequest
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
    public BulkDomainWhoisLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// A list of domain names for which WHOIS data is requested.
    /// </summary>
    [JsonPropertyName("domainNames")]
    public IEnumerable<string> DomainNames { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
