using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AsnWhoisLookupResponseParsedWhoisResponseAutNumsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("aut_num")]
    public required string AutNum { get; set; }

    [JsonPropertyName("as_handle")]
    public required string AsHandle { get; set; }

    [JsonPropertyName("as_name")]
    public required string AsName { get; set; }

    [JsonPropertyName("tech_contacts")]
    public IEnumerable<string> TechContacts { get; set; } = new List<string>();

    [JsonPropertyName("abuse_contacts")]
    public IEnumerable<string> AbuseContacts { get; set; } = new List<string>();

    [JsonPropertyName("date_created")]
    public required DateOnly DateCreated { get; set; }

    [JsonPropertyName("date_updated")]
    public required DateOnly DateUpdated { get; set; }

    [JsonPropertyName("source")]
    public required string Source { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("status")]
    public IEnumerable<string>? Status { get; set; }

    [JsonPropertyName("member_of")]
    public IEnumerable<string>? MemberOf { get; set; }

    [JsonPropertyName("import_via")]
    public IEnumerable<string>? ImportVia { get; set; }

    [JsonPropertyName("import")]
    public IEnumerable<string>? Import { get; set; }

    [JsonPropertyName("mp_import")]
    public IEnumerable<string>? MpImport { get; set; }

    [JsonPropertyName("export_via")]
    public IEnumerable<string>? ExportVia { get; set; }

    [JsonPropertyName("export")]
    public IEnumerable<string>? Export { get; set; }

    [JsonPropertyName("mp_export")]
    public IEnumerable<string>? MpExport { get; set; }

    [JsonPropertyName("default")]
    public IEnumerable<string>? Default { get; set; }

    [JsonPropertyName("mp_default")]
    public IEnumerable<string>? MpDefault { get; set; }

    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    [JsonPropertyName("sponsoring_organization")]
    public string? SponsoringOrganization { get; set; }

    [JsonPropertyName("admin_contacts")]
    public IEnumerable<string>? AdminContacts { get; set; }

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
