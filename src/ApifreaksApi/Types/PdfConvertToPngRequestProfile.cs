using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfConvertToPngRequestProfile.PdfConvertToPngRequestProfileSerializer))]
[Serializable]
public readonly record struct PdfConvertToPngRequestProfile : IStringEnum
{
    public static readonly PdfConvertToPngRequestProfile Bw = new(Values.Bw);

    public static readonly PdfConvertToPngRequestProfile Gray = new(Values.Gray);

    public static readonly PdfConvertToPngRequestProfile Rgb = new(Values.Rgb);

    public static readonly PdfConvertToPngRequestProfile Rgba = new(Values.Rgba);

    public static readonly PdfConvertToPngRequestProfile FourBit = new(Values.FourBit);

    public static readonly PdfConvertToPngRequestProfile EightBit = new(Values.EightBit);

    public PdfConvertToPngRequestProfile(string value)
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
    public static PdfConvertToPngRequestProfile FromCustom(string value)
    {
        return new PdfConvertToPngRequestProfile(value);
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

    public static bool operator ==(PdfConvertToPngRequestProfile value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfConvertToPngRequestProfile value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfConvertToPngRequestProfile value) => value.Value;

    public static explicit operator PdfConvertToPngRequestProfile(string value) => new(value);

    internal class PdfConvertToPngRequestProfileSerializer
        : JsonConverter<PdfConvertToPngRequestProfile>
    {
        public override PdfConvertToPngRequestProfile Read(
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
            return new PdfConvertToPngRequestProfile(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfConvertToPngRequestProfile value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfConvertToPngRequestProfile ReadAsPropertyName(
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
            return new PdfConvertToPngRequestProfile(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfConvertToPngRequestProfile value,
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
