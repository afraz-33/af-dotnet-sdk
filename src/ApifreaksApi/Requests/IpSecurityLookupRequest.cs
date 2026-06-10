using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record IpSecurityLookupRequest
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
    public IpSecurityLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// A valid IPv4 or IPv6 address to look up. If omitted, the API uses the public IP of the requesting client.
    /// </summary>
    [JsonIgnore]
    public string? Ip { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
