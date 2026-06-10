using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AirQualityTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "location": {
                "continent_code": "AS",
                "continent_name": "Asia",
                "country_code2": "PK",
                "country_code3": "PAK",
                "country_name": "Pakistan",
                "country_name_official": "Islamic Republic of Pakistan",
                "is_eu": false,
                "state_prov": "Punjab",
                "state_code": "PK-PB",
                "district": "Lahore",
                "city": "Lahore",
                "zipcode": "54000",
                "latitude": 1.1,
                "longitude": 1.1,
                "locality": "Gulberg",
                "elevation": 1.1,
                "timezone": "Asia/Karachi",
                "timezone_abbreviation": "GMT+5"
              },
              "current": {
                "timestamp": "2024-01-15T09:30:00.000Z",
                "european_aqi": 1,
                "us_aqi": 1,
                "pm10": 1.1,
                "pm2_5": 1.1,
                "carbon_monoxide": 1.1,
                "nitrogen_dioxide": 1.1,
                "sulphur_dioxide": 1.1,
                "ozone": 1.1,
                "dust": 1.1,
                "uv_index": 1.1,
                "aerosol_optical_depth": 1.1,
                "uv_index_clear_sky": 1.1
              },
              "forecast": {
                "2025-10-01": {
                  "hourly": [
                    {
                      "timestamp": "2025-10-01T00:00:00.000Z",
                      "pm10": 59,
                      "carbon_monoxide": 1190,
                      "pm2_5": 54.8,
                      "carbon_dioxide": 465,
                      "nitrogen_dioxide": 31.9,
                      "sulphur_dioxide": 15.8,
                      "ozone": 84,
                      "dust": 9,
                      "uv_index": 0,
                      "aerosol_optical_depth": 0.56,
                      "uv_index_clear_sky": 0
                    }
                  ]
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/weather/air-quality")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.AirQualityAsync(new AirQualityRequest { ApiKey = "apiKey" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
