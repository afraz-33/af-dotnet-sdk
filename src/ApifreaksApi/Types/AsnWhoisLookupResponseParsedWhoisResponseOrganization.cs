using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AsnWhoisLookupResponseParsedWhoisResponseOrganization : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("handle")]
    public string? Handle { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("address")]
    public IEnumerable<string>? Address { get; set; }

    [JsonPropertyName("street")]
    public string? Street { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("country")]
    public IEnumerable<string>? Country { get; set; }

    [JsonPropertyName("addressCountry")]
    public string? AddressCountry { get; set; }

    [JsonPropertyName("date_created")]
    public DateOnly? DateCreated { get; set; }

    [JsonPropertyName("date_updated")]
    public DateOnly? DateUpdated { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

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
