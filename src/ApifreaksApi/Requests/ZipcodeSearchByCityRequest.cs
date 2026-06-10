using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ZipcodeSearchByCityRequest
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
    public ZipcodeSearchByCityRequestFormat? Format { get; set; }

    /// <summary>
    /// Name of the city in which we want to find zipcodes in.
    /// </summary>
    [JsonIgnore]
    public required string City { get; set; }

    /// <summary>
    /// Country code in ISO 3166-1 alpha-2 format.
    /// </summary>
    [JsonIgnore]
    public required string Country { get; set; }

    /// <summary>
    /// Name of the state or province associated with the country.
    /// </summary>
    [JsonIgnore]
    public string? StateName { get; set; }

    /// <summary>
    /// Page number to retrieve paginated results.
    /// </summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
