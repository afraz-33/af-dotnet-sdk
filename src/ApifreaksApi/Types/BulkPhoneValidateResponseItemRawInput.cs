using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

/// <summary>
/// The original request data provided by the client.
/// </summary>
[Serializable]
public record BulkPhoneValidateResponseItemRawInput : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The phone number as entered by the user.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// ISO-2 country code if provided in the request.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// ISO-2 dialing origin country code if provided.
    /// </summary>
    [JsonPropertyName("dialer_region")]
    public string? DialerRegion { get; set; }

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
