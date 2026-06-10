using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record IbanValidateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Determines whether IBAN passes all validation checks
    /// </summary>
    [JsonPropertyName("valid")]
    public required bool Valid { get; set; }

    /// <summary>
    /// The IBAN number provided by the user.
    /// </summary>
    [JsonPropertyName("iban")]
    public required string Iban { get; set; }

    /// <summary>
    /// Object contains IBAN validation details.
    /// </summary>
    [JsonPropertyName("validation")]
    public required IbanValidateResponseValidation Validation { get; set; }

    /// <summary>
    /// Object contains Bank and BIC details.
    /// </summary>
    [JsonPropertyName("bank_data")]
    public required IbanValidateResponseBankData BankData { get; set; }

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
