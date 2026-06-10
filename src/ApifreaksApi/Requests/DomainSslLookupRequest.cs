using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record DomainSslLookupRequest
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
    public DomainSslLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Domain name or URL whose SSL certificate lookup is required
    /// </summary>
    [JsonIgnore]
    public required string DomainName { get; set; }

    /// <summary>
    /// Set to true to get the raw openSSL response of the domain
    /// </summary>
    [JsonIgnore]
    public bool? SslRaw { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
