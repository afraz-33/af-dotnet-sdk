using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfConvertToBmpRequestProfile.PdfConvertToBmpRequestProfileSerializer))]
[Serializable]
public readonly record struct PdfConvertToBmpRequestProfile : IStringEnum
{
    public static readonly PdfConvertToBmpRequestProfile Bw = new(Values.Bw);

    public static readonly PdfConvertToBmpRequestProfile Gray = new(Values.Gray);

    public static readonly PdfConvertToBmpRequestProfile Rgb = new(Values.Rgb);

    public static readonly PdfConvertToBmpRequestProfile FourBit = new(Values.FourBit);

    public static readonly PdfConvertToBmpRequestProfile EightBit = new(Values.EightBit);

    public PdfConvertToBmpRequestProfile(string value)
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
    public static PdfConvertToBmpRequestProfile FromCustom(string value)
    {
        return new PdfConvertToBmpRequestProfile(value);
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

    public static bool operator ==(PdfConvertToBmpRequestProfile value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfConvertToBmpRequestProfile value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfConvertToBmpRequestProfile value) => value.Value;

    public static explicit operator PdfConvertToBmpRequestProfile(string value) => new(value);

    internal class PdfConvertToBmpRequestProfileSerializer
        : JsonConverter<PdfConvertToBmpRequestProfile>
    {
        public override PdfConvertToBmpRequestProfile Read(
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
            return new PdfConvertToBmpRequestProfile(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfConvertToBmpRequestProfile value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfConvertToBmpRequestProfile ReadAsPropertyName(
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
            return new PdfConvertToBmpRequestProfile(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfConvertToBmpRequestProfile value,
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
        public const string Bw = "bw";

        public const string Gray = "gray";

        public const string Rgb = "rgb";

        public const string FourBit = "4-bit";

        public const string EightBit = "8-bit";
    }
}
