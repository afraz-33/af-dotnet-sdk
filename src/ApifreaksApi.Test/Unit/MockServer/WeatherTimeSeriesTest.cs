using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WeatherTimeSeriesTest : BaseMockServerTest
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
              "historical": {
                "2025-08-01": {
                  "daily": {
                    "timestamp": "2025-08-01T00:00:00.000Z",
                    "weather_code": 63,
                    "temperature_2m_mean": 27.3,
                    "temperature_2m_max": 29.8,
                    "temperature_2m_min": 26,
                    "apparent_temperature_mean": 33.6,
                    "apparent_temperature_max": 36,
                    "apparent_temperature_min": 31.9,
                    "precipitation_sum": 17.8,
                    "rain_sum": 17.8,
                    "snowfall_sum": 0,
                    "wind_speed_10m_max": 12.2,
                    "wind_gusts_10m_max": 26.3,
                    "wind_speed_10m_mean": 7.4,
                    "wind_speed_10m_min": 2.2,
                    "wind_gusts_10m_min": 5,
                    "wind_gusts_10m_mean": 16.7,
                    "wind_direction_10m_dominant": 76,
                    "shortwave_radiation_sum": 7.89,
                    "et0_fao_evapotranspiration_sum": 1.75,
                    "cloud_cover_mean": 99,
                    "dew_point_2m_mean": 25.9,
                    "dew_point_2m_max": 26.5,
                    "dew_point_2m_min": 25.1,
                    "relative_humidity_2m_mean": 92,
                    "relative_humidity_2m_max": 97,
                    "relative_humidity_2m_min": 81,
                    "pressure_msl_mean": 999.2,
                    "surface_pressure_mean": 974.6
                  },
                  "hourly": [
                    {}
                  ],
                  "astronomy": {
                    "date": "2025-08-01",
                    "mid_night": "00:09",
                    "night_end": "03:47",
                    "sunrise": "05:17",
                    "solar_noon": "12:08",
                    "sunset": "19:00",
                    "night_begin": "20:30",
                    "day_length": "13:43",
                    "sun_status": "-",
                    "moon_phase": "FIRST_QUARTER",
                    "moonrise": "12:17",
                    "moonset": "23:04",
                    "moon_status": "-"
                  }
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/weather/time-series")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("startDate", "2023-01-15")
                    .WithParam("endDate", "2023-01-15")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.WeatherTimeSeriesAsync(
            new WeatherTimeSeriesRequest
            {
                ApiKey = "apiKey",
                StartDate = new DateOnly(2023, 1, 15),
                EndDate = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
