using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(SwiftCodeLookupRequestFormat.SwiftCodeLookupRequestFormatSerializer))]
[Serializable]
public readonly record struct SwiftCodeLookupRequestFormat : IStringEnum
{
    public static readonly SwiftCodeLookupRequestFormat Json = new(Values.Json);

    public static readonly SwiftCodeLookupRequestFormat Xml = new(Values.Xml);

    public SwiftCodeLookupRequestFormat(string value)
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
    public static SwiftCodeLookupRequestFormat FromCustom(string value)
    {
        return new SwiftCodeLookupRequestFormat(value);
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

    public static bool operator ==(SwiftCodeLookupRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SwiftCodeLookupRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SwiftCodeLookupRequestFormat value) => value.Value;

    public static explicit operator SwiftCodeLookupRequestFormat(string value) => new(value);

    internal class SwiftCodeLookupRequestFormatSerializer
        : JsonConverter<SwiftCodeLookupRequestFormat>
    {
        public override SwiftCodeLookupRequestFormat Read(
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
            return new SwiftCodeLookupRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SwiftCodeLookupRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SwiftCodeLookupRequestFormat ReadAsPropertyName(
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
            return new SwiftCodeLookupRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SwiftCodeLookupRequestFormat value,
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
