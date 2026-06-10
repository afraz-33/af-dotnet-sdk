using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(PdfConvertToTiffRequestProfile.PdfConvertToTiffRequestProfileSerializer))]
[Serializable]
public readonly record struct PdfConvertToTiffRequestProfile : IStringEnum
{
    public static readonly PdfConvertToTiffRequestProfile Bw = new(Values.Bw);

    public static readonly PdfConvertToTiffRequestProfile Gray = new(Values.Gray);

    public static readonly PdfConvertToTiffRequestProfile Rgb = new(Values.Rgb);

    public static readonly PdfConvertToTiffRequestProfile Rgba = new(Values.Rgba);

    public static readonly PdfConvertToTiffRequestProfile Cmyk = new(Values.Cmyk);

    public PdfConvertToTiffRequestProfile(string value)
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
    public static PdfConvertToTiffRequestProfile FromCustom(string value)
    {
        return new PdfConvertToTiffRequestProfile(value);
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

    public static bool operator ==(PdfConvertToTiffRequestProfile value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfConvertToTiffRequestProfile value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfConvertToTiffRequestProfile value) => value.Value;

    public static explicit operator PdfConvertToTiffRequestProfile(string value) => new(value);

    internal class PdfConvertToTiffRequestProfileSerializer
        : JsonConverter<PdfConvertToTiffRequestProfile>
    {
        public override PdfConvertToTiffRequestProfile Read(
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
            return new PdfConvertToTiffRequestProfile(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfConvertToTiffRequestProfile value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfConvertToTiffRequestProfile ReadAsPropertyName(
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
            return new PdfConvertToTiffRequestProfile(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfConvertToTiffRequestProfile value,
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

        public const string Cmyk = "cmyk";
    }
}
