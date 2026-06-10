using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainWhoisReverseRequest
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
    public DomainWhoisReverseRequestFormat? Format { get; set; }

    /// <summary>
    /// Keyword search term for reverse WHOIS by keyword (case-insensitive pattern matching).
    /// </summary>
    [JsonIgnore]
    public string? Keyword { get; set; }

    /// <summary>
    /// Email search term for reverse WHOIS by email address (case-insensitive exact or regex match; * wildcard supported).
    /// </summary>
    [JsonIgnore]
    public string? Email { get; set; }

    /// <summary>
    /// Registrant or owner name for reverse WHOIS (a full-text search phrase matching technique to retrieve results).
    /// </summary>
    [JsonIgnore]
    public string? Owner { get; set; }

    /// <summary>
    /// Organization or company name for reverse WHOIS (full-text search phrase matching technique to retrieve results).
    /// </summary>
    [JsonIgnore]
    public string? Company { get; set; }

    /// <summary>
    /// Accepts 'true' or 'false'. "true" returns only records that exactly match the input (keyword, owner/registrant, or company). "false" returns all matches and is the default when omitted.
    /// </summary>
    [JsonIgnore]
    public bool? Exact { get; set; }

    [JsonIgnore]
    public DomainWhoisReverseRequestMode? Mode { get; set; }

    /// <summary>
    /// Page number for paginated results.
    /// </summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
