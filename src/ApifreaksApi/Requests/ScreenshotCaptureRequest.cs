using ApifreaksApi.Core;
using global::System.Text.Json.Serialization;

namespace ApifreaksApi;

[Serializable]
public record ScreenshotCaptureRequest
{
    /// <summary>
    /// Your API key
    /// </summary>
    [JsonIgnore]
    public required string ApiKey { get; set; }

    /// <summary>
    /// Output format for screenshot results
    /// </summary>
    [JsonIgnore]
    public ScreenshotCaptureRequestOutput? Output { get; set; }

    /// <summary>
    /// File type for screenshot output
    /// </summary>
    [JsonIgnore]
    public ScreenshotCaptureRequestFileType? FileType { get; set; }

    /// <summary>
    /// URLs to capture screenshots of
    /// </summary>
    [JsonIgnore]
    public required string Url { get; set; }

    /// <summary>
    /// Browser viewport width in pixels
    /// </summary>
    [JsonIgnore]
    public int? Width { get; set; }

    /// <summary>
    /// Browser viewport height in pixels
    /// </summary>
    [JsonIgnore]
    public int? Height { get; set; }

    /// <summary>
    /// Capture a full-page screenshot
    /// </summary>
    [JsonIgnore]
    public bool? FullPage { get; set; }

    /// <summary>
    /// Bypass cache and take a fresh screenshot
    /// </summary>
    [JsonIgnore]
    public bool? Fresh { get; set; }

    /// <summary>
    /// Remove cookie banners from the screenshot
    /// </summary>
    [JsonIgnore]
    public bool? NoCookieBanners { get; set; }

    /// <summary>
    /// Enable caching for repeated requests
    /// </summary>
    [JsonIgnore]
    public bool? EnableCaching { get; set; }

    /// <summary>
    /// Block advertisements on the page
    /// </summary>
    [JsonIgnore]
    public bool? BlockAds { get; set; }

    /// <summary>
    /// Block chat widget scripts from loading
    /// </summary>
    [JsonIgnore]
    public bool? BlockChatWidgets { get; set; }

    /// <summary>
    /// Extract visible text from the page
    /// </summary>
    [JsonIgnore]
    public bool? ExtractText { get; set; }

    /// <summary>
    /// Extract HTML content of the page
    /// </summary>
    [JsonIgnore]
    public bool? ExtractHtml { get; set; }

    /// <summary>
    /// Auto-destroy screenshot after fetch
    /// </summary>
    [JsonIgnore]
    public bool? DestroyScreenshot { get; set; }

    /// <summary>
    /// Enable lazy-loading content before screenshot
    /// </summary>
    [JsonIgnore]
    public bool? LazyLoad { get; set; }

    /// <summary>
    /// Capture screenshot in high-DPI (Retina) mode
    /// </summary>
    [JsonIgnore]
    public bool? Retina { get; set; }

    /// <summary>
    /// Render page in dark mode
    /// </summary>
    [JsonIgnore]
    public bool? DarkMode { get; set; }

    /// <summary>
    /// Block common user-tracking scripts
    /// </summary>
    [JsonIgnore]
    public bool? BlockTracking { get; set; }

    /// <summary>
    /// Enable private/incognito mode for browser session
    /// </summary>
    [JsonIgnore]
    public bool? EnableIncognito { get; set; }

    /// <summary>
    /// Omit background color (transparent background)
    /// </summary>
    [JsonIgnore]
    public bool? OmitBackground { get; set; }

    /// <summary>
    /// Thumbnail width in pixels
    /// </summary>
    [JsonIgnore]
    public int? ThumbnailWidth { get; set; }

    /// <summary>
    /// Adjust top in pixels
    /// </summary>
    [JsonIgnore]
    public int? AdjustTop { get; set; }

    /// <summary>
    /// Wait for a specific load event before capturing the screenshot.
    /// </summary>
    [JsonIgnore]
    public ScreenshotCaptureRequestWaitForEvent? WaitForEvent { get; set; }

    /// <summary>
    /// Range:0 to 100 for grayscale filter
    /// </summary>
    [JsonIgnore]
    public int? Grayscale { get; set; }

    /// <summary>
    /// How many milliseconds to wait before taking the screenshot
    /// </summary>
    [JsonIgnore]
    public int? Delay { get; set; }

    /// <summary>
    /// Maximum timeout in milliseconds. Defalut is `10,000`
    /// </summary>
    [JsonIgnore]
    public int? Timeout { get; set; }

    /// <summary>
    /// Number of seconds the screenshot should be cached
    /// </summary>
    [JsonIgnore]
    public int? Ttl { get; set; }

    /// <summary>
    /// X position of the clipping rectangle in pixels
    /// </summary>
    [JsonIgnore]
    public int? ClipX { get; set; }

    /// <summary>
    /// Y position of the clipping rectangle in pixels
    /// </summary>
    [JsonIgnore]
    public int? ClipY { get; set; }

    /// <summary>
    /// Width of the clipping rectangle in pixels
    /// </summary>
    [JsonIgnore]
    public int? ClipWidth { get; set; }

    /// <summary>
    /// Height of the clipping rectangle in pixels
    /// </summary>
    [JsonIgnore]
    public int? ClipHeight { get; set; }

    /// <summary>
    /// URL to CSS file
    /// </summary>
    [JsonIgnore]
    public string? CssUrl { get; set; }

    /// <summary>
    /// Your custom CSS code
    /// </summary>
    [JsonIgnore]
    public string? Css { get; set; }

    /// <summary>
    /// URL to JS file
    /// </summary>
    [JsonIgnore]
    public string? JsUrl { get; set; }

    /// <summary>
    /// Your JS code
    /// </summary>
    [JsonIgnore]
    public string? Js { get; set; }

    /// <summary>
    /// Block Scripts
    /// </summary>
    [JsonIgnore]
    public bool? BlockJs { get; set; }

    /// <summary>
    /// Block Stylesheets
    /// </summary>
    [JsonIgnore]
    public bool? BlockStylesheets { get; set; }

    /// <summary>
    /// Block Images
    /// </summary>
    [JsonIgnore]
    public bool? BlockImages { get; set; }

    /// <summary>
    /// Block Media
    /// </summary>
    [JsonIgnore]
    public bool? BlockMedia { get; set; }

    /// <summary>
    /// Block Fonts
    /// </summary>
    [JsonIgnore]
    public bool? BlockFont { get; set; }

    /// <summary>
    /// Block Text Tracks
    /// </summary>
    [JsonIgnore]
    public bool? BlockTextTrack { get; set; }

    /// <summary>
    /// Block XHR Requests
    /// </summary>
    [JsonIgnore]
    public bool? BlockXhr { get; set; }

    /// <summary>
    /// Block Fetch Requests
    /// </summary>
    [JsonIgnore]
    public bool? BlockFetch { get; set; }

    /// <summary>
    /// Block Event Source
    /// </summary>
    [JsonIgnore]
    public bool? BlockEventSource { get; set; }

    /// <summary>
    /// Block Web Sockets
    /// </summary>
    [JsonIgnore]
    public bool? BlockWebSocket { get; set; }

    /// <summary>
    /// Block Manifest
    /// </summary>
    [JsonIgnore]
    public bool? BlockManifest { get; set; }

    /// <summary>
    /// Comma- or newline-separated list of specific requests to block. Each line and comma are treated as separate requests for processing. Example: https://example.com, https://example.js
    /// </summary>
    [JsonIgnore]
    public string? BlockSpecificRequests { get; set; }

    /// <summary>
    /// Comma-separated list of indexed CSS selectors to blur.
    /// Format: `index:&lt;selector&gt;`, e.g., `0:.banner,1:#ads`.
    /// </summary>
    [JsonIgnore]
    public string? BlurSelector { get; set; }

    /// <summary>
    /// Comma-separated list of indexed CSS selectors to blur.
    /// Format: `index:&lt;selector&gt;`, e.g., `0:.banner,1:#ads`.
    /// </summary>
    [JsonIgnore]
    public string? RemoveSelector { get; set; }

    /// <summary>
    /// Specify a meaningful & unique file name to easily identify the screenshot result.
    /// Avoid using spaces or special characters; use hyphens or underscores to separate words.
    /// </summary>
    [JsonIgnore]
    public string? ResultFileName { get; set; }

    /// <summary>
    /// **`Scrolling Screenshot`**: Capture a long scrolling screenshot. When true, disable `fullPage` and `freshScreenshot`.
    /// </summary>
    [JsonIgnore]
    public bool? ScrollingScreenshot { get; set; }

    /// <summary>
    /// Speed of scrolling during the screenshot.
    /// </summary>
    [JsonIgnore]
    public ScreenshotCaptureRequestScrollSpeed? ScrollSpeed { get; set; }

    /// <summary>
    /// If true, the scroll will reverse back to the top after reaching the bottom.
    /// </summary>
    [JsonIgnore]
    public bool? ScrollBack { get; set; }

    /// <summary>
    /// If true, the scrolling capture will start immediately upon page load.
    /// </summary>
    [JsonIgnore]
    public bool? StartImmediately { get; set; }

    /// <summary>
    /// If true, multiple scrolling screenshots will be taken at different viewport sizes.
    /// </summary>
    [JsonIgnore]
    public bool? MultipleScrolling { get; set; }

    /// <summary>
    /// Comma-separated list of viewport sizes in the format index:XXw:YYh. Example: sizes=0:120w:300h,1:240w:500h
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Sizes { get; set; } = new List<string>();

    /// <summary>
    /// Duration in seconds for the scrolling capture. Acceptable range: 0 to 100 seconds.
    /// </summary>
    [JsonIgnore]
    public double? Duration { get; set; }

    [JsonIgnore]
    public bool? FailOnError { get; set; }

    [JsonIgnore]
    public double? Longitude { get; set; }

    [JsonIgnore]
    public double? Latitude { get; set; }

    [JsonIgnore]
    public string? Proxy { get; set; }

    [JsonIgnore]
    public string? Headers { get; set; }

    [JsonIgnore]
    public string? Cookies { get; set; }

    [JsonIgnore]
    public string? ScrollToElement { get; set; }

    [JsonIgnore]
    public string? Selector { get; set; }

    [JsonIgnore]
    public string? UserAgent { get; set; }

    [JsonIgnore]
    public string? AcceptLanguages { get; set; }

    [JsonIgnore]
    public string? CustomHtml { get; set; }

    [JsonIgnore]
    public double? ImageQuality { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
