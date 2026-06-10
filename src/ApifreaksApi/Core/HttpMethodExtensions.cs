using global::System.Net.Http;

namespace ApifreaksApi.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
