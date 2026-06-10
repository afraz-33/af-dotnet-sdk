namespace ApifreaksApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class PaymentRequiredError(object body)
    : ApifreaksApiApiException("PaymentRequiredError", 402, body);
