using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType.DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType
    : IStringEnum
{
    public static readonly DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType Cname =
        new(Values.Cname);

    public DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType(string value)
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
    public static DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType FromCustom(
        string value
    )
    {
        return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType(value);
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
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType(
        string value
    ) => new(value);

    internal class DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsTypeSerializer
        : JsonConverter<DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType>
    {
        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType Read(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType ReadAsPropertyName(
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
            return new DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsReverseResponseReverseDnsRecordsItemDnsRecordsItemOneDnsType value,
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
