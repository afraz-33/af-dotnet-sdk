namespace ApifreaksApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class UnsupportedMediaTypeError(object body)
    : ApifreaksApiApiException("UnsupportedMediaTypeError", 415, body);
