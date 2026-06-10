using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainWhoisLookupRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Response format (defaults to json)
    /// </summary>
    [JsonIgnore]
    public DomainWhoisLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Domain name for WHOIS lookup
    /// </summary>
    [JsonIgnore]
    public required string DomainName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
