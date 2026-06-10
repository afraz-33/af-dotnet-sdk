using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsLookupResponseDnsRecordsItemAdminDnsType.DomainDnsLookupResponseDnsRecordsItemAdminDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsLookupResponseDnsRecordsItemAdminDnsType : IStringEnum
{
    public static readonly DomainDnsLookupResponseDnsRecordsItemAdminDnsType Soa = new(Values.Soa);

    public DomainDnsLookupResponseDnsRecordsItemAdminDnsType(string value)
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
    public static DomainDnsLookupResponseDnsRecordsItemAdminDnsType FromCustom(string value)
    {
        return new DomainDnsLookupResponseDnsRecordsItemAdminDnsType(value);
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
        DomainDnsLookupResponseDnsRecordsItemAdminDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsLookupResponseDnsRecordsItemAdminDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsLookupResponseDnsRecordsItemAdminDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsLookupResponseDnsRecordsItemAdminDnsType(
        string value
    ) => new(value);

    internal class DomainDnsLookupResponseDnsRecordsItemAdminDnsTypeSerializer
        : JsonConverter<DomainDnsLookupResponseDnsRecordsItemAdminDnsType>
    {
        public override DomainDnsLookupResponseDnsRecordsItemAdminDnsType Read(
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
            return new DomainDnsLookupResponseDnsRecordsItemAdminDnsType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemAdminDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsLookupResponseDnsRecordsItemAdminDnsType ReadAsPropertyName(
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
            return new DomainDnsLookupResponseDnsRecordsItemAdminDnsType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemAdminDnsType value,
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
