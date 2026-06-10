using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsLookupResponseDnsRecordsItemOneDnsType.DomainDnsLookupResponseDnsRecordsItemOneDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsLookupResponseDnsRecordsItemOneDnsType : IStringEnum
{
    public static readonly DomainDnsLookupResponseDnsRecordsItemOneDnsType Cname = new(
        Values.Cname
    );

    public DomainDnsLookupResponseDnsRecordsItemOneDnsType(string value)
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
    public static DomainDnsLookupResponseDnsRecordsItemOneDnsType FromCustom(string value)
    {
        return new DomainDnsLookupResponseDnsRecordsItemOneDnsType(value);
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
        DomainDnsLookupResponseDnsRecordsItemOneDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsLookupResponseDnsRecordsItemOneDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DomainDnsLookupResponseDnsRecordsItemOneDnsType value) =>
        value.Value;

    public static explicit operator DomainDnsLookupResponseDnsRecordsItemOneDnsType(string value) =>
        new(value);

    internal class DomainDnsLookupResponseDnsRecordsItemOneDnsTypeSerializer
        : JsonConverter<DomainDnsLookupResponseDnsRecordsItemOneDnsType>
    {
        public override DomainDnsLookupResponseDnsRecordsItemOneDnsType Read(
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
            return new DomainDnsLookupResponseDnsRecordsItemOneDnsType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemOneDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsLookupResponseDnsRecordsItemOneDnsType ReadAsPropertyName(
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
            return new DomainDnsLookupResponseDnsRecordsItemOneDnsType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemOneDnsType value,
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
