using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TimezoneConvertTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "original_time": "2024-01-15T09:30:00.000Z",
              "converted_time": "2024-01-15T09:30:00.000Z",
              "diff_hour": 1.1,
              "diff_min": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/timezone/converter")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.TimezoneConvertAsync(
            new TimezoneConvertRequest { ApiKey = "apiKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
