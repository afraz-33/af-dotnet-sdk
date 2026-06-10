using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(DomainDnsReverseRequestType.DomainDnsReverseRequestTypeSerializer))]
[Serializable]
public readonly record struct DomainDnsReverseRequestType : IStringEnum
{
    public static readonly DomainDnsReverseRequestType A = new(Values.A);

    public static readonly DomainDnsReverseRequestType Aaaa = new(Values.Aaaa);

    public static readonly DomainDnsReverseRequestType Mx = new(Values.Mx);

    public static readonly DomainDnsReverseRequestType Ns = new(Values.Ns);

    public static readonly DomainDnsReverseRequestType Soa = new(Values.Soa);

    public static readonly DomainDnsReverseRequestType Spf = new(Values.Spf);

    public static readonly DomainDnsReverseRequestType Txt = new(Values.Txt);

    public static readonly DomainDnsReverseRequestType Cname = new(Values.Cname);

    public DomainDnsReverseRequestType(string value)
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
    public static DomainDnsReverseRequestType FromCustom(string value)
    {
        return new DomainDnsReverseRequestType(value);
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

    public static bool operator ==(DomainDnsReverseRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DomainDnsReverseRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DomainDnsReverseRequestType value) => value.Value;

    public static explicit operator DomainDnsReverseRequestType(string value) => new(value);

    internal class DomainDnsReverseRequestTypeSerializer
        : JsonConverter<DomainDnsReverseRequestType>
    {
        public override DomainDnsReverseRequestType Read(
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
            return new DomainDnsReverseRequestType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainDnsReverseRequestType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainDnsReverseRequestType ReadAsPropertyName(
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
            return new DomainDnsReverseRequestType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainDnsReverseRequestType value,
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

        public const string Mx = "MX";

        public const string Ns = "NS";

        public const string Soa = "SOA";

        public const string Spf = "SPF";

        public const string Txt = "TXT";

        public const string Cname = "CNAME";
    }
}
