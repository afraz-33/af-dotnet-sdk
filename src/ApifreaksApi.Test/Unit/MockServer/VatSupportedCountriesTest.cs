using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatSupportedCountriesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "VAT_Supported_Countries_And_States": [
                {
                  "code": "code",
                  "name": "name",
                  "states": [
                    "states"
                  ]
                },
                {
                  "code": "code",
                  "name": "name",
                  "states": [
                    "states"
                  ]
                },
                {
                  "code": "code",
                  "name": "name",
                  "states": [
                    "states"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/vat/supported-countries")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.VatSupportedCountriesAsync(
            new VatSupportedCountriesRequest { ApiKey = "apiKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
