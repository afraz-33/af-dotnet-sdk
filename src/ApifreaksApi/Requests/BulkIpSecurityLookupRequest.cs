using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkIpSecurityLookupRequest
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
    public BulkIpSecurityLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Comma-separated list of fields to return. Supports dot notation (e.g. security.threat_score).
    /// </summary>
    [JsonIgnore]
    public string? Fields { get; set; }

    /// <summary>
    /// Comma-separated list of fields to remove from the response. Supports dot notation (e.g. security.is_tor).
    /// </summary>
    [JsonIgnore]
    public string? Excludes { get; set; }

    /// <summary>
    /// List of IP addresses to lookup
    /// </summary>
    [JsonPropertyName("ips")]
    public IEnumerable<string> Ips { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
