namespace ApifreaksApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotAcceptableError(object body)
    : ApifreaksApiApiException("NotAcceptableError", 406, body);
