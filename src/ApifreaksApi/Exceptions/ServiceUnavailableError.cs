namespace ApifreaksApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class ServiceUnavailableError(object body)
    : ApifreaksApiApiException("ServiceUnavailableError", 503, body);
