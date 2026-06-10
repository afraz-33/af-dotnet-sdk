using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType.DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType
    : IStringEnum
{
    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType A =
        new(Values.A);

    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType Aaaa =
        new(Values.Aaaa);

    public DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType(
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
    public static DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType(
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
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType(
        string value
    ) => new(value);

    internal class DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsTypeSerializer
        : JsonConverter<DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType>
    {
        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType Read(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType ReadAsPropertyName(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAddressDnsType value,
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
        public const string A = "A";

        public const string Aaaa = "AAAA";
    }
}
