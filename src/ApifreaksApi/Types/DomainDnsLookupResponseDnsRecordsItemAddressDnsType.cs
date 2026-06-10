using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsLookupResponseDnsRecordsItemAddressDnsType.DomainDnsLookupResponseDnsRecordsItemAddressDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsLookupResponseDnsRecordsItemAddressDnsType : IStringEnum
{
    public static readonly DomainDnsLookupResponseDnsRecordsItemAddressDnsType A = new(Values.A);

    public static readonly DomainDnsLookupResponseDnsRecordsItemAddressDnsType Aaaa = new(
        Values.Aaaa
    );

    public DomainDnsLookupResponseDnsRecordsItemAddressDnsType(string value)
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
    public static DomainDnsLookupResponseDnsRecordsItemAddressDnsType FromCustom(string value)
    {
        return new DomainDnsLookupResponseDnsRecordsItemAddressDnsType(value);
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
        DomainDnsLookupResponseDnsRecordsItemAddressDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsLookupResponseDnsRecordsItemAddressDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsLookupResponseDnsRecordsItemAddressDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsLookupResponseDnsRecordsItemAddressDnsType(
        string value
    ) => new(value);

    internal class DomainDnsLookupResponseDnsRecordsItemAddressDnsTypeSerializer
        : JsonConverter<DomainDnsLookupResponseDnsRecordsItemAddressDnsType>
    {
        public override DomainDnsLookupResponseDnsRecordsItemAddressDnsType Read(
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
            return new DomainDnsLookupResponseDnsRecordsItemAddressDnsType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemAddressDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsLookupResponseDnsRecordsItemAddressDnsType ReadAsPropertyName(
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
            return new DomainDnsLookupResponseDnsRecordsItemAddressDnsType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemAddressDnsType value,
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
