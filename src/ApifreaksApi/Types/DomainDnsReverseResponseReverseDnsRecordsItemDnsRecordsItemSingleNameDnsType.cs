using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType.DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType
    : IStringEnum
{
    public static readonly DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType Ns =
        new(Values.Ns);

    public DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType(
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
    public static DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType(
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
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType(
        string value
    ) => new(value);

    internal class DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsTypeSerializer
        : JsonConverter<DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType>
    {
        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType Read(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType ReadAsPropertyName(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemSingleNameDnsType value,
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
