using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkPhoneValidateRequestNumbersItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Phone number to validate.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    /// <summary>
    /// Two-letter ISO country code. Required for local format numbers. Cannot be used together with dialer_region.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Two-letter ISO country code of the dialing origin. Required for IDD format numbers. Cannot be used together with region.
    /// </summary>
    [JsonPropertyName("dialer_region")]
    public string? DialerRegion { get; set; }

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
