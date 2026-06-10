using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType.DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType
    : IStringEnum
{
    public static readonly DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType A =
        new(Values.A);

    public static readonly DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType Aaaa =
        new(Values.Aaaa);

    public DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType(string value)
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
    public static DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType(value);
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
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType(
        string value
    ) => new(value);

    internal class DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsTypeSerializer
        : JsonConverter<DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType>
    {
        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType Read(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType ReadAsPropertyName(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemAddressDnsType value,
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
