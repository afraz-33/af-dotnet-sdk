using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BulkZipcodeLookupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "codes": [
                "codes"
              ]
            }
            """;

        const string mockResponse = """
            {
              "results": [
                {
                  "code": "55270",
                  "country_code": "PK",
                  "region": "Punjab",
                  "region_code": "region_code",
                  "city": "Manga Mandi",
                  "locality": "",
                  "latitude": 31.2989,
                  "longitude": 74.07
                },
                {
                  "code": "55270",
                  "country_code": "PK",
                  "region": "Punjab",
                  "region_code": "region_code",
                  "city": "Lahore",
                  "locality": "Manga Mandi",
                  "latitude": 31.303999,
                  "longitude": 74.063995
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/zipcode/lookup")
                    .WithParam("apiKey", "apiKey")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BulkZipcodeLookupAsync(
            new BulkZipcodeLookupRequest
            {
                ApiKey = "apiKey",
                Codes = new List<string>() { "codes" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
