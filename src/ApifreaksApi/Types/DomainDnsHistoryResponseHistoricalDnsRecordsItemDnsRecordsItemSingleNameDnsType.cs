using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType.DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType
    : IStringEnum
{
    public static readonly DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType Ns =
        new(Values.Ns);

    public DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType(
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
    public static DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType(
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
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType(
        string value
    ) => new(value);

    internal class DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsTypeSerializer
        : JsonConverter<DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType>
    {
        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType Read(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType ReadAsPropertyName(
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
            return new DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsHistoryResponseHistoricalDnsRecordsItemDnsRecordsItemSingleNameDnsType value,
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
        public const string Ns = "NS";
    }
}
