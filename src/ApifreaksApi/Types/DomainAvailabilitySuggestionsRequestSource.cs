using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(DomainAvailabilitySuggestionsRequestSource.DomainAvailabilitySuggestionsRequestSourceSerializer)
)]
[Serializable]
public readonly record struct DomainAvailabilitySuggestionsRequestSource : IStringEnum
{
    public static readonly DomainAvailabilitySuggestionsRequestSource Dns = new(Values.Dns);

    public static readonly DomainAvailabilitySuggestionsRequestSource Whois = new(Values.Whois);

    public DomainAvailabilitySuggestionsRequestSource(string value)
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
    public static DomainAvailabilitySuggestionsRequestSource FromCustom(string value)
    {
        return new DomainAvailabilitySuggestionsRequestSource(value);
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
        DomainAvailabilitySuggestionsRequestSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DomainAvailabilitySuggestionsRequestSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DomainAvailabilitySuggestionsRequestSource value) =>
        value.Value;

    public static explicit operator DomainAvailabilitySuggestionsRequestSource(string value) =>
        new(value);

    internal class DomainAvailabilitySuggestionsRequestSourceSerializer
        : JsonConverter<DomainAvailabilitySuggestionsRequestSource>
    {
        public override DomainAvailabilitySuggestionsRequestSource Read(
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
            return new DomainAvailabilitySuggestionsRequestSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainAvailabilitySuggestionsRequestSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainAvailabilitySuggestionsRequestSource ReadAsPropertyName(
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
            return new DomainAvailabilitySuggestionsRequestSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainAvailabilitySuggestionsRequestSource value,
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
        public const string Dns = "dns";

        public const string Whois = "whois";
    }
}
