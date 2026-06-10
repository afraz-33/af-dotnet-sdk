using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IpSecurityLookupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "ip": "ip",
              "security": {
                "threat_score": 1.1,
                "is_tor": true,
                "is_proxy": true,
                "proxy_provider_names": [
                  "proxy_provider_names"
                ],
                "proxy_confidence_score": 1.1,
                "proxy_last_seen": "proxy_last_seen",
                "is_residential_proxy": true,
                "is_vpn": true,
                "vpn_provider_names": [
                  "vpn_provider_names"
                ],
                "vpn_confidence_score": 1.1,
                "vpn_last_seen": "vpn_last_seen",
                "is_relay": true,
                "relay_provider_name": "relay_provider_name",
                "is_anonymous": true,
                "is_known_attacker": true,
                "is_bot": true,
                "is_spam": true,
                "is_cloud_provider": true,
                "cloud_provider_name": "cloud_provider_name"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/ip/security")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.IpSecurityLookupAsync(
            new IpSecurityLookupRequest { ApiKey = "apiKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
