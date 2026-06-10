using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainWhoisHistoryRequest
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
    public DomainWhoisHistoryRequestFormat? Format { get; set; }

    /// <summary>
    /// Domain name for historical WHOIS lookup
    /// </summary>
    [JsonIgnore]
    public required string DomainName { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
