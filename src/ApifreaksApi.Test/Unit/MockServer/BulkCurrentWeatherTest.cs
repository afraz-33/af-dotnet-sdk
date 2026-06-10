using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BulkCurrentWeatherTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "locations": [
                {
                  "location": "lahore"
                },
                {
                  "lat": 32.5,
                  "long": 74.5
                },
                {
                  "ip": "8.8.8.8"
                },
                {
                  "location": "seoul"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "bulk": [
                {
                  "location": {
                    "location_string": "lahore",
                    "country_name": "Pakistan",
                    "state_prov": "Punjab",
                    "city": "Lahore",
                    "locality": "",
                    "latitude": 1.1,
                    "longitude": 1.1,
                    "elevation": 1.1,
                    "timezone": "Asia/Karachi",
                    "timezone_abbreviation": "GMT+5"
                  },
                  "current": {
                    "timestamp": "2025-09-29T17:45:00.000Z",
                    "temperature_2m": 32.3,
                    "relative_humidity_2m": 61,
                    "apparent_temperature": 37.6,
                    "snowfall": 0,
                    "rain": 0,
                    "showers": 0,
                    "precipitation": 0,
                    "weather_code": 1,
                    "cloud_cover": 41,
                    "pressure_msl": 1001.9,
                    "surface_pressure": 978.3,
                    "wind_speed_10m": 4.4,
                    "wind_direction_10m": 279,
                    "wind_gusts_10m": 10.1,
                    "astronomy": {
                      "date": "2025-09-29",
                      "mid_night": "23:53",
                      "night_end": "04:34",
                      "sunrise": "05:53",
                      "solar_noon": "11:52",
                      "sunset": "17:51",
                      "night_begin": "19:11",
                      "day_length": "11:58",
                      "sun_status": "-",
                      "moon_phase": "FIRST_QUARTER",
                      "moonrise": "12:41",
                      "moonset": "22:28",
                      "moon_status": "-"
                    },
                    "air_quality": {
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
                    }
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/weather/current")
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

        var response = await Client.BulkCurrentWeatherAsync(
            new BulkCurrentWeatherRequest
            {
                ApiKey = "apiKey",
                Locations = new List<BulkCurrentWeatherRequestLocationsItem>()
                {
                    new BulkCurrentWeatherRequestLocationsItem { Location = "lahore" },
                    new BulkCurrentWeatherRequestLocationsItem { Lat = 32.5, Long = 74.5 },
                    new BulkCurrentWeatherRequestLocationsItem { Ip = "8.8.8.8" },
                    new BulkCurrentWeatherRequestLocationsItem { Location = "seoul" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
