using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record IpWhoisLookupResponseOrganization : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("handle")]
    public string? Handle { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("description")]
    public IEnumerable<string>? Description { get; set; }

    [JsonPropertyName("address")]
    public IEnumerable<string>? Address { get; set; }

    [JsonPropertyName("street")]
    public string? Street { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("district")]
    public string? District { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; set; }

    [JsonPropertyName("country")]
    public IEnumerable<string>? Country { get; set; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("email")]
    public IEnumerable<string>? Email { get; set; }

    [JsonPropertyName("abuse_mailbox")]
    public IEnumerable<string>? AbuseMailbox { get; set; }

    [JsonPropertyName("phone")]
    public IEnumerable<string>? Phone { get; set; }

    [JsonPropertyName("fax_no")]
    public IEnumerable<string>? FaxNo { get; set; }

    [JsonPropertyName("organizations")]
    public IEnumerable<string>? Organizations { get; set; }

    [JsonPropertyName("admin_contacts")]
    public IEnumerable<string>? AdminContacts { get; set; }

    [JsonPropertyName("tech_contacts")]
    public IEnumerable<string>? TechContacts { get; set; }

    [JsonPropertyName("abuse_contacts")]
    public IEnumerable<string>? AbuseContacts { get; set; }

    [JsonPropertyName("languages")]
    public IEnumerable<string>? Languages { get; set; }

    [JsonPropertyName("remarks")]
    public IEnumerable<string>? Remarks { get; set; }

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
