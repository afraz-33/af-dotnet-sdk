using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ZipcodeSearchByRegionResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Total number of ZIP/postal codes found
    /// </summary>
    [JsonPropertyName("total_results")]
    public int? TotalResults { get; set; }

    /// <summary>
    /// Total number of pages available
    /// </summary>
    [JsonPropertyName("total_pages")]
    public int? TotalPages { get; set; }

    /// <summary>
    /// Current page number
    /// </summary>
    [JsonPropertyName("current_page")]
    public int? CurrentPage { get; set; }

    /// <summary>
    /// Number of ZIP/postal codes in the current page
    /// </summary>
    [JsonPropertyName("current_page_size")]
    public int? CurrentPageSize { get; set; }

    /// <summary>
    /// List of ZIP/postal codes
    /// </summary>
    [JsonPropertyName("codes")]
    public IEnumerable<string>? Codes { get; set; }

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
