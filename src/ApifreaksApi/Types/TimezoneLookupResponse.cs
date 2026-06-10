using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record TimezoneLookupResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("location")]
    public TimezoneLookupResponseLocation? Location { get; set; }

    [JsonPropertyName("time_zone")]
    public required TimezoneLookupResponseTimeZone TimeZone { get; set; }

    [JsonPropertyName("airport_details")]
    public TimezoneLookupResponseAirportDetails? AirportDetails { get; set; }

    [JsonPropertyName("lo_code_details")]
    public TimezoneLookupResponseLoCodeDetails? LoCodeDetails { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
