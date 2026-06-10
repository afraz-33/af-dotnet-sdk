using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DomainSslChainLookupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "domainName": "domainName",
              "queryTime": "2024-01-15T09:30:00.000Z",
              "sslCertificates": [
                {
                  "chainOrder": "chainOrder",
                  "authenticationType": "authenticationType",
                  "validityStartDate": "validityStartDate",
                  "validityEndDate": "validityEndDate",
                  "serialNumber": "serialNumber",
                  "signatureAlgorithm": "signatureAlgorithm",
                  "subject": {
                    "commonName": "commonName"
                  },
                  "issuer": {
                    "commonName": "commonName"
                  },
                  "publicKey": {
                    "keySize": "keySize",
                    "keyAlgorithm": "keyAlgorithm",
                    "pemRaw": "pemRaw"
                  },
                  "extensions": {
                    "authorityKeyIdentifier": "authorityKeyIdentifier",
                    "subjectKeyIdentifier": "subjectKeyIdentifier",
                    "keyUsages": [
                      "keyUsages"
                    ],
                    "extendedKeyUsages": [
                      "extendedKeyUsages"
                    ],
                    "authorityInfoAccess": {
                      "issuers": [
                        "issuers"
                      ],
                      "ocsp": [
                        "ocsp"
                      ]
                    },
                    "certificatePolicies": {
                      "policyId": "policyId"
                    }
                  },
                  "pemRaw": "pemRaw"
                }
              ],
              "sslRaw": "sslRaw"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/domain/ssl/live/chain")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("domainName", "domainName")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DomainSslChainLookupAsync(
            new DomainSslChainLookupRequest { ApiKey = "apiKey", DomainName = "domainName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
