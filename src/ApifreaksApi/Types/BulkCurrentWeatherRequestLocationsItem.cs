using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkCurrentWeatherRequestLocationsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// City name, place name, or full address
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Latitude
    /// </summary>
    [JsonPropertyName("lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// Longitude
    /// </summary>
    [JsonPropertyName("long")]
    public double? Long { get; set; }

    /// <summary>
    /// IP address
    /// </summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

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
