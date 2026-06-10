using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainWhoisLookupResponseDomainRegistered.DomainWhoisLookupResponseDomainRegisteredSerializer)
)]
[Serializable]
public readonly record struct DomainWhoisLookupResponseDomainRegistered : IStringEnum
{
    public static readonly DomainWhoisLookupResponseDomainRegistered Yes = new(Values.Yes);

    public static readonly DomainWhoisLookupResponseDomainRegistered No = new(Values.No);

    public static readonly DomainWhoisLookupResponseDomainRegistered Restricted = new(
        Values.Restricted
    );

    public DomainWhoisLookupResponseDomainRegistered(string value)
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
    public static DomainWhoisLookupResponseDomainRegistered FromCustom(string value)
    {
        return new DomainWhoisLookupResponseDomainRegistered(value);
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
        DomainWhoisLookupResponseDomainRegistered value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainWhoisLookupResponseDomainRegistered value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DomainWhoisLookupResponseDomainRegistered value) =>
        value.Value;

    public static explicit operator DomainWhoisLookupResponseDomainRegistered(string value) =>
        new(value);

    internal class DomainWhoisLookupResponseDomainRegisteredSerializer
        : JsonConverter<DomainWhoisLookupResponseDomainRegistered>
    {
        public override DomainWhoisLookupResponseDomainRegistered Read(
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
            return new DomainWhoisLookupResponseDomainRegistered(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainWhoisLookupResponseDomainRegistered value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainWhoisLookupResponseDomainRegistered ReadAsPropertyName(
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
            return new DomainWhoisLookupResponseDomainRegistered(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainWhoisLookupResponseDomainRegistered value,
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
        public const string Yes = "yes";

        public const string No = "no";

        public const string Restricted = "restricted";
    }
}
