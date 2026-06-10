using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(BulkEmailValidateRequestFormat.BulkEmailValidateRequestFormatSerializer))]
[Serializable]
public readonly record struct BulkEmailValidateRequestFormat : IStringEnum
{
    public static readonly BulkEmailValidateRequestFormat Json = new(Values.Json);

    public static readonly BulkEmailValidateRequestFormat Xml = new(Values.Xml);

    public BulkEmailValidateRequestFormat(string value)
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
    public static BulkEmailValidateRequestFormat FromCustom(string value)
    {
        return new BulkEmailValidateRequestFormat(value);
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

    public static bool operator ==(BulkEmailValidateRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BulkEmailValidateRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BulkEmailValidateRequestFormat value) => value.Value;

    public static explicit operator BulkEmailValidateRequestFormat(string value) => new(value);

    internal class BulkEmailValidateRequestFormatSerializer
        : JsonConverter<BulkEmailValidateRequestFormat>
    {
        public override BulkEmailValidateRequestFormat Read(
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
            return new BulkEmailValidateRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BulkEmailValidateRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BulkEmailValidateRequestFormat ReadAsPropertyName(
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
            return new BulkEmailValidateRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BulkEmailValidateRequestFormat value,
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
