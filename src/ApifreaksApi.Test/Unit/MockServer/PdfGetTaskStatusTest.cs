using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PdfGetTaskStatusTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "taskId": "taskId",
              "status": "status",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "zipOutputUrl": "zipOutputUrl",
              "zipFileId": "zipFileId",
              "outputUrls": [
                "outputUrls"
              ],
              "outputIds": [
                "outputIds"
              ],
              "inputIds": [
                "inputIds"
              ],
              "error": "error",
              "message": "message",
              "expiresAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/pdf/task-status")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("task_id", "task_id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PdfGetTaskStatusAsync(
            new PdfGetTaskStatusRequest { ApiKey = "apiKey", TaskId = "task_id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
