using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupResponseItemTimeZone : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("offset")]
    public double? Offset { get; set; }

    [JsonPropertyName("offset_with_dst")]
    public double? OffsetWithDst { get; set; }

    [JsonPropertyName("current_time")]
    public string? CurrentTime { get; set; }

    [JsonPropertyName("current_time_unix")]
    public double? CurrentTimeUnix { get; set; }

    [JsonPropertyName("current_tz_abbreviation")]
    public string? CurrentTzAbbreviation { get; set; }

    [JsonPropertyName("current_tz_full_name")]
    public string? CurrentTzFullName { get; set; }

    [JsonPropertyName("standard_tz_abbreviation")]
    public string? StandardTzAbbreviation { get; set; }

    [JsonPropertyName("standard_tz_full_name")]
    public string? StandardTzFullName { get; set; }

    [JsonPropertyName("is_dst")]
    public bool? IsDst { get; set; }

    [JsonPropertyName("dst_savings")]
    public double? DstSavings { get; set; }

    [JsonPropertyName("dst_exists")]
    public bool? DstExists { get; set; }

    [JsonPropertyName("dst_tz_abbreviation")]
    public string? DstTzAbbreviation { get; set; }

    [JsonPropertyName("dst_tz_full_name")]
    public string? DstTzFullName { get; set; }

    [JsonPropertyName("dst_start")]
    public BulkGeolocationLookupResponseItemTimeZoneDstStart? DstStart { get; set; }

    [JsonPropertyName("dst_end")]
    public BulkGeolocationLookupResponseItemTimeZoneDstEnd? DstEnd { get; set; }

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
