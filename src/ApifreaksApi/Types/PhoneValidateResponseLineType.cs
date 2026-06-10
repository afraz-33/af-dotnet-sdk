using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PhoneValidateResponseLineType.PhoneValidateResponseLineTypeSerializer))]
[Serializable]
public readonly record struct PhoneValidateResponseLineType : IStringEnum
{
    public static readonly PhoneValidateResponseLineType Mobile = new(Values.Mobile);

    public static readonly PhoneValidateResponseLineType FixedLine = new(Values.FixedLine);

    public static readonly PhoneValidateResponseLineType FixedLineOrMobile = new(
        Values.FixedLineOrMobile
    );

    public static readonly PhoneValidateResponseLineType Voip = new(Values.Voip);

    public static readonly PhoneValidateResponseLineType TollFree = new(Values.TollFree);

    public static readonly PhoneValidateResponseLineType PremiumRate = new(Values.PremiumRate);

    public static readonly PhoneValidateResponseLineType SharedCost = new(Values.SharedCost);

    public static readonly PhoneValidateResponseLineType PersonalNumber = new(
        Values.PersonalNumber
    );

    public static readonly PhoneValidateResponseLineType Pager = new(Values.Pager);

    public static readonly PhoneValidateResponseLineType Uan = new(Values.Uan);

    public static readonly PhoneValidateResponseLineType Voicemail = new(Values.Voicemail);

    public static readonly PhoneValidateResponseLineType Unknown = new(Values.Unknown);

    public PhoneValidateResponseLineType(string value)
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
    public static PhoneValidateResponseLineType FromCustom(string value)
    {
        return new PhoneValidateResponseLineType(value);
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

    public static bool operator ==(PhoneValidateResponseLineType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PhoneValidateResponseLineType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PhoneValidateResponseLineType value) => value.Value;

    public static explicit operator PhoneValidateResponseLineType(string value) => new(value);

    internal class PhoneValidateResponseLineTypeSerializer
        : JsonConverter<PhoneValidateResponseLineType>
    {
        public override PhoneValidateResponseLineType Read(
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
            return new PhoneValidateResponseLineType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PhoneValidateResponseLineType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PhoneValidateResponseLineType ReadAsPropertyName(
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
            return new PhoneValidateResponseLineType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PhoneValidateResponseLineType value,
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
        public const string Mobile = "MOBILE";

        public const string FixedLine = "FIXED_LINE";

        public const string FixedLineOrMobile = "FIXED_LINE_OR_MOBILE";

        public const string Voip = "VOIP";

        public const string TollFree = "TOLL_FREE";

        public const string PremiumRate = "PREMIUM_RATE";

        public const string SharedCost = "SHARED_COST";

        public const string PersonalNumber = "PERSONAL_NUMBER";

        public const string Pager = "PAGER";

        public const string Uan = "UAN";

        public const string Voicemail = "VOICEMAIL";

        public const string Unknown = "UNKNOWN";
    }
}
