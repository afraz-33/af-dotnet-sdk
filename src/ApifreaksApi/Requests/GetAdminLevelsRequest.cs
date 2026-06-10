using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetAdminLevelsRequest
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
    public GetAdminLevelsRequestFormat? Format { get; set; }

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format
    /// </summary>
    [JsonIgnore]
    public required string Country { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
