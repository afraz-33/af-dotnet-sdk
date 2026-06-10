using ApifreaksApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[JsonConverter(
    typeof(PdfRestrictRequestRestrictionsItem.PdfRestrictRequestRestrictionsItemSerializer)
)]
[Serializable]
public readonly record struct PdfRestrictRequestRestrictionsItem : IStringEnum
{
    public static readonly PdfRestrictRequestRestrictionsItem PrintHigh = new(Values.PrintHigh);

    public static readonly PdfRestrictRequestRestrictionsItem PrintLow = new(Values.PrintLow);

    public static readonly PdfRestrictRequestRestrictionsItem EditDocumentAssembly = new(
        Values.EditDocumentAssembly
    );

    public static readonly PdfRestrictRequestRestrictionsItem FillFormFields = new(
        Values.FillFormFields
    );

    public static readonly PdfRestrictRequestRestrictionsItem EditAnnotations = new(
        Values.EditAnnotations
    );

    public static readonly PdfRestrictRequestRestrictionsItem ModifyContent = new(
        Values.ModifyContent
    );

    public static readonly PdfRestrictRequestRestrictionsItem CopyAndExtractContent = new(
        Values.CopyAndExtractContent
    );

    public static readonly PdfRestrictRequestRestrictionsItem UseAccessibility = new(
        Values.UseAccessibility
    );

    public PdfRestrictRequestRestrictionsItem(string value)
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
    public static PdfRestrictRequestRestrictionsItem FromCustom(string value)
    {
        return new PdfRestrictRequestRestrictionsItem(value);
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

    public static bool operator ==(PdfRestrictRequestRestrictionsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfRestrictRequestRestrictionsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfRestrictRequestRestrictionsItem value) => value.Value;

    public static explicit operator PdfRestrictRequestRestrictionsItem(string value) => new(value);

    internal class PdfRestrictRequestRestrictionsItemSerializer
        : JsonConverter<PdfRestrictRequestRestrictionsItem>
    {
        public override PdfRestrictRequestRestrictionsItem Read(
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
            return new PdfRestrictRequestRestrictionsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfRestrictRequestRestrictionsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfRestrictRequestRestrictionsItem ReadAsPropertyName(
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
            return new PdfRestrictRequestRestrictionsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfRestrictRequestRestrictionsItem value,
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
        public const string PrintHigh = "print_high";

        public const string PrintLow = "print_low";

        public const string EditDocumentAssembly = "edit_document_assembly";

        public const string FillFormFields = "fill_form_fields";

        public const string EditAnnotations = "edit_annotations";

        public const string ModifyContent = "modify_content";

        public const string CopyAndExtractContent = "copy_and_extract_content";

        public const string UseAccessibility = "use_accessibility";
    }
}
