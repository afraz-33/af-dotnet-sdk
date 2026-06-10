using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record TimezoneConvertRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response .
    /// </summary>
    [JsonIgnore]
    public TimezoneConvertRequestFormat? Format { get; set; }

    /// <summary>
    /// Time to convert in `yyyy-MM-dd HH:mm` or `yyyy-MM-dd HH:mm:ss` format.
    /// </summary>
    [JsonIgnore]
    public string? Time { get; set; }

    /// <summary>
    /// Source timezone name (e.g., `Asia/Kolkata`).
    /// </summary>
    [JsonIgnore]
    public string? TzFrom { get; set; }

    /// <summary>
    /// Target timezone name (e.g., `America/New_York`).
    /// </summary>
    [JsonIgnore]
    public string? TzTo { get; set; }

    /// <summary>
    /// Latitude of source location.
    /// </summary>
    [JsonIgnore]
    public double? LatFrom { get; set; }

    /// <summary>
    /// Longitude of source location.
    /// </summary>
    [JsonIgnore]
    public double? LongFrom { get; set; }

    /// <summary>
    /// Latitude of target location.
    /// </summary>
    [JsonIgnore]
    public double? LatTo { get; set; }

    /// <summary>
    /// Longitude of target location.
    /// </summary>
    [JsonIgnore]
    public double? LongTo { get; set; }

    /// <summary>
    /// From location (city/country).
    /// </summary>
    [JsonIgnore]
    public string? LocationFrom { get; set; }

    /// <summary>
    /// To location (city/country).
    /// </summary>
    [JsonIgnore]
    public string? LocationTo { get; set; }

    /// <summary>
    /// From IATA airport code (e.g., JFK).
    /// </summary>
    [JsonIgnore]
    public string? IataFrom { get; set; }

    /// <summary>
    /// To IATA airport code.
    /// </summary>
    [JsonIgnore]
    public string? IataTo { get; set; }

    /// <summary>
    /// From ICAO airport code (e.g., KJFK).
    /// </summary>
    [JsonIgnore]
    public string? IcaoFrom { get; set; }

    /// <summary>
    /// To ICAO airport code.
    /// </summary>
    [JsonIgnore]
    public string? IcaoTo { get; set; }

    /// <summary>
    /// From UN/LO CODE.
    /// </summary>
    [JsonIgnore]
    public string? LocodeFrom { get; set; }

    /// <summary>
    /// To UN/LO CODE.
    /// </summary>
    [JsonIgnore]
    public string? LocodeTo { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
