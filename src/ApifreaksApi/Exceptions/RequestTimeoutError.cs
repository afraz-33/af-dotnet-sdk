namespace ApifreaksApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class RequestTimeoutError(object body)
    : ApifreaksApiApiException("RequestTimeoutError", 408, body);
