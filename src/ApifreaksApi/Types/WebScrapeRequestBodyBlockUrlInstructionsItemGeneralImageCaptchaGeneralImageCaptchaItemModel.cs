using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel.WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModelSerializer)
)]
[Serializable]
public readonly record struct WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel
    : IStringEnum
{
    public static readonly WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel MiniOcrV1 =
        new(Values.MiniOcrV1);

    public static readonly WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel Model20 =
        new(Values.Model20);

    public static readonly WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel Model05 =
        new(Values.Model05);

    public static readonly WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel Model141 =
        new(Values.Model141);

    public static readonly WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel Model150 =
        new(Values.Model150);

    public static readonly WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel Model102 =
        new(Values.Model102);

    public WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel(
        string value
    )
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
    public static WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel FromCustom(
        string value
    )
    {
        return new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel(
            value
        );
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

    public static bool operator ==(
        WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel value
    ) => value.Value;

    public static explicit operator WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel(
        string value
    ) => new(value);

    internal class WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModelSerializer
        : JsonConverter<WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel>
    {
        public override WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel Read(
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
            return new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel ReadAsPropertyName(
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
            return new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel value,
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

        public const string Model20 = "Model20";

        public const string Model05 = "Model05";

        public const string Model141 = "Model141";

        public const string Model150 = "Model150";

        public const string Model102 = "Model102";
    }
}
