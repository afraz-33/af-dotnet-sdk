using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GetFlagsRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonIgnore]
    public required string Name { get; set; }

    /// <summary>
    /// Flag shape. One of: `'flat'` or `'round'`.
    /// </summary>
    [JsonIgnore]
    public required GetFlagsRequestShape Shape { get; set; }

    /// <summary>
    /// Flag format. Applicable only for PNG or WEBP formats. Default is png.
    /// </summary>
    [JsonIgnore]
    public GetFlagsRequestFormat? Format { get; set; }

    /// <summary>
    /// Flag size in pixels. Valid options: `16px`, `24px`, `32px`, `48px`, `64px`. Applicable only for PNG or WEBP formats.
    /// </summary>
    [JsonIgnore]
    public GetFlagsRequestSize? Size { get; set; }

    /// <summary>
    /// Type of flag. One of: `country` or `organization`.
    /// </summary>
    [JsonIgnore]
    public required GetFlagsRequestType Type { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
