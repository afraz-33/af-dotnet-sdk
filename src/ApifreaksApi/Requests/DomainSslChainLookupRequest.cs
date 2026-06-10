using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslChainLookupRequest
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
    public DomainSslChainLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Domain name or URL whose SSL certificate chain lookup is required
    /// </summary>
    [JsonIgnore]
    public required string DomainName { get; set; }

    /// <summary>
    /// Set to true to get the raw openSSL response for each certificate in the chain
    /// </summary>
    [JsonIgnore]
    public bool? SslRaw { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
