using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfConvertToGifRequestProfile.PdfConvertToGifRequestProfileSerializer))]
[Serializable]
public readonly record struct PdfConvertToGifRequestProfile : IStringEnum
{
    public static readonly PdfConvertToGifRequestProfile Bw = new(Values.Bw);

    public static readonly PdfConvertToGifRequestProfile Gray = new(Values.Gray);

    public static readonly PdfConvertToGifRequestProfile Rgb = new(Values.Rgb);

    public static readonly PdfConvertToGifRequestProfile Rgba = new(Values.Rgba);

    public static readonly PdfConvertToGifRequestProfile FourBit = new(Values.FourBit);

    public static readonly PdfConvertToGifRequestProfile EightBit = new(Values.EightBit);

    public PdfConvertToGifRequestProfile(string value)
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
    public static PdfConvertToGifRequestProfile FromCustom(string value)
    {
        return new PdfConvertToGifRequestProfile(value);
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

    public static bool operator ==(PdfConvertToGifRequestProfile value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfConvertToGifRequestProfile value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfConvertToGifRequestProfile value) => value.Value;

    public static explicit operator PdfConvertToGifRequestProfile(string value) => new(value);

    internal class PdfConvertToGifRequestProfileSerializer
        : JsonConverter<PdfConvertToGifRequestProfile>
    {
        public override PdfConvertToGifRequestProfile Read(
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
            return new PdfConvertToGifRequestProfile(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfConvertToGifRequestProfile value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfConvertToGifRequestProfile ReadAsPropertyName(
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
            return new PdfConvertToGifRequestProfile(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfConvertToGifRequestProfile value,
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

        public const string Rgba = "rgba";

        public const string FourBit = "4-bit";

        public const string EightBit = "8-bit";
    }
}
