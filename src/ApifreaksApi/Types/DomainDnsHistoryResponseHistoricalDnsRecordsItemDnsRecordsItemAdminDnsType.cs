using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType.DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType
    : IStringEnum
{
    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType Soa =
        new(Values.Soa);

    public DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType(string value)
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
    public static DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType(
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
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType(
        string value
    ) => new(value);

    internal class DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsTypeSerializer
        : JsonConverter<DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType>
    {
        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType Read(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType ReadAsPropertyName(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemAdminDnsType value,
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
        public const string Soa = "SOA";
    }
}
