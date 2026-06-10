using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainDnsLookupResponseDnsRecordsItemPriorityDnsType.DomainDnsLookupResponseDnsRecordsItemPriorityDnsTypeSerializer)
)]
[Serializable]
public readonly record struct DomainDnsLookupResponseDnsRecordsItemPriorityDnsType : IStringEnum
{
    public static readonly DomainDnsLookupResponseDnsRecordsItemPriorityDnsType Mx = new(Values.Mx);

    public DomainDnsLookupResponseDnsRecordsItemPriorityDnsType(string value)
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
    public static DomainDnsLookupResponseDnsRecordsItemPriorityDnsType FromCustom(string value)
    {
        return new DomainDnsLookupResponseDnsRecordsItemPriorityDnsType(value);
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
        DomainDnsLookupResponseDnsRecordsItemPriorityDnsType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainDnsLookupResponseDnsRecordsItemPriorityDnsType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DomainDnsLookupResponseDnsRecordsItemPriorityDnsType value
    ) => value.Value;

    public static explicit operator DomainDnsLookupResponseDnsRecordsItemPriorityDnsType(
        string value
    ) => new(value);

    internal class DomainDnsLookupResponseDnsRecordsItemPriorityDnsTypeSerializer
        : JsonConverter<DomainDnsLookupResponseDnsRecordsItemPriorityDnsType>
    {
        public override DomainDnsLookupResponseDnsRecordsItemPriorityDnsType Read(
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
            return new DomainDnsLookupResponseDnsRecordsItemPriorityDnsType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemPriorityDnsType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsLookupResponseDnsRecordsItemPriorityDnsType ReadAsPropertyName(
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
            return new DomainDnsLookupResponseDnsRecordsItemPriorityDnsType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsLookupResponseDnsRecordsItemPriorityDnsType value,
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
        public const string Mx = "MX";
    }
}
