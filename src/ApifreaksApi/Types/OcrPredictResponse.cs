using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;

namespace ApifreaksApi;

[Serializable]
public record OcrPredictResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Array containing extracted text. Structure varies based on input type and new_line parameter:
    /// - Single file, new_line=0: Array with single string element
    /// - Single file, new_line=1: Array of strings (one per line)
    /// - Bulk/ZIP file, new_line=0: Array of strings (one per file)
    /// - Bulk/ZIP file, new_line=1: Array of arrays (each inner array contains lines for respective file)
    /// </summary>
    [JsonPropertyName("OCRText")]
    public required OneOf<
        IEnumerable<string>,
        IEnumerable<IEnumerable<string>>
    > OcrText { get; set; }

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
