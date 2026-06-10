using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetCountriesRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response
    /// </summary>
    [JsonIgnore]
    public GetCountriesRequestFormat? Format { get; set; }

    /// <summary>
    /// Optional filter to return countries within a specific region from the region endpoint.
    /// </summary>
    [JsonIgnore]
    public string? Region { get; set; }

    /// <summary>
    /// Optional filter to return countries within a specific subregion from the subregion endpoint.
    /// </summary>
    [JsonIgnore]
    public string? Subregion { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
