using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GetAdminLevelsRequestFormat.GetAdminLevelsRequestFormatSerializer))]
[Serializable]
public readonly record struct GetAdminLevelsRequestFormat : IStringEnum
{
    public static readonly GetAdminLevelsRequestFormat Json = new(Values.Json);

    public static readonly GetAdminLevelsRequestFormat Xml = new(Values.Xml);

    public GetAdminLevelsRequestFormat(string value)
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
    public static GetAdminLevelsRequestFormat FromCustom(string value)
    {
        return new GetAdminLevelsRequestFormat(value);
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

    public static bool operator ==(GetAdminLevelsRequestFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetAdminLevelsRequestFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetAdminLevelsRequestFormat value) => value.Value;

    public static explicit operator GetAdminLevelsRequestFormat(string value) => new(value);

    internal class GetAdminLevelsRequestFormatSerializer
        : JsonConverter<GetAdminLevelsRequestFormat>
    {
        public override GetAdminLevelsRequestFormat Read(
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
            return new GetAdminLevelsRequestFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GetAdminLevelsRequestFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GetAdminLevelsRequestFormat ReadAsPropertyName(
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
            return new GetAdminLevelsRequestFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GetAdminLevelsRequestFormat value,
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
