using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record PdfDeleteFileResponse : IJsonOnDeserialized
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
    /// Indicates whether the file deletion request was successful.
    /// </summary>
    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    /// <summary>
    /// A message indicating the result of the file deletion request.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

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
