using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetSupportedFlagsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "name": "name",
                "iso2": "iso2",
                "iso3": "iso3"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/flags/supported")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.GetSupportedFlagsAsync(
            new GetSupportedFlagsRequest { ApiKey = "apiKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
