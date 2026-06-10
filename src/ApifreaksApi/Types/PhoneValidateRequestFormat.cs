using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PhoneValidateRequestFormat.PhoneValidateRequestFormatSerializer))]
[Serializable]
public readonly record struct PhoneValidateRequestFormat : IStringEnum
{
    public static readonly PhoneValidateRequestFormat Json = new(Values.Json);

    public PhoneValidateRequestFormat(string value)
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
    public static PhoneValidateRequestFormat FromCustom(string value)
    {
        return new PhoneValidateRequestFormat(value);
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

    public static bool operator ==(PhoneValidateRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PhoneValidateRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PhoneValidateRequestFormat value) => value.Value;

    public static explicit operator PhoneValidateRequestFormat(string value) => new(value);

    internal class PhoneValidateRequestFormatSerializer : JsonConverter<PhoneValidateRequestFormat>
    {
        public override PhoneValidateRequestFormat Read(
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
            return new PhoneValidateRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PhoneValidateRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PhoneValidateRequestFormat ReadAsPropertyName(
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
            return new PhoneValidateRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PhoneValidateRequestFormat value,
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
        public const string Json = "json";
    }
}
