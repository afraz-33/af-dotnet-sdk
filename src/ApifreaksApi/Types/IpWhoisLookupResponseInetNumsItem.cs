using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record IpWhoisLookupResponseInetNumsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("start_ip")]
    public string? StartIp { get; set; }

    [JsonPropertyName("end_ip")]
    public string? EndIp { get; set; }

    [JsonPropertyName("cidr")]
    public IEnumerable<string>? Cidr { get; set; }

    [JsonPropertyName("net_name")]
    public string? NetName { get; set; }

    [JsonPropertyName("net_handle")]
    public string? NetHandle { get; set; }

    [JsonPropertyName("description")]
    public IEnumerable<string>? Description { get; set; }

    [JsonPropertyName("countries")]
    public IEnumerable<string>? Countries { get; set; }

    [JsonPropertyName("geofeed")]
    public string? Geofeed { get; set; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("languages")]
    public IEnumerable<string>? Languages { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    [JsonPropertyName("sponsoring_organization")]
    public string? SponsoringOrganization { get; set; }

    [JsonPropertyName("admin_contacts")]
    public IEnumerable<string>? AdminContacts { get; set; }

    [JsonPropertyName("tech_contacts")]
    public IEnumerable<string>? TechContacts { get; set; }

    [JsonPropertyName("abuse_contacts")]
    public IEnumerable<string>? AbuseContacts { get; set; }

    [JsonPropertyName("remarks")]
    public IEnumerable<string>? Remarks { get; set; }

    [JsonPropertyName("assignment_size")]
    public string? AssignmentSize { get; set; }

    [JsonPropertyName("notify")]
    public IEnumerable<string>? Notify { get; set; }

    [JsonPropertyName("mnt_by")]
    public IEnumerable<string>? MntBy { get; set; }

    [JsonPropertyName("mnt_lower")]
    public IEnumerable<string>? MntLower { get; set; }

    [JsonPropertyName("mnt_domains")]
    public IEnumerable<string>? MntDomains { get; set; }

    [JsonPropertyName("mnt_routes")]
    public IEnumerable<string>? MntRoutes { get; set; }

    [JsonPropertyName("mnt_irt")]
    public IEnumerable<string>? MntIrt { get; set; }

    [JsonPropertyName("date_created")]
    public string? DateCreated { get; set; }

    [JsonPropertyName("date_updated")]
    public string? DateUpdated { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("parents")]
    public IEnumerable<string>? Parents { get; set; }

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
