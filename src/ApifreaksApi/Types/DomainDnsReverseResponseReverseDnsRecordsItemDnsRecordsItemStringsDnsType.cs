using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType.DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType
    : IStringEnum
{
    public static readonly DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType Txt =
        new(Values.Txt);

    public static readonly DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType Spf =
        new(Values.Spf);

    public DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType(string value)
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
    public static DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType(value);
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
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType(
        string value
    ) => new(value);

    internal class DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsTypeSerializer
        : JsonConverter<DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType>
    {
        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType Read(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType ReadAsPropertyName(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemStringsDnsType value,
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
