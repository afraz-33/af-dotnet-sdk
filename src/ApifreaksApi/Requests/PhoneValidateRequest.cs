using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PhoneValidateRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Specifies the desired format for the API response. Choose 'json' for a JSON object. If not provided, the API defaults to JSON format.
    /// </summary>
    [JsonIgnore]
    public PhoneValidateRequestFormat? Format { get; set; }

    /// <summary>
    /// Phone number to validate. Accepts international format (+14155552671), local format (4155552671) with region, or IDD format (0014155552671) with dialer_region.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    /// <summary>
    /// Two-letter ISO country code (e.g., US, GB). Required when number is in local format without + prefix. Cannot be used together with dialer_region.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Two-letter ISO country code indicating the country the number is being dialed from. Required when number uses IDD exit code. Cannot be used together with region.
    /// </summary>
    [JsonPropertyName("dialer_region")]
    public string? DialerRegion { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
