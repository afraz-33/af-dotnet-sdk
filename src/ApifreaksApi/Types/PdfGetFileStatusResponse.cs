using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfGetFileStatusResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique identifier of the file.
    /// </summary>
    [JsonPropertyName("fileId")]
    public required string FileId { get; set; }

    /// <summary>
    /// The name of the file.
    /// </summary>
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    /// <summary>
    /// The type of the file (e.g., 'pdf').
    /// </summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }

    /// <summary>
    /// The timestamp when the file was created.
    /// </summary>
    [JsonPropertyName("fileCreationTime")]
    public required DateTime FileCreationTime { get; set; }

    /// <summary>
    /// Date on which the file is scheduled to be deleted, in UTC.
    /// </summary>
    [JsonPropertyName("fileDeletionTime")]
    public DateOnly? FileDeletionTime { get; set; }

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
