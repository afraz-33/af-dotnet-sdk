using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BulkScreenshotCaptureTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "urls": [
                {
                  "url": "url"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "status": "status",
              "meta_data": {
                "total_urls": 1,
                "successful_urls": 1,
                "failed_urls": 1
              },
              "results": [
                {
                  "status": "status",
                  "error_message": "error_message",
                  "url": {
                    "screenshot": "screenshot",
                    "url": "url",
                    "created_at": "created_at",
                    "format": "format",
                    "ttl": "ttl"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/screenshot")
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

        var response = await Client.BulkScreenshotCaptureAsync(
            new BulkScreenshotCaptureRequest
            {
                ApiKey = "apiKey",
                Urls = new List<BulkScreenshotCaptureRequestUrlsItem>()
                {
                    new BulkScreenshotCaptureRequestUrlsItem { Url = "url" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
