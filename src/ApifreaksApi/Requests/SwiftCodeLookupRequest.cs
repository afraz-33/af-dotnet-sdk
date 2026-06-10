using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record SwiftCodeLookupRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Specify the desired response format. Options: 'json' (default) or 'xml'.
    /// </summary>
    [JsonIgnore]
    public SwiftCodeLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// SWIFT/BIC code to lookup (must be 8 or 11 characters).
    /// </summary>
    [JsonIgnore]
    public required string SwiftCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
