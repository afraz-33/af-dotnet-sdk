using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CurrencyFluctuationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "startDate": "startDate",
              "endDate": "endDate",
              "base": "base",
              "rateFluctuations": {
                "key": {
                  "startRate": "startRate",
                  "endRate": "endRate",
                  "change": "change",
                  "percentChange": "percentChange"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/currency/fluctuation")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("startDate", "2023-01-15")
                    .WithParam("base", "USD")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CurrencyFluctuationAsync(
            new CurrencyFluctuationRequest
            {
                ApiKey = "apiKey",
                StartDate = new DateOnly(2023, 1, 15),
                Base = "USD",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
