using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(typeof(GeolocationLookupRequestLang.GeolocationLookupRequestLangSerializer))]
[Serializable]
public readonly record struct GeolocationLookupRequestLang : IStringEnum
{
    public static readonly GeolocationLookupRequestLang En = new(Values.En);

    public static readonly GeolocationLookupRequestLang De = new(Values.De);

    public static readonly GeolocationLookupRequestLang Ru = new(Values.Ru);

    public static readonly GeolocationLookupRequestLang Ja = new(Values.Ja);

    public static readonly GeolocationLookupRequestLang Fr = new(Values.Fr);

    public static readonly GeolocationLookupRequestLang Cn = new(Values.Cn);

    public static readonly GeolocationLookupRequestLang Es = new(Values.Es);

    public static readonly GeolocationLookupRequestLang Cs = new(Values.Cs);

    public static readonly GeolocationLookupRequestLang It = new(Values.It);

    public GeolocationLookupRequestLang(string value)
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
    public static GeolocationLookupRequestLang FromCustom(string value)
    {
        return new GeolocationLookupRequestLang(value);
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

    public static bool operator ==(GeolocationLookupRequestLang value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GeolocationLookupRequestLang value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GeolocationLookupRequestLang value) => value.Value;

    public static explicit operator GeolocationLookupRequestLang(string value) => new(value);

    internal class GeolocationLookupRequestLangSerializer
        : JsonConverter<GeolocationLookupRequestLang>
    {
        public override GeolocationLookupRequestLang Read(
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
            return new GeolocationLookupRequestLang(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GeolocationLookupRequestLang value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GeolocationLookupRequestLang ReadAsPropertyName(
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
            return new GeolocationLookupRequestLang(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GeolocationLookupRequestLang value,
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
        public const string En = "en";

        public const string De = "de";

        public const string Ru = "ru";

        public const string Ja = "ja";

        public const string Fr = "fr";

        public const string Cn = "cn";

        public const string Es = "es";

        public const string Cs = "cs";

        public const string It = "it";
    }
}
