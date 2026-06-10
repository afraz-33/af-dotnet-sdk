using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType.DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType
    : IStringEnum
{
    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType Cname =
        new(Values.Cname);

    public DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType(string value)
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
    public static DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType(value);
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
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType(
        string value
    ) => new(value);

    internal class DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsTypeSerializer
        : JsonConverter<DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType>
    {
        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType Read(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType ReadAsPropertyName(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemOneDnsType value,
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
        public const string Cname = "CNAME";
    }
}
