using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IpWhoisLookupTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "status": true,
              "ip_address": "ip_address",
              "query_time": "query_time",
              "whois_server": "whois_server",
              "inet_nums": [
                {
                  "start_ip": "start_ip",
                  "end_ip": "end_ip",
                  "cidr": [
                    "cidr"
                  ],
                  "net_name": "net_name",
                  "net_handle": "net_handle",
                  "description": [
                    "description"
                  ],
                  "countries": [
                    "countries"
                  ],
                  "geofeed": "geofeed",
                  "latitude": 1.1,
                  "longitude": 1.1,
                  "city": "city",
                  "languages": [
                    "languages"
                  ],
                  "status": "status",
                  "organization": "organization",
                  "sponsoring_organization": "sponsoring_organization",
                  "admin_contacts": [
                    "admin_contacts"
                  ],
                  "tech_contacts": [
                    "tech_contacts"
                  ],
                  "abuse_contacts": [
                    "abuse_contacts"
                  ],
                  "remarks": [
                    "remarks"
                  ],
                  "assignment_size": "assignment_size",
                  "notify": [
                    "notify"
                  ],
                  "mnt_by": [
                    "mnt_by"
                  ],
                  "mnt_lower": [
                    "mnt_lower"
                  ],
                  "mnt_domains": [
                    "mnt_domains"
                  ],
                  "mnt_routes": [
                    "mnt_routes"
                  ],
                  "mnt_irt": [
                    "mnt_irt"
                  ],
                  "date_created": "date_created",
                  "date_updated": "date_updated",
                  "source": "source",
                  "parents": [
                    "parents"
                  ]
                }
              ],
              "irt": {
                "handle": "handle",
                "address": [
                  "address"
                ],
                "street": "street",
                "city": "city",
                "district": "district",
                "state": "state",
                "zip_code": "zip_code",
                "country": "country",
                "email": [
                  "email"
                ],
                "abuse_mailbox": [
                  "abuse_mailbox"
                ],
                "phone": [
                  "phone"
                ],
                "fax_no": [
                  "fax_no"
                ],
                "organizations": [
                  "organizations"
                ],
                "admin_contacts": [
                  "admin_contacts"
                ],
                "tech_contacts": [
                  "tech_contacts"
                ],
                "remarks": [
                  "remarks"
                ],
                "signature": [
                  "signature"
                ],
                "encryption": [
                  "encryption"
                ],
                "auth": [
                  "auth"
                ],
                "notify": [
                  "notify"
                ],
                "irt_nfy": [
                  "irt_nfy"
                ],
                "mnt_by": [
                  "mnt_by"
                ],
                "mnt_ref": [
                  "mnt_ref"
                ],
                "date_created": "date_created",
                "date_updated": "date_updated",
                "source": "source"
              },
              "organization": {
                "handle": "handle",
                "name": "name",
                "type": "type",
                "description": [
                  "description"
                ],
                "address": [
                  "address"
                ],
                "street": "street",
                "city": "city",
                "district": "district",
                "state": "state",
                "zip_code": "zip_code",
                "country": [
                  "country"
                ],
                "latitude": 1.1,
                "longitude": 1.1,
                "email": [
                  "email"
                ],
                "abuse_mailbox": [
                  "abuse_mailbox"
                ],
                "phone": [
                  "phone"
                ],
                "fax_no": [
                  "fax_no"
                ],
                "organizations": [
                  "organizations"
                ],
                "admin_contacts": [
                  "admin_contacts"
                ],
                "tech_contacts": [
                  "tech_contacts"
                ],
                "abuse_contacts": [
                  "abuse_contacts"
                ],
                "languages": [
                  "languages"
                ],
                "remarks": [
                  "remarks"
                ]
              },
              "technical_contacts": [
                {
                  "handle": "handle",
                  "name": "name",
                  "email": [
                    "email"
                  ],
                  "phone": [
                    "phone"
                  ],
                  "source": "source"
                }
              ],
              "abuse_contacts": [
                {
                  "handle": "handle",
                  "name": "name",
                  "email": [
                    "email"
                  ],
                  "phone": [
                    "phone"
                  ],
                  "source": "source"
                }
              ],
              "administrative_contacts": [
                {
                  "handle": "handle",
                  "name": "name",
                  "email": [
                    "email"
                  ],
                  "phone": [
                    "phone"
                  ],
                  "source": "source"
                }
              ],
              "whois_raw_response": "whois_raw_response"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/ip/whois/live")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("ip", "ip")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.IpWhoisLookupAsync(
            new IpWhoisLookupRequest { ApiKey = "apiKey", Ip = "ip" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
