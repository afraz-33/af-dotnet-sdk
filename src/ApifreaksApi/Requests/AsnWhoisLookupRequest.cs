using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AsnWhoisLookupRequest
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
    public AsnWhoisLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// The Autonomous System Number (ASN) to retrieve WHOIS data for. Can be prefixed with 'as' or not.
    /// </summary>
    [JsonIgnore]
    public required string Asn { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
