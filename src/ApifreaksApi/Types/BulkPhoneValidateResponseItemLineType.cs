using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(BulkPhoneValidateResponseItemLineType.BulkPhoneValidateResponseItemLineTypeSerializer)
)]
[Serializable]
public readonly record struct BulkPhoneValidateResponseItemLineType : IStringEnum
{
    public static readonly BulkPhoneValidateResponseItemLineType Mobile = new(Values.Mobile);

    public static readonly BulkPhoneValidateResponseItemLineType FixedLine = new(Values.FixedLine);

    public static readonly BulkPhoneValidateResponseItemLineType FixedLineOrMobile = new(
        Values.FixedLineOrMobile
    );

    public static readonly BulkPhoneValidateResponseItemLineType Voip = new(Values.Voip);

    public static readonly BulkPhoneValidateResponseItemLineType TollFree = new(Values.TollFree);

    public static readonly BulkPhoneValidateResponseItemLineType PremiumRate = new(
        Values.PremiumRate
    );

    public static readonly BulkPhoneValidateResponseItemLineType SharedCost = new(
        Values.SharedCost
    );

    public static readonly BulkPhoneValidateResponseItemLineType PersonalNumber = new(
        Values.PersonalNumber
    );

    public static readonly BulkPhoneValidateResponseItemLineType Pager = new(Values.Pager);

    public static readonly BulkPhoneValidateResponseItemLineType Uan = new(Values.Uan);

    public static readonly BulkPhoneValidateResponseItemLineType Voicemail = new(Values.Voicemail);

    public static readonly BulkPhoneValidateResponseItemLineType Unknown = new(Values.Unknown);

    public BulkPhoneValidateResponseItemLineType(string value)
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
    public static BulkPhoneValidateResponseItemLineType FromCustom(string value)
    {
        return new BulkPhoneValidateResponseItemLineType(value);
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

    public static bool operator ==(BulkPhoneValidateResponseItemLineType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BulkPhoneValidateResponseItemLineType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BulkPhoneValidateResponseItemLineType value) =>
        value.Value;

    public static explicit operator BulkPhoneValidateResponseItemLineType(string value) =>
        new(value);

    internal class BulkPhoneValidateResponseItemLineTypeSerializer
        : JsonConverter<BulkPhoneValidateResponseItemLineType>
    {
        public override BulkPhoneValidateResponseItemLineType Read(
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
            return new BulkPhoneValidateResponseItemLineType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkPhoneValidateResponseItemLineType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkPhoneValidateResponseItemLineType ReadAsPropertyName(
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
            return new BulkPhoneValidateResponseItemLineType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkPhoneValidateResponseItemLineType value,
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
