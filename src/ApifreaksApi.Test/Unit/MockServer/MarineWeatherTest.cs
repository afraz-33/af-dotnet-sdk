using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MarineWeatherTest : BaseMockServerTest
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
                "wave_height": 1.1,
                "wave_direction": 1.1,
                "wave_period": 1.1,
                "wind_wave_height": 1.1,
                "wind_wave_direction": 1.1,
                "wind_wave_period": 1.1,
                "swell_wave_height": 1.1,
                "swell_wave_direction": 1.1,
                "swell_wave_period": 1.1,
                "sea_level_height_msl": 1.1,
                "sea_surface_temperature": 1.1,
                "ocean_current_velocity": 1.1,
                "ocean_current_direction": 1.1
              },
              "forecast": {
                "2025-10-01": {
                  "daily": {
                    "timestamp": "2025-10-01T00:00:00.000Z"
                  },
                  "hourly": [
                    {}
                  ],
                  "minutely": [
                    {}
                  ]
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/weather/marine")
                    .WithParam("apiKey", "apiKey")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.MarineWeatherAsync(
            new MarineWeatherRequest { ApiKey = "apiKey" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
