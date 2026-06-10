using ApifreaksApi;
using ApifreaksApi.Test.Utils;
using NUnit.Framework;
using OneOf;

namespace ApifreaksApi.Test.Unit.MockServer;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WebScrapeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "blockUrl": [
                "https://example.com/ads.js",
                "https://tracker.example.com/*"
              ],
              "cookies": [
                {
                  "name": "sessionid",
                  "value": "abc123"
                },
                {
                  "name": "user_pref",
                  "value": "darkmode"
                }
              ],
              "instructions": [
                {
                  "fill": {
                    "place": "#username",
                    "value": "myuser"
                  }
                },
                {
                  "fill": {
                    "place": "#password",
                    "value": "mypassword"
                  }
                },
                {
                  "click": "#loginButton"
                },
                {
                  "wait": 2000
                },
                {
                  "extract": {
                    "html": "#profile",
                    "text": "#welcome-message",
                    "user_data": "#user-info"
                  }
                },
                {
                  "blockElement": [
                    ".ad-banner",
                    "//div[@class='popup']"
                  ]
                },
                {
                  "generalImageCaptcha": [
                    {
                      "imagePath": "#captcha-img",
                      "textField": "#captcha-input",
                      "imageUpdatePath": "#refresh-captcha",
                      "captchaFailedPath": "#captcha-error",
                      "model": "mini-ocr-v1"
                    }
                  ]
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "extractedData": {
                "html": "El nombre de dominio: google.sv se encuentra RegistradoNombre de dominio: google.svEstado: RegistradoContacto Administrativo: Cesar Ulises Trujillo MartínezCorreo Electrónico: admin@admindotsv.comTeléfono: 503 2284-8531Fecha Registro: 01-01-2013Fecha de vencimiento: 01-01-2026Fecha de Baja: 01-02-2026"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/scraping")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("url", "https://example.com")
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

        var response = await Client.WebScrapeAsync(
            new WebScrapeRequest
            {
                ApiKey = "apiKey",
                Url = "https://example.com",
                Body = new WebScrapeRequestBodyBlockUrl
                {
                    BlockUrl = new List<string>()
                    {
                        "https://example.com/ads.js",
                        "https://tracker.example.com/*",
                    },
                    Cookies = new List<WebScrapeRequestBodyBlockUrlCookiesItem>()
                    {
                        new WebScrapeRequestBodyBlockUrlCookiesItem
                        {
                            Name = "sessionid",
                            Value = "abc123",
                        },
                        new WebScrapeRequestBodyBlockUrlCookiesItem
                        {
                            Name = "user_pref",
                            Value = "darkmode",
                        },
                    },
                    Instructions = new List<
                        OneOf<
                            WebScrapeRequestBodyBlockUrlInstructionsItemFill,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClick,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClickIfExist,
                            WebScrapeRequestBodyBlockUrlInstructionsItemEnter,
                            WebScrapeRequestBodyBlockUrlInstructionsItemNewTab,
                            WebScrapeRequestBodyBlockUrlInstructionsItemMoveToRelativeTab,
                            WebScrapeRequestBodyBlockUrlInstructionsItemWait,
                            WebScrapeRequestBodyBlockUrlInstructionsItemWaitFor,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSelect,
                            WebScrapeRequestBodyBlockUrlInstructionsItemJsExe,
                            WebScrapeRequestBodyBlockUrlInstructionsItemConditionalCheck,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClickButtonByValue,
                            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemBlockElement,
                            WebScrapeRequestBodyBlockUrlInstructionsItemExtract,
                            WebScrapeRequestBodyBlockUrlInstructionsItemFillImageCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSwitchToIframe,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSwitchToParentFrame,
                            WebScrapeRequestBodyBlockUrlInstructionsItemResolveAudioCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemScreenshot,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSaveimage
                        >
                    >()
                    {
                        new WebScrapeRequestBodyBlockUrlInstructionsItemFill
                        {
                            Fill = new WebScrapeRequestBodyBlockUrlInstructionsItemFillFill
                            {
                                Place = "#username",
                                Value = "myuser",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemFill
                        {
                            Fill = new WebScrapeRequestBodyBlockUrlInstructionsItemFillFill
                            {
                                Place = "#password",
                                Value = "mypassword",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemClick
                        {
                            Click = "#loginButton",
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemWait { Wait = 2000 },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemExtract
                        {
                            Extract = new WebScrapeRequestBodyBlockUrlInstructionsItemExtractExtract
                            {
                                Html = "#profile",
                                Text = "#welcome-message",
                                UserData = "#user-info",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemBlockElement
                        {
                            BlockElement = new List<string>()
                            {
                                ".ad-banner",
                                "//div[@class='popup']",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptcha
                        {
                            GeneralImageCaptcha =
                                new List<WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem>()
                                {
                                    new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem
                                    {
                                        ImagePath = "#captcha-img",
                                        TextField = "#captcha-input",
                                        ImageUpdatePath = "#refresh-captcha",
                                        CaptchaFailedPath = "#captcha-error",
                                        Model =
                                            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel.MiniOcrV1,
                                    },
                                },
                        },
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "instructions": [
                {
                  "postForm": {
                    "selector": "#loginForm"
                  }
                },
                {
                  "extract": {
                    "html": "#main-content",
                    "text": "#welcome-message"
                  }
                },
                {
                  "getForm": {
                    "selector": "#searchForm"
                  }
                },
                {
                  "extract": {
                    "text": "#search-results"
                  }
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "extractedData": {
                "html": "El nombre de dominio: google.sv se encuentra RegistradoNombre de dominio: google.svEstado: RegistradoContacto Administrativo: Cesar Ulises Trujillo MartínezCorreo Electrónico: admin@admindotsv.comTeléfono: 503 2284-8531Fecha Registro: 01-01-2013Fecha de vencimiento: 01-01-2026Fecha de Baja: 01-02-2026"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/scraping")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("url", "https://example.com")
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

        var response = await Client.WebScrapeAsync(
            new WebScrapeRequest
            {
                ApiKey = "apiKey",
                Url = "https://example.com",
                Body = new WebScrapeRequestBodyOne
                {
                    Instructions = new List<
                        OneOf<
                            WebScrapeRequestBodyOneInstructionsItemPostForm,
                            WebScrapeRequestBodyOneInstructionsItemGetForm,
                            WebScrapeRequestBodyOneInstructionsItemExtract,
                            WebScrapeRequestBodyOneInstructionsItemGetPage
                        >
                    >()
                    {
                        new WebScrapeRequestBodyOneInstructionsItemPostForm
                        {
                            PostForm = new WebScrapeRequestBodyOneInstructionsItemPostFormPostForm
                            {
                                Selector = "#loginForm",
                            },
                        },
                        new WebScrapeRequestBodyOneInstructionsItemExtract
                        {
                            Extract = new WebScrapeRequestBodyOneInstructionsItemExtractExtract
                            {
                                Html = "#main-content",
                                Text = "#welcome-message",
                            },
                        },
                        new WebScrapeRequestBodyOneInstructionsItemGetForm
                        {
                            GetForm = new WebScrapeRequestBodyOneInstructionsItemGetFormGetForm
                            {
                                Selector = "#searchForm",
                            },
                        },
                        new WebScrapeRequestBodyOneInstructionsItemExtract
                        {
                            Extract = new WebScrapeRequestBodyOneInstructionsItemExtractExtract
                            {
                                Text = "#search-results",
                            },
                        },
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_3()
    {
        const string requestJson = """
            {
              "blockUrl": [
                "https://example.com/ads.js",
                "https://tracker.example.com/*"
              ],
              "cookies": [
                {
                  "name": "sessionid",
                  "value": "abc123"
                },
                {
                  "name": "user_pref",
                  "value": "darkmode"
                }
              ],
              "instructions": [
                {
                  "fill": {
                    "place": "#username",
                    "value": "myuser"
                  }
                },
                {
                  "fill": {
                    "place": "#password",
                    "value": "mypassword"
                  }
                },
                {
                  "click": "#loginButton"
                },
                {
                  "wait": 2000
                },
                {
                  "extract": {
                    "html": "#profile",
                    "text": "#welcome-message",
                    "user_data": "#user-info"
                  }
                },
                {
                  "blockElement": [
                    ".ad-banner",
                    "//div[@class='popup']"
                  ]
                },
                {
                  "generalImageCaptcha": [
                    {
                      "imagePath": "#captcha-img",
                      "textField": "#captcha-input",
                      "imageUpdatePath": "#refresh-captcha",
                      "captchaFailedPath": "#captcha-error",
                      "model": "mini-ocr-v1"
                    }
                  ]
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "extractedData": {
                "html": "El nombre de dominio: google.sv se encuentra RegistradoNombre de dominio: google.svEstado: RegistradoContacto Administrativo: Cesar Ulises Trujillo MartínezCorreo Electrónico: admin@admindotsv.comTeléfono: 503 2284-8531Fecha Registro: 01-01-2013Fecha de vencimiento: 01-01-2026Fecha de Baja: 01-02-2026"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/scraping")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("url", "https://example.com")
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

        var response = await Client.WebScrapeAsync(
            new WebScrapeRequest
            {
                ApiKey = "apiKey",
                Url = "https://example.com",
                Body = new WebScrapeRequestBodyBlockUrl
                {
                    BlockUrl = new List<string>()
                    {
                        "https://example.com/ads.js",
                        "https://tracker.example.com/*",
                    },
                    Cookies = new List<WebScrapeRequestBodyBlockUrlCookiesItem>()
                    {
                        new WebScrapeRequestBodyBlockUrlCookiesItem
                        {
                            Name = "sessionid",
                            Value = "abc123",
                        },
                        new WebScrapeRequestBodyBlockUrlCookiesItem
                        {
                            Name = "user_pref",
                            Value = "darkmode",
                        },
                    },
                    Instructions = new List<
                        OneOf<
                            WebScrapeRequestBodyBlockUrlInstructionsItemFill,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClick,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClickIfExist,
                            WebScrapeRequestBodyBlockUrlInstructionsItemEnter,
                            WebScrapeRequestBodyBlockUrlInstructionsItemNewTab,
                            WebScrapeRequestBodyBlockUrlInstructionsItemMoveToRelativeTab,
                            WebScrapeRequestBodyBlockUrlInstructionsItemWait,
                            WebScrapeRequestBodyBlockUrlInstructionsItemWaitFor,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSelect,
                            WebScrapeRequestBodyBlockUrlInstructionsItemJsExe,
                            WebScrapeRequestBodyBlockUrlInstructionsItemConditionalCheck,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClickButtonByValue,
                            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemBlockElement,
                            WebScrapeRequestBodyBlockUrlInstructionsItemExtract,
                            WebScrapeRequestBodyBlockUrlInstructionsItemFillImageCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSwitchToIframe,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSwitchToParentFrame,
                            WebScrapeRequestBodyBlockUrlInstructionsItemResolveAudioCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemScreenshot,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSaveimage
                        >
                    >()
                    {
                        new WebScrapeRequestBodyBlockUrlInstructionsItemFill
                        {
                            Fill = new WebScrapeRequestBodyBlockUrlInstructionsItemFillFill
                            {
                                Place = "#username",
                                Value = "myuser",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemFill
                        {
                            Fill = new WebScrapeRequestBodyBlockUrlInstructionsItemFillFill
                            {
                                Place = "#password",
                                Value = "mypassword",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemClick
                        {
                            Click = "#loginButton",
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemWait { Wait = 2000 },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemExtract
                        {
                            Extract = new WebScrapeRequestBodyBlockUrlInstructionsItemExtractExtract
                            {
                                Html = "#profile",
                                Text = "#welcome-message",
                                UserData = "#user-info",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemBlockElement
                        {
                            BlockElement = new List<string>()
                            {
                                ".ad-banner",
                                "//div[@class='popup']",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptcha
                        {
                            GeneralImageCaptcha =
                                new List<WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem>()
                                {
                                    new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem
                                    {
                                        ImagePath = "#captcha-img",
                                        TextField = "#captcha-input",
                                        ImageUpdatePath = "#refresh-captcha",
                                        CaptchaFailedPath = "#captcha-error",
                                        Model =
                                            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel.MiniOcrV1,
                                    },
                                },
                        },
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_4()
    {
        const string requestJson = """
            {
              "blockUrl": [
                "https://example.com/ads.js",
                "https://tracker.example.com/*"
              ],
              "cookies": [
                {
                  "name": "sessionid",
                  "value": "abc123"
                },
                {
                  "name": "user_pref",
                  "value": "darkmode"
                }
              ],
              "instructions": [
                {
                  "fill": {
                    "place": "#username",
                    "value": "myuser"
                  }
                },
                {
                  "fill": {
                    "place": "#password",
                    "value": "mypassword"
                  }
                },
                {
                  "click": "#loginButton"
                },
                {
                  "wait": 2000
                },
                {
                  "extract": {
                    "html": "#profile",
                    "text": "#welcome-message",
                    "user_data": "#user-info"
                  }
                },
                {
                  "blockElement": [
                    ".ad-banner",
                    "//div[@class='popup']"
                  ]
                },
                {
                  "generalImageCaptcha": [
                    {
                      "imagePath": "#captcha-img",
                      "textField": "#captcha-input",
                      "imageUpdatePath": "#refresh-captcha",
                      "captchaFailedPath": "#captcha-error",
                      "model": "mini-ocr-v1"
                    }
                  ]
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "extractedData": {
                "server": [
                  "coleman.ns.cloudflare.com",
                  "nadia.ns.cloudflare.com",
                  "",
                  ""
                ],
                "domain name": "nust.edu.pk",
                "expiry date": "Feb 1, 2026",
                "status": "Domain is Registered"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1.0/scraping")
                    .WithParam("apiKey", "apiKey")
                    .WithParam("url", "https://example.com")
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

        var response = await Client.WebScrapeAsync(
            new WebScrapeRequest
            {
                ApiKey = "apiKey",
                Url = "https://example.com",
                Body = new WebScrapeRequestBodyBlockUrl
                {
                    BlockUrl = new List<string>()
                    {
                        "https://example.com/ads.js",
                        "https://tracker.example.com/*",
                    },
                    Cookies = new List<WebScrapeRequestBodyBlockUrlCookiesItem>()
                    {
                        new WebScrapeRequestBodyBlockUrlCookiesItem
                        {
                            Name = "sessionid",
                            Value = "abc123",
                        },
                        new WebScrapeRequestBodyBlockUrlCookiesItem
                        {
                            Name = "user_pref",
                            Value = "darkmode",
                        },
                    },
                    Instructions = new List<
                        OneOf<
                            WebScrapeRequestBodyBlockUrlInstructionsItemFill,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClick,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClickIfExist,
                            WebScrapeRequestBodyBlockUrlInstructionsItemEnter,
                            WebScrapeRequestBodyBlockUrlInstructionsItemNewTab,
                            WebScrapeRequestBodyBlockUrlInstructionsItemMoveToRelativeTab,
                            WebScrapeRequestBodyBlockUrlInstructionsItemWait,
                            WebScrapeRequestBodyBlockUrlInstructionsItemWaitFor,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSelect,
                            WebScrapeRequestBodyBlockUrlInstructionsItemJsExe,
                            WebScrapeRequestBodyBlockUrlInstructionsItemConditionalCheck,
                            WebScrapeRequestBodyBlockUrlInstructionsItemClickButtonByValue,
                            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemBlockElement,
                            WebScrapeRequestBodyBlockUrlInstructionsItemExtract,
                            WebScrapeRequestBodyBlockUrlInstructionsItemFillImageCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSwitchToIframe,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSwitchToParentFrame,
                            WebScrapeRequestBodyBlockUrlInstructionsItemResolveAudioCaptcha,
                            WebScrapeRequestBodyBlockUrlInstructionsItemScreenshot,
                            WebScrapeRequestBodyBlockUrlInstructionsItemSaveimage
                        >
                    >()
                    {
                        new WebScrapeRequestBodyBlockUrlInstructionsItemFill
                        {
                            Fill = new WebScrapeRequestBodyBlockUrlInstructionsItemFillFill
                            {
                                Place = "#username",
                                Value = "myuser",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemFill
                        {
                            Fill = new WebScrapeRequestBodyBlockUrlInstructionsItemFillFill
                            {
                                Place = "#password",
                                Value = "mypassword",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemClick
                        {
                            Click = "#loginButton",
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemWait { Wait = 2000 },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemExtract
                        {
                            Extract = new WebScrapeRequestBodyBlockUrlInstructionsItemExtractExtract
                            {
                                Html = "#profile",
                                Text = "#welcome-message",
                                UserData = "#user-info",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemBlockElement
                        {
                            BlockElement = new List<string>()
                            {
                                ".ad-banner",
                                "//div[@class='popup']",
                            },
                        },
                        new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptcha
                        {
                            GeneralImageCaptcha =
                                new List<WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem>()
                                {
                                    new WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItem
                                    {
                                        ImagePath = "#captcha-img",
                                        TextField = "#captcha-input",
                                        ImageUpdatePath = "#refresh-captcha",
                                        CaptchaFailedPath = "#captcha-error",
                                        Model =
                                            WebScrapeRequestBodyBlockUrlInstructionsItemGeneralImageCaptchaGeneralImageCaptchaItemModel.MiniOcrV1,
                                    },
                                },
                        },
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
