using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(VatRateByCountryRequestFormat.VatRateByCountryRequestFormatSerializer))]
[Serializable]
public readonly record struct VatRateByCountryRequestFormat : IStringEnum
{
    public static readonly VatRateByCountryRequestFormat Json = new(Values.Json);

    public static readonly VatRateByCountryRequestFormat Xml = new(Values.Xml);

    public VatRateByCountryRequestFormat(string value)
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
    public static VatRateByCountryRequestFormat FromCustom(string value)
    {
        return new VatRateByCountryRequestFormat(value);
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

    public static bool operator ==(VatRateByCountryRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VatRateByCountryRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VatRateByCountryRequestFormat value) => value.Value;

    public static explicit operator VatRateByCountryRequestFormat(string value) => new(value);

    internal class VatRateByCountryRequestFormatSerializer
        : JsonConverter<VatRateByCountryRequestFormat>
    {
        public override VatRateByCountryRequestFormat Read(
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
            return new VatRateByCountryRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VatRateByCountryRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VatRateByCountryRequestFormat ReadAsPropertyName(
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
            return new VatRateByCountryRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VatRateByCountryRequestFormat value,
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

        public const string Xml = "xml";
    }
}
