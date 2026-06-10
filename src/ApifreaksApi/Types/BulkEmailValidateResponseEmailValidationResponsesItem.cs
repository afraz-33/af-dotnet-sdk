using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkEmailValidateResponseEmailValidationResponsesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    [JsonPropertyName("validEmail")]
    public required BulkEmailValidateResponseEmailValidationResponsesItemValidEmail ValidEmail { get; set; }

    [JsonPropertyName("validSyntax")]
    public required bool ValidSyntax { get; set; }

    [JsonPropertyName("domain")]
    public required BulkEmailValidateResponseEmailValidationResponsesItemDomain Domain { get; set; }

    [JsonPropertyName("account")]
    public required BulkEmailValidateResponseEmailValidationResponsesItemAccount Account { get; set; }

    [JsonPropertyName("dns")]
    public required BulkEmailValidateResponseEmailValidationResponsesItemDns Dns { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("address")]
    public BulkEmailValidateResponseEmailValidationResponsesItemAddress? Address { get; set; }

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
