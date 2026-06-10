using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record SubdomainsLookupRequest
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
    public SubdomainsLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Domain name for availability and suggestions.
    /// </summary>
    [JsonIgnore]
    public required string Domain { get; set; }

    /// <summary>
    /// Filter subdomains seen after this date (format YYYY-MM-DD).
    /// </summary>
    [JsonIgnore]
    public DateOnly? After { get; set; }

    /// <summary>
    /// Filter subdomains seen before this date( format YYYY-MM-DD).
    /// </summary>
    [JsonIgnore]
    public DateOnly? Before { get; set; }

    /// <summary>
    /// Filter subdomains by status (active or inactive).
    /// </summary>
    [JsonIgnore]
    public SubdomainsLookupRequestStatus? Status { get; set; }

    /// <summary>
    /// Page number for paginated results.
    /// </summary>
    [JsonIgnore]
    public string? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
