using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AsnWhoisLookupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "asNumber": "asNumber",
              "asName": "asName",
              "orgName": "orgName",
              "description": "description",
              "orgHandle": "orgHandle",
              "country": "country",
              "domain": "domain",
              "website": "website",
              "allocationStatus": "allocationStatus",
              "numOfIPv4Routes": "numOfIPv4Routes",
              "numOfIPv6Routes": "numOfIPv6Routes",
              "whoisHost": "whoisHost",
              "dateAllocated": "2023-01-15",
              "type": "type",
              "routeObjects": [
                {
                  "route": "route",
                  "origin": "origin",
                  "originName": "originName",
                  "isp": "isp",
                  "numberOfIps": 1
                }
              ],
              "whoisResponse": "whoisResponse",
              "downstreams": [
                {
                  "asNumber": "asNumber",
                  "description": "description",
                  "country": "country"
                }
              ],
              "parsedWhoisResponse": {
                "status": true,
                "whois_server": "whois_server",
                "aut_nums": [
                  {
                    "aut_num": "aut_num",
                    "as_handle": "as_handle",
                    "as_name": "as_name",
                    "tech_contacts": [
                      "tech_contacts"
                    ],
                    "abuse_contacts": [
                      "abuse_contacts"
                    ],
                    "date_created": "2023-01-15",
                    "date_updated": "2023-01-15",
                    "source": "source"
                  }
                ],
                "organization": {
                  "handle": "handle",
                  "name": "name",
                  "address": [
                    "address"
                  ],
                  "street": "street",
                  "city": "city",
                  "state": "state",
                  "zip_code": "zip_code",
                  "country": [
                    "country"
                  ],
                  "addressCountry": "addressCountry",
                  "date_created": "2023-01-15",
                  "date_updated": "2023-01-15",
                  "source": "source"
                },
                "technical_contacts": [
                  {
                    "handle": "handle",
                    "name": "name",
                    "email": [
                      "email"
                    ]
                  }
                ],
                "abuse_contacts": [
                  {
                    "handle": "handle",
                    "name": "name",
                    "email": [
                      "email"
                    ]
                  }
                ]
              },
              "upstreams": [
                {
                  "asNumber": "asNumber",
                  "description": "description",
                  "country": "country"
                }
              ],
              "peers": [
                {
                  "asNumber": "asNumber",
                  "description": "description",
                  "country": "country"
                }
              ],
              "contacts": {
                "emailContacts": [
                  "emailContacts"
                ],
                "abuseContacts": [
                  "abuseContacts"
                ]
              },
              "legacyRoutes": [
                "legacyRoutes"
              ],
              "whois_raw_response": "whois_raw_response",
              "r_whois_raw_response": "r_whois_raw_response",
              "query_time": "query_time"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/asn/whois/live")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("asn", "asn")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.AsnWhoisLookupAsync(
            new AsnWhoisLookupRequest { ApiKey = "apiKey", Asn = "asn" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
