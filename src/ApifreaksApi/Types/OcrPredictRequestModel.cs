using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(OcrPredictRequestModel.OcrPredictRequestModelSerializer))]
[Serializable]
public readonly record struct OcrPredictRequestModel : IStringEnum
{
    public static readonly OcrPredictRequestModel MiniOcrV1 = new(Values.MiniOcrV1);

    public static readonly OcrPredictRequestModel OcrV1 = new(Values.OcrV1);

    public OcrPredictRequestModel(string value)
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
    public static OcrPredictRequestModel FromCustom(string value)
    {
        return new OcrPredictRequestModel(value);
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

    public static bool operator ==(OcrPredictRequestModel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OcrPredictRequestModel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OcrPredictRequestModel value) => value.Value;

    public static explicit operator OcrPredictRequestModel(string value) => new(value);

    internal class OcrPredictRequestModelSerializer : JsonConverter<OcrPredictRequestModel>
    {
        public override OcrPredictRequestModel Read(
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
            return new OcrPredictRequestModel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OcrPredictRequestModel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override OcrPredictRequestModel ReadAsPropertyName(
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
            return new OcrPredictRequestModel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            OcrPredictRequestModel value,
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
        public const string MiniOcrV1 = "mini-ocr-v1";

        public const string OcrV1 = "ocr-v1";
    }
}
