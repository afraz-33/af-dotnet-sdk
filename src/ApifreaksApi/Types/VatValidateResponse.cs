using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record VatValidateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("country_code")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("vat_number")]
    public required string VatNumber { get; set; }

    [JsonPropertyName("requester_country_code")]
    public string? RequesterCountryCode { get; set; }

    [JsonPropertyName("requester_vat_number")]
    public string? RequesterVatNumber { get; set; }

    [JsonPropertyName("requested_at")]
    public required DateTime RequestedAt { get; set; }

    [JsonPropertyName("validation")]
    public required VatValidateResponseValidation Validation { get; set; }

    [JsonPropertyName("company")]
    public required VatValidateResponseCompany Company { get; set; }

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
