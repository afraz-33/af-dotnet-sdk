using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetSubregionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "subregions": [
                "Eastern Africa",
                "Western Europe",
                "Southern Asia"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/geo/subregions")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("region", "region")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.GetSubregionsAsync(
            new GetSubregionsRequest { ApiKey = "apiKey", Region = "region" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
