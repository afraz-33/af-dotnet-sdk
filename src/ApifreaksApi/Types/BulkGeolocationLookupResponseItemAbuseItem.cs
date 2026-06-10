using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record BulkGeolocationLookupResponseItemAbuseItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The IP range of the abuse contact
    /// </summary>
    [JsonPropertyName("route")]
    public string? Route { get; set; }

    /// <summary>
    /// The country code of the abuse contact
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// The handle of the abuse contact
    /// </summary>
    [JsonPropertyName("handle")]
    public string? Handle { get; set; }

    /// <summary>
    /// The name of the abuse contact
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The organization of the abuse contact
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// The role of the abuse contact
    /// </summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>
    /// The kind of the abuse contact
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>
    /// The address of the abuse contact
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// The list of email addresses of the abuse contact
    /// </summary>
    [JsonPropertyName("emails")]
    public IEnumerable<string>? Emails { get; set; }

    /// <summary>
    /// The list of phone numbers of the abuse contact
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public IEnumerable<string>? PhoneNumbers { get; set; }

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
