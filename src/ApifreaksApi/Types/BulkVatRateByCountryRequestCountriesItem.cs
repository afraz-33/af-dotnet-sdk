using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkVatRateByCountryRequestCountriesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Country identifier in Alpha-2 (US), Alpha-3 (USA), or full name (United_States). Pair with "state" for regional lookup; values are case-insensitive and may use underscores.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; set; }

    /// <summary>
    /// Optional state identifier in Alpha-2 (NY) or full name (New_York). Use with the country field for state-level VAT; values are case-insensitive and may use underscores.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

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
