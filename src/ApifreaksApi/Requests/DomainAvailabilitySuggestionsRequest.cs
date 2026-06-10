using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainAvailabilitySuggestionsRequest
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
    public DomainAvailabilitySuggestionsRequestFormat? Format { get; set; }

    /// <summary>
    /// Domain name for availability and suggestions.
    /// </summary>
    [JsonIgnore]
    public required string Domain { get; set; }

    /// <summary>
    /// Specify the data source for domain availability checks. Use "dns" for DNS-based lookups or "whois" for WHOIS-based lookups. By default, "dns" is used.
    /// </summary>
    [JsonIgnore]
    public DomainAvailabilitySuggestionsRequestSource? Source { get; set; }

    /// <summary>
    /// Number of suggestions to retrieve.
    /// </summary>
    [JsonIgnore]
    public int? Count { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
