using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record CurrencyTimeSeriesRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Format of the response.
    /// </summary>
    [JsonIgnore]
    public CurrencyTimeSeriesRequestFormat? Format { get; set; }

    /// <summary>
    /// Start date (format YYYY-MM-DD) of the preferred time frame
    /// </summary>
    [JsonIgnore]
    public required DateOnly StartDate { get; set; }

    /// <summary>
    /// End date (format YYYY-MM-DD) of the preferred time frame
    /// </summary>
    [JsonIgnore]
    public DateOnly? EndDate { get; set; }

    /// <summary>
    /// Base currency
    /// </summary>
    [JsonIgnore]
    public string? Base { get; set; }

    /// <summary>
    /// comma separated list of desired currencies/ commodities symbols
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Symbols { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
