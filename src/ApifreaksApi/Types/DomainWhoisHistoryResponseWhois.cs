using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(DomainWhoisHistoryResponseWhois.DomainWhoisHistoryResponseWhoisSerializer))]
[Serializable]
public readonly record struct DomainWhoisHistoryResponseWhois : IStringEnum
{
    public static readonly DomainWhoisHistoryResponseWhois Historical = new(Values.Historical);

    public DomainWhoisHistoryResponseWhois(string value)
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
    public static DomainWhoisHistoryResponseWhois FromCustom(string value)
    {
        return new DomainWhoisHistoryResponseWhois(value);
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

    public static bool operator ==(DomainWhoisHistoryResponseWhois value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DomainWhoisHistoryResponseWhois value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DomainWhoisHistoryResponseWhois value) => value.Value;

    public static explicit operator DomainWhoisHistoryResponseWhois(string value) => new(value);

    internal class DomainWhoisHistoryResponseWhoisSerializer
        : JsonConverter<DomainWhoisHistoryResponseWhois>
    {
        public override DomainWhoisHistoryResponseWhois Read(
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
            return new DomainWhoisHistoryResponseWhois(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DomainWhoisHistoryResponseWhois value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DomainWhoisHistoryResponseWhois ReadAsPropertyName(
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
            return new DomainWhoisHistoryResponseWhois(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DomainWhoisHistoryResponseWhois value,
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
        public const string Historical = "historical";
    }
}
