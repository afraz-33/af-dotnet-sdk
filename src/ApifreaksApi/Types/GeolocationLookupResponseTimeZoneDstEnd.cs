using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record GeolocationLookupResponseTimeZoneDstEnd : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("utc_time")]
    public string? UtcTime { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("gap")]
    public bool? Gap { get; set; }

    [JsonPropertyName("date_time_after")]
    public string? DateTimeAfter { get; set; }

    [JsonPropertyName("date_time_before")]
    public string? DateTimeBefore { get; set; }

    [JsonPropertyName("overlap")]
    public bool? Overlap { get; set; }

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
