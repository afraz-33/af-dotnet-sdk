using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IbanValidateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "valid": true,
              "iban": "GB49NWBK08609000000003",
              "validation": {
                "is_alpha_numeric": true,
                "is_iban_supported_country": true,
                "is_valid_length": true,
                "is_valid_structure": true,
                "is_iban_check_digit_valid": true,
                "bban": "valid"
              },
              "bank_data": {
                "bic": "NWBKGB2LBHM",
                "bank": "NATIONAL WESTMINSTER BANK PLC",
                "bank_code": "NWBK",
                "branch_code": "branch_code",
                "country": "United Kingdom",
                "country_iso2": "GB",
                "city": "BIRMINGHAM",
                "address": "6 BRINDLEY PLACE",
                "account": "00000003",
                "sepa": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/iban/validation")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("iban", "iban")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.IbanValidateAsync(
            new IbanValidateRequest { ApiKey = "apiKey", Iban = "iban" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
