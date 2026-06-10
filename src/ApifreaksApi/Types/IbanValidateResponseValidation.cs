using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// Object contains IBAN validation details.
/// </summary>
[Serializable]
public record IbanValidateResponseValidation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Checks if provided IBAN contains only alpha numeric characters
    /// </summary>
    [JsonPropertyName("is_alpha_numeric")]
    public required bool IsAlphaNumeric { get; set; }

    /// <summary>
    /// Checks whether given IBAN country supports IBAN standards
    /// </summary>
    [JsonPropertyName("is_iban_supported_country")]
    public required bool IsIbanSupportedCountry { get; set; }

    /// <summary>
    /// Indicates whether IBAN length is according to respective country standard or not.
    /// </summary>
    [JsonPropertyName("is_valid_length")]
    public required bool IsValidLength { get; set; }

    /// <summary>
    /// Indicates whether IBAN structure is valid as per structure pattern for respective country.
    /// </summary>
    [JsonPropertyName("is_valid_structure")]
    public required bool IsValidStructure { get; set; }

    /// <summary>
    /// Indicates whether IBAN check digit is valid.
    /// </summary>
    [JsonPropertyName("is_iban_check_digit_valid")]
    public required bool IsIbanCheckDigitValid { get; set; }

    /// <summary>
    /// Indicates BBAN checksum is valid or invalid or not supported (unknown) for respective IBAN country.
    /// </summary>
    [JsonPropertyName("bban")]
    public string? Bban { get; set; }

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
