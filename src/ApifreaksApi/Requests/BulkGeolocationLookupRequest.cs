using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupRequest
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
    public BulkGeolocationLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Language of the response.
    /// </summary>
    [JsonIgnore]
    public string? Lang { get; set; }

    /// <summary>
    /// Comma-separated list of fields to include in the response. Can include "geo".
    /// </summary>
    [JsonIgnore]
    public string? Fields { get; set; }

    /// <summary>
    /// Comma-separated list of fields to exclude from the response (except "ip").
    /// </summary>
    [JsonIgnore]
    public string? Excludes { get; set; }

    /// <summary>
    /// Comma-separated list of additional information to include in the response.
    /// </summary>
    [JsonIgnore]
    public string? Include { get; set; }

    /// <summary>
    /// List of IP addresses or hostnames to lookup
    /// </summary>
    [JsonPropertyName("ips")]
    public IEnumerable<string> Ips { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
