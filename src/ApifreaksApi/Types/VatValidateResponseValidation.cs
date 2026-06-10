using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record VatValidateResponseValidation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("is_valid")]
    public required bool IsValid { get; set; }

    /// <summary>
    /// Returned when the upstream authority provides a consultation reference.
    /// </summary>
    [JsonPropertyName("consultation_number")]
    public string? ConsultationNumber { get; set; }

    [JsonPropertyName("consultation_authority")]
    public required string ConsultationAuthority { get; set; }

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
