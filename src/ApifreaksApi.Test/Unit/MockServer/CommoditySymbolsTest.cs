using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CommoditySymbolsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "success": true,
              "symbols": [
                {
                  "symbol": "symbol",
                  "name": "name",
                  "category": "category",
                  "status": "status",
                  "updateInterval": "PER_SECOND",
                  "currency": {
                    "code": "code",
                    "name": "name",
                    "symbol": "symbol"
                  },
                  "unit": {
                    "symbol": "symbol",
                    "name": "name"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/commodity/symbols")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.CommoditySymbolsAsync(
            new CommoditySymbolsRequest { ApiKey = "apiKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
