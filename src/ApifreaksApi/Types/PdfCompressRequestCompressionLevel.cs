using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(PdfCompressRequestCompressionLevel.PdfCompressRequestCompressionLevelSerializer)
)]
[Serializable]
public readonly record struct PdfCompressRequestCompressionLevel : IStringEnum
{
    public static readonly PdfCompressRequestCompressionLevel Low = new(Values.Low);

    public static readonly PdfCompressRequestCompressionLevel Balanced = new(Values.Balanced);

    public static readonly PdfCompressRequestCompressionLevel High = new(Values.High);

    public static readonly PdfCompressRequestCompressionLevel Extreme = new(Values.Extreme);

    public PdfCompressRequestCompressionLevel(string value)
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
    public static PdfCompressRequestCompressionLevel FromCustom(string value)
    {
        return new PdfCompressRequestCompressionLevel(value);
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

    public static bool operator ==(PdfCompressRequestCompressionLevel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfCompressRequestCompressionLevel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfCompressRequestCompressionLevel value) => value.Value;

    public static explicit operator PdfCompressRequestCompressionLevel(string value) => new(value);

    internal class PdfCompressRequestCompressionLevelSerializer
        : JsonConverter<PdfCompressRequestCompressionLevel>
    {
        public override PdfCompressRequestCompressionLevel Read(
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
            return new PdfCompressRequestCompressionLevel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfCompressRequestCompressionLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfCompressRequestCompressionLevel ReadAsPropertyName(
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
            return new PdfCompressRequestCompressionLevel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfCompressRequestCompressionLevel value,
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
        public const string Low = "low";

        public const string Balanced = "balanced";

        public const string High = "high";

        public const string Extreme = "extreme";
    }
}
