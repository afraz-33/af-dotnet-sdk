namespace ApifreaksApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class LockedError(object body) : ApifreaksApiApiException("LockedError", 423, body);
