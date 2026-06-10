using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record SwiftCodeFindRequest
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
    public SwiftCodeFindRequestFormat? Format { get; set; }

    /// <summary>
    /// Country name (accepts full name, e.g., Pakistan, United States). If only the country parameter is supplied, lists all banks in the country.
    /// </summary>
    [JsonIgnore]
    public string? Country { get; set; }

    /// <summary>
    /// Bank name (upper case) used to filter SWIFT codes. Should be used together with the country parameter. If only country and bank are provided (without city), returns the list of cities for that bank.
    /// </summary>
    [JsonIgnore]
    public string? Bank { get; set; }

    /// <summary>
    /// Gives SWIFT codes for a bank. Optionally specify the city (upper case) to narrow results to a specific city for that bank.
    /// </summary>
    [JsonIgnore]
    public string? City { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
