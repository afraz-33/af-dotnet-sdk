using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CurrencyTimeSeriesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "startDate": "startDate",
              "endDate": "endDate",
              "base": "base",
              "historicalRatesList": [
                {
                  "date": "date",
                  "rates": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/currency/time-series")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("startDate", "2023-01-15")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CurrencyTimeSeriesAsync(
            new CurrencyTimeSeriesRequest
            {
                ApiKey = "apiKey",
                StartDate = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
