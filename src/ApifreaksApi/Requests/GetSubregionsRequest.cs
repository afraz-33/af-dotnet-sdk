using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetSubregionsRequest
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
    public GetSubregionsRequestFormat? Format { get; set; }

    /// <summary>
    /// Name of the region.
    /// </summary>
    [JsonIgnore]
    public required string Region { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
