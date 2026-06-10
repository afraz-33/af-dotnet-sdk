using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ZipcodeSearchByRegionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "total_results": 130,
              "total_pages": 1,
              "current_page": 1,
              "current_page_size": 130,
              "codes": [
                "36280",
                "53000",
                "53100"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/zipcode/search/region")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("country", "country")
                    .WithParam("region", "region")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.ZipcodeSearchByRegionAsync(
            new ZipcodeSearchByRegionRequest
            {
                ApiKey = "apiKey",
                Country = "country",
                Region = "region",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
