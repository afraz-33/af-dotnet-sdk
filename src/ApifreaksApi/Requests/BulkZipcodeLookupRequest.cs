using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkZipcodeLookupRequest
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
    public BulkZipcodeLookupRequestFormat? Format { get; set; }

    /// <summary>
    /// Comma separated list of postal / zip codes. Max. 100 values.
    /// </summary>
    [JsonPropertyName("codes")]
    public IEnumerable<string> Codes { get; set; } = new List<string>();

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format. If not provided, search results will be returned from all countries.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
