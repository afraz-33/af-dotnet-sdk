using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(CommodityLatestRatesRequestUpdates.CommodityLatestRatesRequestUpdatesSerializer)
)]
[Serializable]
public readonly record struct CommodityLatestRatesRequestUpdates : IStringEnum
{
    public static readonly CommodityLatestRatesRequestUpdates TenM = new(Values.TenM);

    public static readonly CommodityLatestRatesRequestUpdates OneM = new(Values.OneM);

    public CommodityLatestRatesRequestUpdates(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static CommodityLatestRatesRequestUpdates FromCustom(string value)
    {
        return new CommodityLatestRatesRequestUpdates(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(CommodityLatestRatesRequestUpdates value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CommodityLatestRatesRequestUpdates value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CommodityLatestRatesRequestUpdates value) => value.Value;

    public static explicit operator CommodityLatestRatesRequestUpdates(string value) => new(value);

    internal class CommodityLatestRatesRequestUpdatesSerializer
        : JsonConverter<CommodityLatestRatesRequestUpdates>
    {
        public override CommodityLatestRatesRequestUpdates Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new CommodityLatestRatesRequestUpdates(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            CommodityLatestRatesRequestUpdates value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override CommodityLatestRatesRequestUpdates ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new CommodityLatestRatesRequestUpdates(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            CommodityLatestRatesRequestUpdates value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string TenM = "10m";

        public const string OneM = "1m";
    }
}
