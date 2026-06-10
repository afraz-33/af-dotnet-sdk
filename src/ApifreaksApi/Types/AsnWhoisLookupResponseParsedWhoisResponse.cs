using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record AsnWhoisLookupResponseParsedWhoisResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("status")]
    public required bool Status { get; set; }

    [JsonPropertyName("whois_server")]
    public required string WhoisServer { get; set; }

    [JsonPropertyName("aut_nums")]
    public IEnumerable<AsnWhoisLookupResponseParsedWhoisResponseAutNumsItem> AutNums { get; set; } =
        new List<AsnWhoisLookupResponseParsedWhoisResponseAutNumsItem>();

    [JsonPropertyName("organization")]
    public required AsnWhoisLookupResponseParsedWhoisResponseOrganization Organization { get; set; }

    [JsonPropertyName("technical_contacts")]
    public IEnumerable<AsnWhoisLookupResponseParsedWhoisResponseTechnicalContactsItem> TechnicalContacts { get; set; } =
        new List<AsnWhoisLookupResponseParsedWhoisResponseTechnicalContactsItem>();

    [JsonPropertyName("abuse_contacts")]
    public IEnumerable<AsnWhoisLookupResponseParsedWhoisResponseAbuseContactsItem> AbuseContacts { get; set; } =
        new List<AsnWhoisLookupResponseParsedWhoisResponseAbuseContactsItem>();

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
