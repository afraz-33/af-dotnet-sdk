using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(EmailValidateResponseValidEmail.EmailValidateResponseValidEmailSerializer))]
[Serializable]
public readonly record struct EmailValidateResponseValidEmail : IStringEnum
{
    public static readonly EmailValidateResponseValidEmail Valid = new(Values.Valid);

    public static readonly EmailValidateResponseValidEmail Invalid = new(Values.Invalid);

    public EmailValidateResponseValidEmail(string value)
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
    public static EmailValidateResponseValidEmail FromCustom(string value)
    {
        return new EmailValidateResponseValidEmail(value);
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

    public static bool operator ==(EmailValidateResponseValidEmail value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmailValidateResponseValidEmail value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmailValidateResponseValidEmail value) => value.Value;

    public static explicit operator EmailValidateResponseValidEmail(string value) => new(value);

    internal class EmailValidateResponseValidEmailSerializer
        : JsonConverter<EmailValidateResponseValidEmail>
    {
        public override EmailValidateResponseValidEmail Read(
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
            return new EmailValidateResponseValidEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EmailValidateResponseValidEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EmailValidateResponseValidEmail ReadAsPropertyName(
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
            return new EmailValidateResponseValidEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EmailValidateResponseValidEmail value,
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
        public const string Valid = "valid";

        public const string Invalid = "invalid";
    }
}
