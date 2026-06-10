using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType.DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType
    : IStringEnum
{
    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType Txt =
        new(Values.Txt);

    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType Spf =
        new(Values.Spf);

    public DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType(
        string value
    )
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
    public static DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType(
            value
        );
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

    public static bool operator ==(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType(
        string value
    ) => new(value);

    internal class DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsTypeSerializer
        : JsonConverter<DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType>
    {
        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType Read(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType ReadAsPropertyName(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemStringsDnsType value,
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
        public const string Txt = "TXT";

        public const string Spf = "SPF";
    }
}
