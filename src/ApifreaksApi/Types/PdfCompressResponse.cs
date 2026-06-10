using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfCompressResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Task id of the requested task which can be used to check the task status
    /// </summary>
    [JsonPropertyName("taskId")]
    public required string TaskId { get; set; }

    /// <summary>
    /// File Ids for the input files provided for the task. Not given with destroy param.
    /// </summary>
    [JsonPropertyName("inputIds")]
    public IEnumerable<string>? InputIds { get; set; }

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
