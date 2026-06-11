# Reference
<details><summary><code>client.GeolocationLookupAsync(request) -&gt; GeolocationLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get detailed geolocation data for an IP address including country, city, timezone, currency, and optional security and user-agent information

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GeolocationLookupRequest
{
    ApiKey = "your_api_key",
    Ip = "8.8.8.8",
};

var response = await client.GeolocationLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GeolocationLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IPv4, IPv6, or hostname for geolocation lookup
    
</dd>
</dl>

<dl>
<dd>

**lang:** `GeolocationLookupRequestLang?` — Response language for location fields
    
</dd>
</dl>

<dl>
<dd>

**fields:** `string?` — Comma separated list of fields to include in response
    
</dd>
</dl>

<dl>
<dd>

**excludes:** `string?` — Comma separated list of fields to exclude from response
    
</dd>
</dl>

<dl>
<dd>

**include:** `string?` — Additional data to include (location, network, security, currency, time_zone, user_agent, country_metadata , hostname, liveHostname, hostnameFallbackLivet)
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkGeolocationLookupAsync(request) -&gt; IEnumerable&lt;BulkGeolocationLookupResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve detailed geolocation data for multiple IP addresses in a single request.<br>Supports up to `50,000` IP-addresses/host-names per request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkGeolocationLookupRequest
{
    ApiKey = "your_api_key",
    Ips = new[] { "8.8.8.8" },
};

var response = await client.BulkGeolocationLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkGeolocationLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**lang:** `string?` — Language of the response.
    
</dd>
</dl>

<dl>
<dd>

**fields:** `string?` — Comma-separated list of fields to include in the response. Can include &quot;geo&quot;.
    
</dd>
</dl>

<dl>
<dd>

**excludes:** `string?` — Comma-separated list of fields to exclude from the response (except &quot;ip&quot;).
    
</dd>
</dl>

<dl>
<dd>

**include:** `string?` — Comma-separated list of additional information to include in the response.
    
</dd>
</dl>

<dl>
<dd>

**ips:** `IEnumerable&lt;string&gt;` — List of IP addresses or hostnames to lookup
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.IpSecurityLookupAsync(request) -&gt; IpSecurityLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get comprehensive security information for a given IP address. Detects VPNs, proxies, Tor nodes, and other security threats.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new IpSecurityLookupRequest
{
    ApiKey = "your_api_key",
    Ip = "8.8.8.8",
};

var response = await client.IpSecurityLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `IpSecurityLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — A valid IPv4 or IPv6 address to look up. If omitted, the API uses the public IP of the requesting client.
    
</dd>
</dl>

<dl>
<dd>

**fields:** `string?` — Comma-separated list of fields to return. Supports dot notation (e.g. security.threat_score).
    
</dd>
</dl>

<dl>
<dd>

**excludes:** `string?` — Comma-separated list of fields to remove from the response. Supports dot notation (e.g. security.is_tor).
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkIpSecurityLookupAsync(request) -&gt; IEnumerable&lt;BulkIpSecurityLookupResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

The Bulk IP Security Lookup API allows you to retrieve security details for up to `50,000` IP-addresses in a single request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkIpSecurityLookupRequest
{
    ApiKey = "your_api_key",
    Ips = new[] { "8.8.8.8" },
};

var response = await client.BulkIpSecurityLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkIpSecurityLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**fields:** `string?` — Comma-separated list of fields to return. Supports dot notation (e.g. security.threat_score).
    
</dd>
</dl>

<dl>
<dd>

**excludes:** `string?` — Comma-separated list of fields to remove from the response. Supports dot notation (e.g. security.is_tor).
    
</dd>
</dl>

<dl>
<dd>

**ips:** `IEnumerable&lt;string&gt;` — List of IP addresses to lookup
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GeocoderSearchAsync(request) -&gt; IEnumerable&lt;GeocoderSearchResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Convert a given address or place name into geographic coordinates (latitude and longitude).

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GeocoderSearchRequest
{
    ApiKey = "your_api_key",
    Query = "Wembley Stadium, London",
};

var response = await client.GeocoderSearchAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GeocoderSearchRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**query:** `string` — Required. — Free-form search query, e.g. Wembley Stadium, London
    
</dd>
</dl>

<dl>
<dd>

**limit:** `int?` — Max number of results to return (1–40). May return fewer if matches are weak.
    
</dd>
</dl>

<dl>
<dd>

**minLat:** `float?` — Minimum latitude for the viewbox. Must be ≤ max_lat and between -90 and 90.
    
</dd>
</dl>

<dl>
<dd>

**maxLat:** `float?` — Maximum latitude for the viewbox. Must be ≥ min_lat and between -90 and 90.
    
</dd>
</dl>

<dl>
<dd>

**minLon:** `float?` — Minimum longitude for the viewbox. Must be ≤ max_lon and between -180 and 180.
    
</dd>
</dl>

<dl>
<dd>

**maxLon:** `float?` — Maximum longitude for the viewbox. Must be ≥ min_lon and between -180 and 180.
    
</dd>
</dl>

<dl>
<dd>

**acceptLanguage:** `string?` — Preferred language order for showing search results. This may either be a simple comma-separated list of language codes or a single entry. The results will be in the 1st language which is matched from the header. As a fallback if the results are not supported in the given language, &#x27;en&#x27; will be used.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GeocoderReverseAsync(request) -&gt; GeocoderReverseResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Convert geographic coordinates (latitude and longitude) into a human-readable address or place name.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GeocoderReverseRequest
{
    ApiKey = "your_api_key",
    Lat = 51.5074,
    Lon = -0.1278,
};

var response = await client.GeocoderReverseAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GeocoderReverseRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double` — Required. — WGS84 latitude value ranging from -90 to 90.
    
</dd>
</dl>

<dl>
<dd>

**lon:** `double` — Required. — WGS84 longitude value ranging from -180 to 180.
    
</dd>
</dl>

<dl>
<dd>

**acceptLanguage:** `string?` — Preferred language order for showing search results. This may either be a simple comma-separated list of language codes or a single entry. The results will be in the 1st language which is matched from the header. As a fallback if the results are not supported in the given language, en will be used.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainWhoisLookupAsync(request) -&gt; DomainWhoisLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve current WHOIS information for a domain name.<br>This endpoint provides detailed registration information including registrar details,<br>dates, nameservers, and registrant information.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainWhoisLookupRequest
{
    ApiKey = "your_api_key",
    DomainName = "example.com",
};

var response = await client.DomainWhoisLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainWhoisLookupRequestFormat?` — Response format (defaults to json)
    
</dd>
</dl>

<dl>
<dd>

**domainName:** `string` — Required. — Domain name for WHOIS lookup
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkDomainWhoisLookupAsync(request) -&gt; BulkDomainWhoisLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve WHOIS information for `100 Domains per Request`.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkDomainWhoisLookupRequest
{
    ApiKey = "your_api_key",
    DomainNames = new[] { "example.com" },
};

var response = await client.BulkDomainWhoisLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkDomainWhoisLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domainNames:** `IEnumerable&lt;string&gt;` — A list of domain names for which WHOIS data is requested.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.IpWhoisLookupAsync(request) -&gt; IpWhoisLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Returns WHOIS registration details for a specified IP address (IPv4 or IPv6).

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new IpWhoisLookupRequest
{
    ApiKey = "your_api_key",
    Ip = "8.8.8.8",
};

var response = await client.IpWhoisLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `IpWhoisLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string` — Required. — The IP address (IPv4 or IPv6) for which WHOIS data is requested.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.AsnWhoisLookupAsync(request) -&gt; AsnWhoisLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Returns WHOIS registration details for a specified ASN, with or without the &#x27;as&#x27; prefix.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new AsnWhoisLookupRequest
{
    ApiKey = "your_api_key",
    Asn = "AS15169",
};

var response = await client.AsnWhoisLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `AsnWhoisLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**asn:** `string` — Required. — The Autonomous System Number (ASN) to retrieve WHOIS data for. Can be prefixed with &#x27;as&#x27; or not.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainWhoisHistoryAsync(request) -&gt; DomainWhoisHistoryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve historical WHOIS records for a domain name.<br>This endpoint provides a timeline of all recorded changes in domain registration information.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainWhoisHistoryRequest
{
    ApiKey = "your_api_key",
    DomainName = "example.com",
};

var response = await client.DomainWhoisHistoryAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainWhoisHistoryRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domainName:** `string` — Required. — Domain name for historical WHOIS lookup
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainWhoisReverseAsync(request) -&gt; DomainWhoisReverseResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Performs a reverse WHOIS search using one or more search parameters like keyword, email, owner, or company.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainWhoisReverseRequest
{
    ApiKey = "your_api_key",
    Email = "user@example.com",
};

var response = await client.DomainWhoisReverseAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainWhoisReverseRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**keyword:** `string?` — Keyword search term for reverse WHOIS by keyword (case-insensitive pattern matching).
    
</dd>
</dl>

<dl>
<dd>

**email:** `string?` — Email search term for reverse WHOIS by email address (case-insensitive exact or regex match; * wildcard supported).
    
</dd>
</dl>

<dl>
<dd>

**owner:** `string?` — Registrant or owner name for reverse WHOIS (a full-text search phrase matching technique to retrieve results).
    
</dd>
</dl>

<dl>
<dd>

**company:** `string?` — Organization or company name for reverse WHOIS (full-text search phrase matching technique to retrieve results).
    
</dd>
</dl>

<dl>
<dd>

**exact:** `bool?` — Accepts &#x27;true&#x27; or &#x27;false&#x27;. &quot;true&quot; returns only records that exactly match the input (keyword, owner/registrant, or company). &quot;false&quot; returns all matches and is the default when omitted.
    
</dd>
</dl>

<dl>
<dd>

**mode:** `DomainWhoisReverseRequestMode?`
    
</dd>
</dl>

<dl>
<dd>

**page:** `int?` — Page number for paginated results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainDnsLookupAsync(request) -&gt; DomainDnsLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve real-time DNS records for any hostname. Supports multiple record types including A, AAAA, MX, NS, SOA, SPF, TXT, and CNAME records.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainDnsLookupRequest
{
    ApiKey = "your_api_key",
    HostName = "example.com",
};

var response = await client.DomainDnsLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainDnsLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**hostName:** `string?` — Hostname or URL whose DNS records are required.
    
</dd>
</dl>

<dl>
<dd>

**ipAddress:** `string?` — The IP address for requested DNS&#x27;s PTR record. &#x27;type&#x27; parameter must be set to &#x27;all&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**type:** `IEnumerable&lt;string&gt;` — A comma-separated list of DNS record types for lookup. Possible values: A, AAAA, MX, NS, SOA, SPF, TXT, CNAME, or all. When ipAddress is provided, type must be &quot;all&quot;.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkDomainDnsLookupAsync(request) -&gt; BulkDomainDnsLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Perform DNS lookups for multiple hostnames in a single request. Supports up to `100 host-names per request`<br>and returns DNS records including A, AAAA, MX, NS, SOA, SPF, TXT, and CNAME records.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkDomainDnsLookupRequest
{
    ApiKey = "your_api_key",
    DomainNames = new[] { "example.com" },
};

var response = await client.BulkDomainDnsLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkDomainDnsLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**type:** `IEnumerable&lt;string&gt;` — A comma-separated list of DNS record types for lookup. Possible values: A, AAAA, MX, NS, SOA, SPF, TXT, CNAME, or all
    
</dd>
</dl>

<dl>
<dd>

**domainNames:** `IEnumerable&lt;string&gt;` — List of hostnames to lookup DNS records for
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainDnsHistoryAsync(request) -&gt; DomainDnsHistoryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve historical DNS records for any hostname. Access unique historical data for A, AAAA, MX, NS, SOA, SPF, TXT, and CNAME records,<br>including subdomains. Results are paginated with up to 100 unique records per page.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainDnsHistoryRequest
{
    ApiKey = "your_api_key",
    HostName = "example.com",
};

var response = await client.DomainDnsHistoryAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainDnsHistoryRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**hostName:** `string` — Required. — Hostname or URL whose historical DNS records are required
    
</dd>
</dl>

<dl>
<dd>

**type:** `IEnumerable&lt;string&gt;` — A comma-separated list of DNS record types for lookup. Possible values: A, AAAA, MX, NS, SOA, SPF, TXT, CNAME, or all
    
</dd>
</dl>

<dl>
<dd>

**page:** `int?` — Page number for paginated results
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainDnsReverseAsync(request) -&gt; DomainDnsReverseResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve all the hostnames associated with any particular A, AAAA, MX, NS, SOA, SPF, TXT, and CNAME DNS records. For instance, you can access all the hostnames hosted on any IP/CIDR notation, all the domain names using Cloudflare name servers, and all the domain names using Google Mailbox

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainDnsReverseRequest
{
    ApiKey = "your_api_key",
    Type = DomainDnsReverseRequestType.A,
    Value = "8.8.8.8",
};

var response = await client.DomainDnsReverseAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainDnsReverseRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**type:** `DomainDnsReverseRequestType` — Required. — The type of reverse DNS lookup to perform. Determines how the value parameter is interpreted: - A: IPv4 CIDR block - AAAA: IPv6 CIDR block - MX: Mail provider domain - NS: Name server provider hostname - SOA: SOA record admin domain - SPF/TXT: Target verification strings - CNAME: Target hostname
    
</dd>
</dl>

<dl>
<dd>

**value:** `string` — Required. — Provide an IP or CIDR for A/AAAA lookups, or a hostname/selector for MX, NS, SOA, SPF, TXT, and CNAME queries. Wildcard regex patterns are also supported (e.g., mail.google.com, m*.google.com, _spf.g*.com, s*.g*.com).
    
</dd>
</dl>

<dl>
<dd>

**exact:** `bool?` — Accepts &#x27;true&#x27; or &#x27;false&#x27;. &quot;true&quot; returns only records that exactly match the input (NS, MX, CNAME, SOA, SPF, TXT). &quot;false&quot; returns all matches (default when omitted).
    
</dd>
</dl>

<dl>
<dd>

**page:** `int?` — Page number to paginate through results (defaults to 1).
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.WebScrapeAsync(request) -&gt; WebScrapeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Execute a series of web scraping instructions on a target URL.<br>Supports various operations like form filling, clicking, data extraction, and CAPTCHA solving.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new WebScrapeRequest
{
    ApiKey = "your_api_key",
    Url = "https://example.com",
    Body = new WebScrapeRequestBodyOne(),
    Text = true,
};

var response = await client.WebScrapeAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `WebScrapeRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**url:** `string` — Required. — Target URL to scrape
    
</dd>
</dl>

<dl>
<dd>

**text:** `bool?` — Set to `true` to return the data in text format else `false` for data in html format with tags.
    
</dd>
</dl>

<dl>
<dd>

**jsEnabled:** `bool?` — Set `true` to handle websites with JavaScript. Set `false` to handle static html websites. Default value is `true`.
    
</dd>
</dl>

<dl>
<dd>

**proxy:** `OneOf&lt;bool, string, Dictionary&lt;string, object?&gt;&gt;?` — Use proxy for requests
    
</dd>
</dl>

<dl>
<dd>

**sslIgnore:** `bool?` — Ignore SSL certificate errors. Only works if **jsEnabled** is **true**.
    
</dd>
</dl>

<dl>
<dd>

**windowSize:** `string?` — Specify the browser window size in the format &#x27;width,height&#x27; (e.g., &quot;1920w,1080h&quot;). Default value is the default resolutions provided by web/browser. Only works if **jsEnabled** is **true**.
    
</dd>
</dl>

<dl>
<dd>

**adBlock:** `bool?` — Set to `true` to apply ad-blocker to the specified URL else false or ignore to not apply. Only works if **jsEnabled** is **true**.
    
</dd>
</dl>

<dl>
<dd>

**captcha:** `bool?` — if true user can provide captcha instructions in the instructions to solve image captchas. Only works if **jsEnabled** is **true**.
    
</dd>
</dl>

<dl>
<dd>

**body:** `OneOf&lt;WebScrapeRequestBodyBlockUrl, WebScrapeRequestBodyOne&gt;` — Required.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.EmailValidateAsync(request) -&gt; EmailValidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Validates a single email address and returns result.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new EmailValidateRequest
{
    ApiKey = "your_api_key",
    Email = "user@example.com",
    Ip = "8.8.8.8",
};

var response = await client.EmailValidateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `EmailValidateRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**email:** `string` — Required. — Email address to validate
    
</dd>
</dl>

<dl>
<dd>

**name:** `string?` — Name of the email address
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP address of the email address
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkEmailValidateAsync(request) -&gt; BulkEmailValidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Validates a bulk of email addresses and returns result for each. Maximum `10` email addresses per request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkEmailValidateRequest
{
    ApiKey = "your_api_key",
    EmailData = new[] { new BulkEmailValidateRequestEmailDataItem { Email = "user@example.com" } },
};

var response = await client.BulkEmailValidateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkEmailValidateRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**emailData:** `IEnumerable&lt;BulkEmailValidateRequestEmailDataItem&gt;` — Array of email objects for bulk validation
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PhoneValidateAsync(request) -&gt; PhoneValidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Validates a single phone number and returns detailed metadata including carrier, line type, geolocation, time zones, and standardized formats.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PhoneValidateRequest
{
    ApiKey = "your_api_key",
    Number = "+14155552671",
};

var response = await client.PhoneValidateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PhoneValidateRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object. If not provided, the API defaults to JSON format.
    
</dd>
</dl>

<dl>
<dd>

**number:** `string` — Required. — Phone number to validate. Accepts international format (+14155552671), local format (4155552671) with region, or IDD format (0014155552671) with dialer_region.
    
</dd>
</dl>

<dl>
<dd>

**region:** `string?` — Two-letter ISO country code (e.g., US, GB). Required when number is in local format without + prefix. Cannot be used together with dialer_region.
    
</dd>
</dl>

<dl>
<dd>

**dialerRegion:** `string?` — Two-letter ISO country code indicating the country the number is being dialed from. Required when number uses IDD exit code. Cannot be used together with region.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkPhoneValidateAsync(request) -&gt; IEnumerable&lt;BulkPhoneValidateResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Validates up to 100 phone numbers in a single request. Each number is processed independently — invalid entries return per-number errors without affecting the rest of the batch.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkPhoneValidateRequest
{
    ApiKey = "your_api_key",
    Numbers = new[] { new BulkPhoneValidateRequestNumbersItem { Number = "+14155552671" } },
};

var response = await client.BulkPhoneValidateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkPhoneValidateRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object. If not provided, the API defaults to JSON format.
    
</dd>
</dl>

<dl>
<dd>

**numbers:** `IEnumerable&lt;BulkPhoneValidateRequestNumbersItem&gt;` — Array of phone number objects. Maximum 100 per request.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainSslLookupAsync(request) -&gt; DomainSslLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve comprehensive SSL certificate information without the certificate chain.<br>This endpoint provides detailed information about the SSL certificate including expiry dates, issuer details, and encryption methods.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainSslLookupRequest
{
    ApiKey = "your_api_key",
    DomainName = "example.com",
};

var response = await client.DomainSslLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainSslLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domainName:** `string` — Required. — Domain name or URL whose SSL certificate lookup is required
    
</dd>
</dl>

<dl>
<dd>

**sslRaw:** `bool?` — Set to true to get the raw openSSL response of the domain
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainSslChainLookupAsync(request) -&gt; DomainSslChainLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve the complete SSL certificate chain from root Certificate Authority (CA) to end-user certificate.<br>This endpoint provides comprehensive information about each certificate in the chain.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainSslChainLookupRequest
{
    ApiKey = "your_api_key",
    DomainName = "example.com",
};

var response = await client.DomainSslChainLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainSslChainLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domainName:** `string` — Required. — Domain name or URL whose SSL certificate chain lookup is required
    
</dd>
</dl>

<dl>
<dd>

**sslRaw:** `bool?` — Set to true to get the raw openSSL response for each certificate in the chain
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainAvailabilityCheckAsync(request) -&gt; DomainAvailabilityCheckResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

The Domain Search API is designed to simplify the process of finding available domain names across all top-level domains (TLDs) and second-level domains (SLDs).

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainAvailabilityCheckRequest
{
    ApiKey = "your_api_key",
    Domain = "example.com",
};

var response = await client.DomainAvailabilityCheckAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainAvailabilityCheckRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domain:** `string` — Required. — Domain name whose availability is to be checked.
    
</dd>
</dl>

<dl>
<dd>

**source:** `DomainAvailabilityCheckRequestSource?` — Specify the data source for domain availability checks. Use &quot;dns&quot; for DNS-based lookups or &quot;whois&quot; for WHOIS-based lookups. By default, &quot;dns&quot; is used.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkDomainAvailabilityCheckAsync(request) -&gt; BulkDomainAvailabilityCheckResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Perform Bulk Domain Availability checks using a list of domains. Supports upto `100 Domains Per Request`.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkDomainAvailabilityCheckRequest
{
    ApiKey = "your_api_key",
    DomainNames = new[] { "example.com" },
};

var response = await client.BulkDomainAvailabilityCheckAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkDomainAvailabilityCheckRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**source:** `BulkDomainAvailabilityCheckRequestSource?` — Specify the data source for domain availability checks. Use &quot;dns&quot; for DNS-based lookups or &quot;whois&quot; for WHOIS-based lookups. By default, &quot;dns&quot; is used.
    
</dd>
</dl>

<dl>
<dd>

**domainNames:** `IEnumerable&lt;string&gt;` — List of domain names to check.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.DomainAvailabilitySuggestionsAsync(request) -&gt; DomainAvailabilitySuggestionsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

The Domain Search API is designed to simplify the process of finding available domain names across all top-level domains (TLDs) and second-level domains (SLDs).

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new DomainAvailabilitySuggestionsRequest
{
    ApiKey = "your_api_key",
    Domain = "example.com",
};

var response = await client.DomainAvailabilitySuggestionsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `DomainAvailabilitySuggestionsRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domain:** `string` — Required. — Domain name for availability and suggestions.
    
</dd>
</dl>

<dl>
<dd>

**source:** `DomainAvailabilitySuggestionsRequestSource?` — Specify the data source for domain availability checks. Use &quot;dns&quot; for DNS-based lookups or &quot;whois&quot; for WHOIS-based lookups. By default, &quot;dns&quot; is used.
    
</dd>
</dl>

<dl>
<dd>

**count:** `int?` — Number of suggestions to retrieve.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.SubdomainsLookupAsync(request) -&gt; SubdomainsLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

The Subdomain Lookup API is designed to retrieve subdomains related to the given domain name. It helps you explore subdomains that are available for registration or usage.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new SubdomainsLookupRequest
{
    ApiKey = "your_api_key",
    Domain = "example.com",
};

var response = await client.SubdomainsLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `SubdomainsLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**domain:** `string` — Required. — Domain name for availability and suggestions.
    
</dd>
</dl>

<dl>
<dd>

**after:** `DateOnly?` — Filter subdomains seen after this date (format YYYY-MM-DD).
    
</dd>
</dl>

<dl>
<dd>

**before:** `DateOnly?` — Filter subdomains seen before this date( format YYYY-MM-DD).
    
</dd>
</dl>

<dl>
<dd>

**status:** `SubdomainsLookupRequestStatus?` — Filter subdomains by status (active or inactive).
    
</dd>
</dl>

<dl>
<dd>

**page:** `string?` — Page number for paginated results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfMergeAsync(request) -&gt; PdfMergeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API merges multiple PDF files into a single PDF, in the order they are provided

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfMergeRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfMergeAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfMergeRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `IEnumerable&lt;string&gt;` — An array of unique file IDs referencing PDF files previously uploaded to the API Freaks server. Use this parameter to merge existing files without re-uploading them. Provide multiple IDs to merge files in the specified order.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — Specifies the desired name for the resulting merged PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `IEnumerable&lt;FileParameter&gt;?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfRemovePagesAsync(request) -&gt; PdfRemovePagesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API removes a selection or range of pages from a PDF file.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfRemovePagesRequest
{
    ApiKey = "your_api_key",
    Pages = "1-3",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfRemovePagesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfRemovePagesRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique identifier of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output PDF file after pages have been removed. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string` — Required. — Specifies which pages to remove from the PDF. Accepts individual page numbers (e.g., &#x27;1,7&#x27;) and/or ascending page ranges (e.g., &#x27;3-5&#x27;). Use commas to separate entries and hyphens for ranges. Reverse ranges (e.g., &#x27;5-3&#x27;) are not allowed. Alternatively, you may provide only one of the following keywords: &#x27;even&#x27; (removes all even-numbered pages), &#x27;odd&#x27; (removes all odd-numbered pages), or &#x27;last&#x27; (removes only the last page). The keyword &#x27;all&#x27; is not supported for this operation. Examples: &#x27;1,3-5&#x27;, &#x27;even&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfSplitAsync(request) -&gt; PdfSplitResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API splits a PDF into multiple parts based on specified page numbers or ranges.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfSplitRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfSplitAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfSplitRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired base name for the output PDF files after splitting. If not provided, a default naming convention will be used.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `IEnumerable&lt;string&gt;` — Defines the page numbers or ranges where the PDF should be split. Provide individual pages and/or ranges in any order (for example: &quot;1-4,9-5,16-last&quot;). Separate entries with commas and use hyphens for ranges. Special keywords (use alone): • `even` — split at every even-numbered page • `odd` — split at every odd-numbered page • `all` — split the PDF into single-page files The keyword `last` can be used anywhere in the string, in combination with page numbers or ranges (for example: &quot;5-last&quot;, &quot;last-2&quot;, &quot;1,last,9&quot;). Examples: - &quot;1,4-2,last&quot; - &quot;odd&quot; - &quot;all&quot; - &quot;last,2-5&quot; Invalid example: &quot;1,odd&quot; (mixing a keyword other than &quot;last&quot; with specific pages/ranges is not allowed). You can pass multiple pages entries to produce multiple output files.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfRotateAsync(request) -&gt; PdfRotateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API rotates pages of a PDF by a specified angle (in multiples of 90 degrees).

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfRotateRequest
{
    ApiKey = "your_api_key",
    Rotate = 1,
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfRotateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfRotateRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output PDF file after rotation. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string?` — Specifies which pages to rotate. Accepts individual page numbers (e.g., &#x27;1,7&#x27;) and/or ascending page ranges (e.g., &#x27;3-5&#x27;). Use commas to separate entries and hyphens for ranges. Reverse ranges (e.g., &#x27;5-3&#x27;) are not allowed. Alternatively, provide only one of the following keywords: &#x27;even&#x27; (rotate all even-numbered pages), &#x27;odd&#x27; (rotate all odd-numbered pages), &#x27;last&#x27; (rotate only the last page), or &#x27;all&#x27; (rotate all pages). Examples: &#x27;1,3-5&#x27;, &#x27;odd&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**rotate:** `int` — Required. — The angle in degrees to rotate the selected pages. Must be one of the following values: 0, 90, 180, 270, -90, -180, or -270. All rotations are applied clockwise.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfCompressAsync(request) -&gt; PdfCompressResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API compresses a given PDF file to reduce its file size.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfCompressRequest
{
    ApiKey = "your_api_key",
    CompressionLevel = PdfCompressRequestCompressionLevel.Low,
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfCompressAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfCompressRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — Name of the output PDF.
    
</dd>
</dl>

<dl>
<dd>

**compressionLevel:** `PdfCompressRequestCompressionLevel` — Required. — Controls how aggressively the PDF is compressed. Lower levels preserve more quality, while higher levels reduce file size more.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to true, the input file(s) will be deleted from the server immediately after the output is generated.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfExtractPagesAsync(request) -&gt; PdfExtractPagesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API extracts specific pages or page ranges from a PDF file and returns them as a new PDF.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfExtractPagesRequest
{
    ApiKey = "your_api_key",
    Pages = "1-3",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfExtractPagesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfExtractPagesRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output PDF file after pages have been extracted. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string` — Required. — Specifies which pages to extract from the PDF. You can provide individual page numbers (e.g., &#x27;2&#x27;) and/or page ranges in any order, including descending (e.g., &#x27;9-5&#x27;, &#x27;16-last&#x27;). Use commas to separate entries and hyphens for ranges. You may alternatively pass only one of the special keywords: &#x27;even&#x27; (extracts all even-numbered pages), &#x27;odd&#x27; (extracts all odd-numbered pages), &#x27;last&#x27; (extracts only the last page), or &#x27;all&#x27; (extracts all pages into individual files). Examples: &#x27;2,6-3&#x27;, &#x27;even&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**separated:** `bool?` — If set to `true`, each of the specified pages will be extracted and returned as a separate PDF file.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfLinearizeAsync(request) -&gt; PdfLinearizeResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

API endpoint that linearizes any given PDF, restructuring it for faster loading and page-by-page viewing in web browsers.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfLinearizeRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfLinearizeAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfLinearizeRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output PDF file after pages have been extracted. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfEncryptAsync(request) -&gt; PdfEncryptResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API encrypts a PDF file by setting a password required to open it.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfEncryptRequest
{
    ApiKey = "your_api_key",
    UserPassword = "value",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfEncryptAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfEncryptRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output encrypted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**filePassword:** `string?` — The password to unlock the input file if it is already protected. Either the owner password or user password can be provided. The owner password takes precedence. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**userPassword:** `string` — Required. — Sets the user password required to open and view the encrypted PDF file. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**ownerPassword:** `string?` — Sets the owner password for the PDF file. This password provides full access, including the ability to remove restrictions. If not provided, the `user_password` will also be used as the owner password. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfDecryptAsync(request) -&gt; PdfDecryptResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API decrypts PDF files, removing all encryption, including open passwords and permission restrictions.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfDecryptRequest
{
    ApiKey = "your_api_key",
    FilePassword = "value",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfDecryptAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfDecryptRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output decrypted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**filePassword:** `string` — Required. — The password to unlock the input file if it is protected. Either the owner password or user password can be provided. The owner password takes precedence. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfRestrictAsync(request) -&gt; PdfRestrictResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API applies permission restrictions on a PDF file, such as disabling printing, copying, or editing. This can include password protection to enforce restrictions.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfRestrictRequest
{
    ApiKey = "your_api_key",
    UserPassword = "value",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfRestrictAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfRestrictRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output restricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**filePassword:** `string?` — The password to unlock the input file if it is already secured. Provide the owner password if available; otherwise, the user password. The owner password takes precedence. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**userPassword:** `string` — Required. — Sets the password users will use to open the PDF. If this is not set, only the owner password will be configured, and anyone can open the PDF file with the provided restrictions enabled. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**ownerPassword:** `string?` — Sets the password that allows full access to the PDF (e.g., removing restrictions). If not provided, the `user_password` (if set) will also be used as the owner password. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**restrictions:** `IEnumerable&lt;PdfRestrictRequestRestrictionsItem&gt;` — A comma-separated list of restrictions to apply to the PDF. These define what the end-user is *not* allowed to do with the PDF. Available options are: * **print_high** – Disables high-quality printing. * **print_low** – Disables low-resolution printing. * **edit_document_assembly** – Prevents reordering or inserting pages. * **fill_form_fields** – Disallows filling in PDF form fields. * **edit_annotations** – Disables adding or modifying annotations or comments. * **modify_content** – Prevents modifying existing content in the PDF. * **copy_and_extract_content** – Disables copying text or images from the PDF. * **use_accessibility** – Prevents screen readers or accessibility tools from accessing content.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfUnrestrictAsync(request) -&gt; PdfUnrestrictResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API removes permission restrictions from a PDF while keeping it encrypted. If you want to remove all security (including encryption), use the `/pdf/decrypt` endpoint instead.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfUnrestrictRequest
{
    ApiKey = "your_api_key",
    FilePassword = "value",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfUnrestrictAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfUnrestrictRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output unrestricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**filePassword:** `string` — Required. — The password to unlock the input file. Either the owner password or user password can be provided. The owner password takes precedence. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**userPassword:** `string?` — Sets the user password for the PDF file. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**ownerPassword:** `string?` — Sets the owner password for the PDF file. If the owner password is not provided, the `user_password` will also be used as the owner password. Password Length should be between 6 and 128 characters.
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfConvertToPngAsync(request) -&gt; PdfConvertToPngResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API converts a given PDF file into a sequence of PNG images.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfConvertToPngRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfConvertToPngAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfConvertToPngRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output unrestricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string?` — Specifies the pages or ranges at which to split the PDF. Accepts individual page numbers (e.g., &#x27;1&#x27;) and/or page ranges (e.g., &#x27;4-2&#x27;, &#x27;last&#x27;). Ranges can be ascending or descending. Use commas to separate entries and hyphens for ranges. Alternatively, provide only one of the following keywords: &#x27;even&#x27; (split at every even-numbered page), &#x27;odd&#x27; (split at every odd-numbered page), &#x27;last&#x27; (split at the last page only), or &#x27;all&#x27; (split into single pages). Examples: &#x27;1,4-2,last&#x27;, &#x27;odd&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**resolution:** `int?` — Specifies the resolution (in DPI) for the output images. Acceptable Range is from 20 to 1200.
    
</dd>
</dl>

<dl>
<dd>

**imageSmoothing:** `string?` — Determines the smoothing options to apply during image conversion. Valid values are &#x27;none&#x27;, &#x27;all&#x27; or a combination of &#x27;text&#x27;, &#x27;line&#x27;, and &#x27;image&#x27; (comma-separated).If not provided, no smoothing will be applied.
    
</dd>
</dl>

<dl>
<dd>

**profile:** `PdfConvertToPngRequestProfile?` — Specifies the color profile for the output PNG images. Acceptable values: bw (1-bit black &amp; white, smallest size, no grayscale or color), gray (8-bit grayscale), rgb (24-bit RGB color, default), rgba (32-bit RGB color with alpha channel for transparency), 4-bit (4-bit indexed color, up to 16 colors, smaller size), or 8-bit (8-bit indexed color, up to 256 colors).
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfConvertToJpgAsync(request) -&gt; PdfConvertToJpgResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API converts a given PDF file into a sequence of JPG images.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfConvertToJpgRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfConvertToJpgAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfConvertToJpgRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output unrestricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**quality:** `int?` — Controls JPG compression quality. Higher values yield sharper images with larger file sizes.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string?` — Specifies the pages or ranges at which to split the PDF. Accepts individual page numbers (e.g., &#x27;1&#x27;) and/or page ranges (e.g., &#x27;4-2&#x27;, &#x27;last&#x27;). Ranges can be ascending or descending. Use commas to separate entries and hyphens for ranges. Alternatively, provide only one of the following keywords: &#x27;even&#x27; (split at every even-numbered page), &#x27;odd&#x27; (split at every odd-numbered page), &#x27;last&#x27; (split at the last page only), or &#x27;all&#x27; (split into single pages). Examples: &#x27;1,4-2,last&#x27;, &#x27;odd&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**resolution:** `int?` — Specifies the resolution (in DPI) for the output images. Acceptable Range is from 20 to 1200.
    
</dd>
</dl>

<dl>
<dd>

**imageSmoothing:** `string?` — Determines the smoothing options to apply during image conversion. Valid values are &#x27;none&#x27;, &#x27;all&#x27; or a combination of &#x27;text&#x27;, &#x27;line&#x27;, and &#x27;image&#x27; (comma-separated).If not provided, no smoothing will be applied.
    
</dd>
</dl>

<dl>
<dd>

**profile:** `PdfConvertToJpgRequestProfile?` — Specifies the color profile for the output PNG images. Acceptable values: bw (1-bit black &amp; white, smallest size, no grayscale or color), gray (8-bit grayscale), rgb (24-bit RGB color, default), rgba (32-bit RGB color with alpha channel for transparency), 4-bit (4-bit indexed color, up to 16 colors, smaller size), or 8-bit (8-bit indexed color, up to 256 colors).
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfConvertToTiffAsync(request) -&gt; PdfConvertToTiffResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API converts a given PDF file into a sequence of TIFF images. The output images can be saved as a single TIFF file, or as a sequence of TIFF files.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfConvertToTiffRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfConvertToTiffAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfConvertToTiffRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output unrestricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string?` — Specifies the pages or ranges at which to split the PDF. Accepts individual page numbers (e.g., &#x27;1&#x27;) and/or page ranges (e.g., &#x27;4-2&#x27;, &#x27;last&#x27;). Ranges can be ascending or descending. Use commas to separate entries and hyphens for ranges. Alternatively, provide only one of the following keywords: &#x27;even&#x27; (split at every even-numbered page), &#x27;odd&#x27; (split at every odd-numbered page), &#x27;last&#x27; (split at the last page only), or &#x27;all&#x27; (split into single pages). Examples: &#x27;1,4-2,last&#x27;, &#x27;odd&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**resolution:** `int?` — Specifies the resolution (in DPI) for the output images. Acceptable Range is from 20 to 1200.
    
</dd>
</dl>

<dl>
<dd>

**imageSmoothing:** `string?` — Determines the smoothing options to apply during image conversion. Valid values are &#x27;none&#x27;, &#x27;all&#x27; or a combination of &#x27;text&#x27;, &#x27;line&#x27;, and &#x27;image&#x27; (comma-separated).If not provided, no smoothing will be applied.
    
</dd>
</dl>

<dl>
<dd>

**profile:** `PdfConvertToTiffRequestProfile?` — Specifies the color profile for the output PNG images. Acceptable values: bw (1-bit black &amp; white, smallest size, no grayscale or color), gray (8-bit grayscale), rgb (24-bit RGB color, default), rgba (32-bit RGB color with alpha channel for transparency), 4-bit (4-bit indexed color, up to 16 colors, smaller size), or 8-bit (8-bit indexed color, up to 256 colors).
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfConvertToBmpAsync(request) -&gt; PdfConvertToBmpResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Converts a PDF file to a BMP image.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfConvertToBmpRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfConvertToBmpAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfConvertToBmpRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output unrestricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string?` — Specifies the pages or ranges at which to split the PDF. Accepts individual page numbers (e.g., &#x27;1&#x27;) and/or page ranges (e.g., &#x27;4-2&#x27;, &#x27;last&#x27;). Ranges can be ascending or descending. Use commas to separate entries and hyphens for ranges. Alternatively, provide only one of the following keywords: &#x27;even&#x27; (split at every even-numbered page), &#x27;odd&#x27; (split at every odd-numbered page), &#x27;last&#x27; (split at the last page only), or &#x27;all&#x27; (split into single pages). Examples: &#x27;1,4-2,last&#x27;, &#x27;odd&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**resolution:** `int?` — Specifies the resolution (in DPI) for the output images. Acceptable Range is from 20 to 1200.
    
</dd>
</dl>

<dl>
<dd>

**imageSmoothing:** `string?` — Determines the smoothing options to apply during image conversion. Valid values are &#x27;none&#x27;, &#x27;all&#x27; or a combination of &#x27;text&#x27;, &#x27;line&#x27;, and &#x27;image&#x27; (comma-separated).If not provided, no smoothing will be applied.
    
</dd>
</dl>

<dl>
<dd>

**profile:** `PdfConvertToBmpRequestProfile?` — Specifies the color profile for the output PNG images. Acceptable values: bw (1-bit black &amp; white, smallest size, no grayscale or color), gray (8-bit grayscale), rgb (24-bit RGB color, default), rgba (32-bit RGB color with alpha channel for transparency), 4-bit (4-bit indexed color, up to 16 colors, smaller size), or 8-bit (8-bit indexed color, up to 256 colors).
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfConvertToGifAsync(request) -&gt; PdfConvertToGifResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API converts a given PDF file into a sequence of GIF images.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfConvertToGifRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfConvertToGifAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfConvertToGifRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string?` — The unique ID of a PDF file already uploaded to the API Freaks server. Use this as an alternative to uploading a new file directly.
    
</dd>
</dl>

<dl>
<dd>

**destroy:** `bool?` — If set to `true`, the input file(s) will be permanently deleted from the server immediately after the output PDF is generated.
    
</dd>
</dl>

<dl>
<dd>

**output:** `string?` — The desired name for the output unrestricted PDF file. If not provided, a default name will be assigned.
    
</dd>
</dl>

<dl>
<dd>

**pages:** `string?` — Specifies the pages or ranges at which to split the PDF. Accepts individual page numbers (e.g., &#x27;1&#x27;) and/or page ranges (e.g., &#x27;4-2&#x27;, &#x27;last&#x27;). Ranges can be ascending or descending. Use commas to separate entries and hyphens for ranges. Alternatively, provide only one of the following keywords: &#x27;even&#x27; (split at every even-numbered page), &#x27;odd&#x27; (split at every odd-numbered page), &#x27;last&#x27; (split at the last page only), or &#x27;all&#x27; (split into single pages). Examples: &#x27;1,4-2,last&#x27;, &#x27;odd&#x27;, &#x27;all&#x27;. Mixing special keywords with specific pages/ranges is not allowed.
    
</dd>
</dl>

<dl>
<dd>

**resolution:** `int?` — Specifies the resolution (in DPI) for the output images. Acceptable Range is from 20 to 1200.
    
</dd>
</dl>

<dl>
<dd>

**imageSmoothing:** `string?` — Determines the smoothing options to apply during image conversion. Valid values are &#x27;none&#x27;, &#x27;all&#x27; or a combination of &#x27;text&#x27;, &#x27;line&#x27;, and &#x27;image&#x27; (comma-separated).If not provided, no smoothing will be applied.
    
</dd>
</dl>

<dl>
<dd>

**profile:** `PdfConvertToGifRequestProfile?` — Specifies the color profile for the output PNG images. Acceptable values: bw (1-bit black &amp; white, smallest size, no grayscale or color), gray (8-bit grayscale), rgb (24-bit RGB color, default), rgba (32-bit RGB color with alpha channel for transparency), 4-bit (4-bit indexed color, up to 16 colors, smaller size), or 8-bit (8-bit indexed color, up to 256 colors).
    
</dd>
</dl>

<dl>
<dd>

**webhookUrl:** `string?` — The URL to which the webhook notification will be sent after the task is completed.
    
</dd>
</dl>

<dl>
<dd>

**webhookFailureNotification:** `bool?` — If true, a notification will also be sent by email in case the webhook request fails all the retries. The email notification will be sent to the requesting user or their organization’s admin if part of one.
    
</dd>
</dl>

<dl>
<dd>

**webhookAuthorization:** `string?` — Optional custom header for webhook requests. Format: `Key:Value` (e.g., `Authorization:Bearer token123`). This will be sent as an HTTP header in the webhook call.
    
</dd>
</dl>

<dl>
<dd>

**file:** `FileParameter?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfUploadResourcesAsync(request) -&gt; PdfUploadResourcesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API uploads multiple PDF files to the API Freaks server and generates their unique file IDs.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfUploadResourcesRequest
{
    ApiKey = "your_api_key",
    File = File.OpenRead("file.pdf"),
};

var response = await client.PdfUploadResourcesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfUploadResourcesRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**file:** `IEnumerable&lt;FileParameter&gt;?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfUploadBinaryAsync(request) -&gt; PdfUploadBinaryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API uploads PDF files to the API Freaks server in binary format.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfUploadBinaryRequest
{
    ApiKey = "your_api_key",
    FileName = "output.pdf",
    Body = File.OpenRead("file.pdf"),
};

var response = await client.PdfUploadBinaryAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfUploadBinaryRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileName:** `string` — Required. — The desired name for the uploaded PDF file. This name will be used for storage on the server. **NOTE**: Please ensure file_name has extension `.pdf`.
    
</dd>
</dl>

<dl>
<dd>

**body:** `Stream` — Required.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfDownloadResourceAsync(request) -&gt; global::System.IO.Stream</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API downloads PDF files or ZIP archives from the server using their unique resource ID.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfDownloadResourceRequest
{
    ApiKey = "your_api_key",
    ResourceId = "value",
};

var response = await client.PdfDownloadResourceAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfDownloadResourceRequestFormat?`
    
</dd>
</dl>

<dl>
<dd>

**resourceId:** `string` — Required. — The unique identifier of the file or ZIP archive to download.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfGetTaskStatusAsync(request) -&gt; PdfGetTaskStatusResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API checks the status of a previously initiated PDF processing task using its unique task ID.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfGetTaskStatusRequest
{
    ApiKey = "your_api_key",
    TaskId = "value",
};

var response = await client.PdfGetTaskStatusAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfGetTaskStatusRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**taskId:** `string` — Required. — The unique ID of the PDF processing task for which the status is requested.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfGetFileStatusAsync(request) -&gt; PdfGetFileStatusResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API checks the status of a PDF file using its unique file ID, providing information about its creation and potential deletion time.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfGetFileStatusRequest
{
    ApiKey = "your_api_key",
    FileId = "value",
};

var response = await client.PdfGetFileStatusAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfGetFileStatusRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string` — Required. — The unique ID of the file whose status is requested.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfListFilesAsync(request) -&gt; PdfListFilesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API retrieves a list of all PDF files uploaded and generated by a specific user. Please note that if the user is part of an organization, only the Organization Administrator can access this endpoint. Organization Members cannot access this endpoint.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfListFilesRequest
{
    ApiKey = "your_api_key",
};

var response = await client.PdfListFilesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfListFilesRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.PdfDeleteFileAsync(request) -&gt; PdfDeleteFileResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

This API deletes a PDF file using its unique file ID.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new PdfDeleteFileRequest
{
    ApiKey = "your_api_key",
    FileId = "value",
};

var response = await client.PdfDeleteFileAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `PdfDeleteFileRequestFormat?` — Specifies the desired format for the API response. Choose &#x27;json&#x27; for a JSON object or &#x27;xml&#x27; for an XML structure.
    
</dd>
</dl>

<dl>
<dd>

**fileId:** `string` — Required. — The unique ID of the file to be deleted.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ScreenshotCaptureAsync(request) -&gt; global::System.IO.Stream</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Capture full-page screenshots and videos of websites with advanced options like device simulation, custom code injection, cookie banner blocking, and scrollable content recording.<br>Supports multiple output formats including JSON, image, GIF, MP4, and WebM.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ScreenshotCaptureRequest
{
    ApiKey = "your_api_key",
    Url = "https://example.com",
};

var response = await client.ScreenshotCaptureAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**output:** `ScreenshotCaptureRequestOutput?` — Output format for screenshot results
    
</dd>
</dl>

<dl>
<dd>

**fileType:** `ScreenshotCaptureRequestFileType?` — File type for screenshot output
    
</dd>
</dl>

<dl>
<dd>

**url:** `string` — Required. — URLs to capture screenshots of
    
</dd>
</dl>

<dl>
<dd>

**width:** `int?` — Browser viewport width in pixels
    
</dd>
</dl>

<dl>
<dd>

**height:** `int?` — Browser viewport height in pixels
    
</dd>
</dl>

<dl>
<dd>

**fullPage:** `bool?` — Capture a full-page screenshot
    
</dd>
</dl>

<dl>
<dd>

**fresh:** `bool?` — Bypass cache and take a fresh screenshot
    
</dd>
</dl>

<dl>
<dd>

**noCookieBanners:** `bool?` — Remove cookie banners from the screenshot
    
</dd>
</dl>

<dl>
<dd>

**enableCaching:** `bool?` — Enable caching for repeated requests
    
</dd>
</dl>

<dl>
<dd>

**blockAds:** `bool?` — Block advertisements on the page
    
</dd>
</dl>

<dl>
<dd>

**blockChatWidgets:** `bool?` — Block chat widget scripts from loading
    
</dd>
</dl>

<dl>
<dd>

**extractText:** `bool?` — Extract visible text from the page
    
</dd>
</dl>

<dl>
<dd>

**extractHtml:** `bool?` — Extract HTML content of the page
    
</dd>
</dl>

<dl>
<dd>

**destroyScreenshot:** `bool?` — Auto-destroy screenshot after fetch
    
</dd>
</dl>

<dl>
<dd>

**lazyLoad:** `bool?` — Enable lazy-loading content before screenshot
    
</dd>
</dl>

<dl>
<dd>

**retina:** `bool?` — Capture screenshot in high-DPI (Retina) mode
    
</dd>
</dl>

<dl>
<dd>

**darkMode:** `bool?` — Render page in dark mode
    
</dd>
</dl>

<dl>
<dd>

**blockTracking:** `bool?` — Block common user-tracking scripts
    
</dd>
</dl>

<dl>
<dd>

**enableIncognito:** `bool?` — Enable private/incognito mode for browser session
    
</dd>
</dl>

<dl>
<dd>

**omitBackground:** `bool?` — Omit background color (transparent background)
    
</dd>
</dl>

<dl>
<dd>

**thumbnailWidth:** `int?` — Thumbnail width in pixels
    
</dd>
</dl>

<dl>
<dd>

**adjustTop:** `int?` — Adjust top in pixels
    
</dd>
</dl>

<dl>
<dd>

**waitForEvent:** `ScreenshotCaptureRequestWaitForEvent?` — Wait for a specific load event before capturing the screenshot.
    
</dd>
</dl>

<dl>
<dd>

**grayscale:** `int?` — Range:0 to 100 for grayscale filter
    
</dd>
</dl>

<dl>
<dd>

**delay:** `int?` — How many milliseconds to wait before taking the screenshot
    
</dd>
</dl>

<dl>
<dd>

**timeout:** `int?` — Maximum timeout in milliseconds. Defalut is `10,000`
    
</dd>
</dl>

<dl>
<dd>

**ttl:** `int?` — Number of seconds the screenshot should be cached
    
</dd>
</dl>

<dl>
<dd>

**clipX:** `int?` — X position of the clipping rectangle in pixels
    
</dd>
</dl>

<dl>
<dd>

**clipY:** `int?` — Y position of the clipping rectangle in pixels
    
</dd>
</dl>

<dl>
<dd>

**clipWidth:** `int?` — Width of the clipping rectangle in pixels
    
</dd>
</dl>

<dl>
<dd>

**clipHeight:** `int?` — Height of the clipping rectangle in pixels
    
</dd>
</dl>

<dl>
<dd>

**cssUrl:** `string?` — URL to CSS file
    
</dd>
</dl>

<dl>
<dd>

**css:** `string?` — Your custom CSS code
    
</dd>
</dl>

<dl>
<dd>

**jsUrl:** `string?` — URL to JS file
    
</dd>
</dl>

<dl>
<dd>

**js:** `string?` — Your JS code
    
</dd>
</dl>

<dl>
<dd>

**blockJs:** `bool?` — Block Scripts
    
</dd>
</dl>

<dl>
<dd>

**blockStylesheets:** `bool?` — Block Stylesheets
    
</dd>
</dl>

<dl>
<dd>

**blockImages:** `bool?` — Block Images
    
</dd>
</dl>

<dl>
<dd>

**blockMedia:** `bool?` — Block Media
    
</dd>
</dl>

<dl>
<dd>

**blockFont:** `bool?` — Block Fonts
    
</dd>
</dl>

<dl>
<dd>

**blockTextTrack:** `bool?` — Block Text Tracks
    
</dd>
</dl>

<dl>
<dd>

**blockXhr:** `bool?` — Block XHR Requests
    
</dd>
</dl>

<dl>
<dd>

**blockFetch:** `bool?` — Block Fetch Requests
    
</dd>
</dl>

<dl>
<dd>

**blockEventSource:** `bool?` — Block Event Source
    
</dd>
</dl>

<dl>
<dd>

**blockWebSocket:** `bool?` — Block Web Sockets
    
</dd>
</dl>

<dl>
<dd>

**blockManifest:** `bool?` — Block Manifest
    
</dd>
</dl>

<dl>
<dd>

**blockSpecificRequests:** `string?` — Comma- or newline-separated list of specific requests to block. Each line and comma are treated as separate requests for processing. Example: https://example.com, https://example.js
    
</dd>
</dl>

<dl>
<dd>

**blurSelector:** `string?` — Comma-separated list of indexed CSS selectors to blur. Format: `index:&amp;lt;selector&amp;gt;`, e.g., `0:.banner,1:#ads`.
    
</dd>
</dl>

<dl>
<dd>

**removeSelector:** `string?` — Comma-separated list of indexed CSS selectors to blur. Format: `index:&amp;lt;selector&amp;gt;`, e.g., `0:.banner,1:#ads`.
    
</dd>
</dl>

<dl>
<dd>

**resultFileName:** `string?` — Specify a meaningful &amp; unique file name to easily identify the screenshot result. Avoid using spaces or special characters; use hyphens or underscores to separate words.
    
</dd>
</dl>

<dl>
<dd>

**scrollingScreenshot:** `bool?` — **`Scrolling Screenshot`**: Capture a long scrolling screenshot. When true, disable `fullPage` and `freshScreenshot`.
    
</dd>
</dl>

<dl>
<dd>

**scrollSpeed:** `ScreenshotCaptureRequestScrollSpeed?` — Speed of scrolling during the screenshot.
    
</dd>
</dl>

<dl>
<dd>

**scrollBack:** `bool?` — If true, the scroll will reverse back to the top after reaching the bottom.
    
</dd>
</dl>

<dl>
<dd>

**startImmediately:** `bool?` — If true, the scrolling capture will start immediately upon page load.
    
</dd>
</dl>

<dl>
<dd>

**multipleScrolling:** `bool?` — If true, multiple scrolling screenshots will be taken at different viewport sizes.
    
</dd>
</dl>

<dl>
<dd>

**sizes:** `IEnumerable&lt;string&gt;` — Comma-separated list of viewport sizes in the format index:XXw:YYh. Example: sizes=0:120w:300h,1:240w:500h
    
</dd>
</dl>

<dl>
<dd>

**duration:** `double?` — Duration in seconds for the scrolling capture. Acceptable range: 0 to 100 seconds.
    
</dd>
</dl>

<dl>
<dd>

**failOnError:** `bool?`
    
</dd>
</dl>

<dl>
<dd>

**longitude:** `double?`
    
</dd>
</dl>

<dl>
<dd>

**latitude:** `double?`
    
</dd>
</dl>

<dl>
<dd>

**proxy:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**headers:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**cookies:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**scrollToElement:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**selector:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**userAgent:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**acceptLanguages:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**customHtml:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**imageQuality:** `double?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkScreenshotCaptureAsync(request) -&gt; BulkScreenshotCaptureResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Our Bulk Screenshot API allows you to capture screenshots of multiple webpages simultaneously, saving you time and effort. Instead of manually capturing each page one by one, you can batch process URLs and receive high-quality screenshots in the format you choose.<br>Maximum `50 URLs` per request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkScreenshotCaptureRequest
{
    ApiKey = "your_api_key",
};

var response = await client.BulkScreenshotCaptureAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkScreenshotCaptureRequestFormat?`
    
</dd>
</dl>

<dl>
<dd>

**urls:** `IEnumerable&lt;BulkScreenshotCaptureRequestUrlsItem&gt;` — List of website URLs to capture screenshots of
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyLatestRatesAsync(request) -&gt; CurrencyLatestRatesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get live forex rates for all world currencies with customizable update frequency

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyLatestRatesRequest
{
    ApiKey = "your_api_key",
};

var response = await client.CurrencyLatestRatesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyLatestRatesRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**base:** `string?` — Base currency for rate calculations
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — Comma separated list of desired currency codes
    
</dd>
</dl>

<dl>
<dd>

**updates:** `CurrencyLatestRatesRequestUpdates?` — Exchange rates update period (1d=daily, 1h=hourly, 10m=10 minutes, 1m=1 minute)
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyHistoricalRatesAsync(request) -&gt; CurrencyHistoricalRatesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get historical exchange rates for any specific date

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyHistoricalRatesRequest
{
    ApiKey = "your_api_key",
    Date = new DateOnly(2024, 1, 1),
};

var response = await client.CurrencyHistoricalRatesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyHistoricalRatesRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**base:** `string?` — Base currency for rate calculations
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — Comma separated list of desired currency codes
    
</dd>
</dl>

<dl>
<dd>

**date:** `DateOnly` — Required. — Specific date in YYYY-MM-DD format
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyConvertLatestAsync(request) -&gt; CurrencyConvertLatestResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Convert amount between currencies using the latest exchange rates

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyConvertLatestRequest
{
    ApiKey = "your_api_key",
    From = "USD",
    To = "EUR",
};

var response = await client.CurrencyConvertLatestAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyConvertLatestRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**from:** `string` — Required. — Source currency code
    
</dd>
</dl>

<dl>
<dd>

**to:** `string` — Required. — Target currency code
    
</dd>
</dl>

<dl>
<dd>

**amount:** `double?` — Amount to convert
    
</dd>
</dl>

<dl>
<dd>

**updates:** `CurrencyConvertLatestRequestUpdates?` — Exchange rates update period (1d=daily, 1h=hourly, 10m=10 minutes, 1m=1 minute)
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyConvertHistoricalAsync(request) -&gt; CurrencyConvertHistoricalResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Convert amount between currencies using historical rates

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyConvertHistoricalRequest
{
    ApiKey = "your_api_key",
    From = "USD",
    To = "EUR",
    Date = new DateOnly(2024, 1, 1),
};

var response = await client.CurrencyConvertHistoricalAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyConvertHistoricalRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**from:** `string` — Required. — From currency symbol
    
</dd>
</dl>

<dl>
<dd>

**to:** `string` — Required. — To currency symbol
    
</dd>
</dl>

<dl>
<dd>

**amount:** `double?` — The Amount to be converted
    
</dd>
</dl>

<dl>
<dd>

**date:** `DateOnly` — Required. — specific date (format YYYY-MM-DD) of which exchange rates is used.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyTimeSeriesAsync(request) -&gt; CurrencyTimeSeriesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get exchange rates for a time range

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyTimeSeriesRequest
{
    ApiKey = "your_api_key",
    StartDate = new DateOnly(2024, 1, 1),
};

var response = await client.CurrencyTimeSeriesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyTimeSeriesRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly` — Required. — Start date (format YYYY-MM-DD) of the preferred time frame
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly?` — End date (format YYYY-MM-DD) of the preferred time frame
    
</dd>
</dl>

<dl>
<dd>

**base:** `string?` — Base currency
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — comma separated list of desired currencies/ commodities symbols
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyFluctuationAsync(request) -&gt; CurrencyFluctuationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get currency fluctuation data for a time period

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyFluctuationRequest
{
    ApiKey = "your_api_key",
    StartDate = new DateOnly(2024, 1, 1),
};

var response = await client.CurrencyFluctuationAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyFluctuationRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly` — Required. — Start date (format YYYY-MM-DD) of the preferred time frame
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly?` — End date (format YYYY-MM-DD) of the preferred time frame
    
</dd>
</dl>

<dl>
<dd>

**base:** `string?` — Base currency
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — comma separated list of desired currencies/ commodities symbols
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyConvertByIpAsync(request) -&gt; CurrencyConvertByIpResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Convert amount using user&#x27;s location

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyConvertByIpRequest
{
    ApiKey = "your_api_key",
    From = "USD",
    Ip = "8.8.8.8",
};

var response = await client.CurrencyConvertByIpAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyConvertByIpRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**updates:** `CurrencyConvertByIpRequestUpdates?` — Exchange rates update period (1d=daily, 1h=hourly, 10m=10 minutes, 1m=1 minute)
    
</dd>
</dl>

<dl>
<dd>

**from:** `string` — Required. — From currency symbol
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IPv4 or IPv6 geolocated currency
    
</dd>
</dl>

<dl>
<dd>

**amount:** `double?` — Amount to convert
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencySupportedAsync(request) -&gt; CurrencySupportedResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get list of all supported currencies with their metadata

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencySupportedRequest
{
    ApiKey = "your_api_key",
};

var response = await client.CurrencySupportedAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencySupportedRequestFormat?` — Format of the response.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencySymbolsAsync(request) -&gt; CurrencySymbolsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get currency symbols and codes

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencySymbolsRequest
{
    ApiKey = "your_api_key",
};

var response = await client.CurrencySymbolsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencySymbolsRequestFormat?` — Format of the response.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrencyHistoricalLimitsAsync(request) -&gt; CurrencyHistoricalLimitsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get information about historical data availability and limits

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrencyHistoricalLimitsRequest
{
    ApiKey = "your_api_key",
};

var response = await client.CurrencyHistoricalLimitsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrencyHistoricalLimitsRequestFormat?` — Format of the response.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CommodityLatestRatesAsync(request) -&gt; CommodityLatestRatesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get live commodity rates with customizable update frequency

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CommodityLatestRatesRequest
{
    ApiKey = "your_api_key",
    Updates = CommodityLatestRatesRequestUpdates.TenM,
};

var response = await client.CommodityLatestRatesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CommodityLatestRatesRequestFormat?` — Format of the Response
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — Comma separated list of desired commodities symbols *(e.g. XAU,XAG,WTI,BRENT)* **Required**
    
</dd>
</dl>

<dl>
<dd>

**updates:** `CommodityLatestRatesRequestUpdates` — Required. — Exchange rates update period. Possible values are: (1) `10m` - 10 minute update (2) `1m` - 1 minute update **Required**
    
</dd>
</dl>

<dl>
<dd>

**quote:** `string?` — Specifies the target currency for the exchange rate; default quote currency is the market currency of commodity *(e.g. USD, EUR, INR)*
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CommodityHistoricalRatesAsync(request) -&gt; CommodityHistoricalRatesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get historical commodity rates for a specific date

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CommodityHistoricalRatesRequest
{
    ApiKey = "your_api_key",
    Date = new DateOnly(2024, 1, 1),
};

var response = await client.CommodityHistoricalRatesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CommodityHistoricalRatesRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**date:** `DateOnly` — Required. — Historical date (YYYY-MM-DD)
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — Comma-separated list of commodity symbols
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CommodityFluctuationAsync(request) -&gt; CommodityFluctuationResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get commodity price fluctuation data for a time period

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CommodityFluctuationRequest
{
    ApiKey = "your_api_key",
    StartDate = new DateOnly(2024, 1, 1),
    EndDate = new DateOnly(2024, 1, 1),
};

var response = await client.CommodityFluctuationAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CommodityFluctuationRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — Comma-separated list of commodity symbols
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly` — Required. — Start date (YYYY-MM-DD)
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly` — Required. — End date (YYYY-MM-DD)
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CommodityTimeSeriesAsync(request) -&gt; CommodityTimeSeriesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get commodity rates for a time range

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CommodityTimeSeriesRequest
{
    ApiKey = "your_api_key",
    StartDate = new DateOnly(2024, 1, 1),
    EndDate = new DateOnly(2024, 1, 1),
};

var response = await client.CommodityTimeSeriesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CommodityTimeSeriesRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**symbols:** `IEnumerable&lt;string&gt;` — Comma-separated list of commodity symbols
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly` — Required. — Start date (YYYY-MM-DD)
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly` — Required. — End date (YYYY-MM-DD)
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CommoditySymbolsAsync(request) -&gt; CommoditySymbolsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get list of supported commodities

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CommoditySymbolsRequest
{
    ApiKey = "your_api_key",
};

var response = await client.CommoditySymbolsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CommoditySymbolsRequestFormat?` — Format of the response.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.VatSupportedCountriesAsync(request) -&gt; VatSupportedCountriesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieves a list of supported countries.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new VatSupportedCountriesRequest
{
    ApiKey = "your_api_key",
};

var response = await client.VatSupportedCountriesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `VatSupportedCountriesRequestFormat?` — Format of the response. Default is JSON.
    
</dd>
</dl>

<dl>
<dd>

**type:** `VatSupportedCountriesRequestType?` — Type of supported country. Supported values: IBAN, SWIFT, VAT. By default, it returns all supported countries for all types.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.VatRateByIpAsync(request) -&gt; IEnumerable&lt;VatRateByIpResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Fetches VAT rate based on the specified or originating IP address.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new VatRateByIpRequest
{
    ApiKey = "your_api_key",
};

var response = await client.VatRateByIpAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `VatRateByIpRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**ipAddress:** `string?` — IPv4 or IPv6 address to look up VAT rate for. If omitted, the originating IP address will be used.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.VatRateByCountryAsync(request) -&gt; IEnumerable&lt;VatRateByCountryResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Fetches VAT rates for a single country or state provided via query parameters.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new VatRateByCountryRequest
{
    ApiKey = "your_api_key",
    Country = "US",
};

var response = await client.VatRateByCountryAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `VatRateByCountryRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country identifier in Alpha-2 (PK), Alpha-3 (PAK), or full name (Pakistan). Combine with the optional &quot;state&quot; query for sub-national VAT; values are case-insensitive and may use underscores instead of spaces.
    
</dd>
</dl>

<dl>
<dd>

**state:** `string?` — Optional state or region in Alpha-2 (NY) or full name (New_York). Use with &quot;country&quot; for state-level VAT; values are case-insensitive and may use underscores.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkVatRateByCountryAsync(request) -&gt; BulkVatRateByCountryResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieves VAT details for multiple countries or country-state combinations in a single request. Maximum of `100` entries per request are allowed.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkVatRateByCountryRequest
{
    ApiKey = "your_api_key",
};

var response = await client.BulkVatRateByCountryAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkVatRateByCountryRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**countries:** `IEnumerable&lt;BulkVatRateByCountryRequestCountriesItem&gt;`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.VatValidateAsync(request) -&gt; VatValidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Validates an EU or UK VAT number and returns registration status details.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new VatValidateRequest
{
    ApiKey = "your_api_key",
    VatNumber = "+14155552671",
};

var response = await client.VatValidateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `VatValidateRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**vatNumber:** `string` — Required. — EU or UK VAT number to validate.
    
</dd>
</dl>

<dl>
<dd>

**requesterVatNumber:** `string?` — Requester EU or UK VAT number.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.IbanValidateAsync(request) -&gt; IbanValidateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Checks an IBAN for structural validity, checksum accuracy, and bank metadata.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new IbanValidateRequest
{
    ApiKey = "your_api_key",
    Iban = "value",
};

var response = await client.IbanValidateAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `IbanValidateRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**iban:** `string` — Required. — IBAN to validate.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.SwiftCodeFindAsync(request) -&gt; IEnumerable&lt;string&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Fetches SWIFT codes for a given country, bank, and city.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new SwiftCodeFindRequest
{
    ApiKey = "your_api_key",
};

var response = await client.SwiftCodeFindAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `SwiftCodeFindRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string?` — Country name (accepts full name, e.g., Pakistan, United States). If only the country parameter is supplied, lists all banks in the country.
    
</dd>
</dl>

<dl>
<dd>

**bank:** `string?` — Bank name (upper case) used to filter SWIFT codes. Should be used together with the country parameter. If only country and bank are provided (without city), returns the list of cities for that bank.
    
</dd>
</dl>

<dl>
<dd>

**city:** `string?` — Gives SWIFT codes for a bank. Optionally specify the city (upper case) to narrow results to a specific city for that bank.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.SwiftCodeLookupAsync(request) -&gt; SwiftCodeLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Fetches detailed information about a SWIFT code.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new SwiftCodeLookupRequest
{
    ApiKey = "your_api_key",
    SwiftCode = "value",
};

var response = await client.SwiftCodeLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `SwiftCodeLookupRequestFormat?` — Specify the desired response format. Options: &#x27;json&#x27; (default) or &#x27;xml&#x27;.
    
</dd>
</dl>

<dl>
<dd>

**swiftCode:** `string` — Required. — SWIFT/BIC code to lookup (must be 8 or 11 characters).
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ZipcodeLookupAsync(request) -&gt; ZipcodeLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ZipcodeLookupRequest
{
    ApiKey = "your_api_key",
    Code = "value",
};

var response = await client.ZipcodeLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `ZipcodeLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**code:** `string` — Required. — Comma separated list of postal / zip codes. Max. 100 values.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string?` — Country code in ISO 3166-1 alpha-2 format. If not provided, search results will be returned from all countries.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkZipcodeLookupAsync(request) -&gt; BulkZipcodeLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Validates a bulk of ZIP/postal codes and returns result for each. Maximum `100` ZIP/postal codes per request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkZipcodeLookupRequest
{
    ApiKey = "your_api_key",
};

var response = await client.BulkZipcodeLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkZipcodeLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**codes:** `IEnumerable&lt;string&gt;` — Comma separated list of postal / zip codes. Max. 100 values.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string?` — Country code in ISO 3166-1 alpha-2 format. If not provided, search results will be returned from all countries.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ZipcodeSearchByCityAsync(request) -&gt; ZipcodeSearchByCityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ZipcodeSearchByCityRequest
{
    ApiKey = "your_api_key",
    City = "value",
    Country = "US",
};

var response = await client.ZipcodeSearchByCityAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `ZipcodeSearchByCityRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**city:** `string` — Required. — Name of the city in which we want to find zipcodes in.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**stateName:** `string?` — Name of the state or province associated with the country.
    
</dd>
</dl>

<dl>
<dd>

**page:** `int?` — Page number to retrieve paginated results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ZipcodeSearchByRegionAsync(request) -&gt; ZipcodeSearchByRegionResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ZipcodeSearchByRegionRequest
{
    ApiKey = "your_api_key",
    Country = "US",
    Region = "US",
};

var response = await client.ZipcodeSearchByRegionAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `ZipcodeSearchByRegionRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**region:** `string` — Required. — Name of the region, state or province associated with the country.
    
</dd>
</dl>

<dl>
<dd>

**page:** `int?` — Page no. to retrieve paginated results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ZipcodeSearchByRadiusAsync(request) -&gt; ZipcodeSearchByRadiusResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ZipcodeSearchByRadiusRequest
{
    ApiKey = "your_api_key",
    Radius = 1,
    Lat = 51.5074,
};

var response = await client.ZipcodeSearchByRadiusAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `ZipcodeSearchByRadiusRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**code:** `string?` — Postal/Zip code to be used as the center point for the search.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `float?` — Latitude coordinate for the base location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `float?` — Longitude coordinate for the base location.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string?` — Country code in ISO 3166-1 alpha-2 format. Required only when using the code parameter.
    
</dd>
</dl>

<dl>
<dd>

**radius:** `float` — Required. — Search radius for the query. The maximum allowed values are: - 100 km - 100 mi - 109361 yd - 100000 m - 328084 ft - 3937007.75 in
    
</dd>
</dl>

<dl>
<dd>

**unit:** `ZipcodeSearchByRadiusRequestUnit?` — Supported distance units are m, km, mi, ft, yd, in.
    
</dd>
</dl>

<dl>
<dd>

**page:** `int?` — Page no. to retrieve paginated results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ZipcodeDistanceAsync(request) -&gt; ZipcodeDistanceResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get distance between postal codes. Maximum `100` postal codes per request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ZipcodeDistanceRequest
{
    ApiKey = "your_api_key",
    Country = "US",
    Lat = 51.5074,
};

var response = await client.ZipcodeDistanceAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `ZipcodeDistanceRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**compare:** `IEnumerable&lt;string&gt;` — Comma separated list of postal / zip codes with which base point is compared w.r.t. Max 100 zip codes can be provided.
    
</dd>
</dl>

<dl>
<dd>

**code:** `string?` — Postal/Zip code to be used as the base point.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude coordinate for the base location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude coordinate for the base location.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**unit:** `ZipcodeDistanceRequestUnit?` — Supported distance units are m, km, mi, ft, yd, in.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ZipcodeDistanceMatchAsync(request) -&gt; ZipcodeDistanceMatchResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get matching ZIP/postal code pairs within a specified distance. Maximum `100` postal codes per request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ZipcodeDistanceMatchRequest
{
    ApiKey = "your_api_key",
    Country = "US",
};

var response = await client.ZipcodeDistanceMatchAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `ZipcodeDistanceMatchRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**codes:** `IEnumerable&lt;string&gt;` — Comma-separated list of postal/zip codes. Maximum 100 values allowed.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**distance:** `float?` — Maximum allowed distance between postal code pairs.
    
</dd>
</dl>

<dl>
<dd>

**unit:** `ZipcodeDistanceMatchRequestUnit?` — Supported distance units are m, km, mi, ft, yd, in.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.CurrentWeatherAsync(request) -&gt; CurrentWeatherResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get current weather data including temperature, humidity, precipitation, wind conditions, atmospheric pressure, and air quality for any location. Accepts city names, coordinates, or IP addresses. Also includes astronomy data and timezone-aware timestamps.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new CurrentWeatherRequest
{
    ApiKey = "your_api_key",
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.CurrentWeatherAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `CurrentWeatherRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkCurrentWeatherAsync(request) -&gt; BulkCurrentWeatherResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve current weather conditions for up to `50 locations` in a single request. A maximum of 50 locations (city names, IP addresses, or geographic coordinates) can be included in the request body.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkCurrentWeatherRequest
{
    ApiKey = "your_api_key",
};

var response = await client.BulkCurrentWeatherAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkCurrentWeatherRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

<dl>
<dd>

**locations:** `IEnumerable&lt;BulkCurrentWeatherRequestLocationsItem&gt;` — Array of locations to fetch weather data for
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.WeatherForecastAsync(request) -&gt; WeatherForecastResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Access comprehensive weather forecasts with customizable precision - choose from daily overviews, hourly breakdowns, or even minute-by-minute data. Configure your date ranges or use the default 7-day forecast for standard weather planning.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new WeatherForecastRequest
{
    ApiKey = "your_api_key",
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.WeatherForecastAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `WeatherForecastRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly?` — Start date for the forecast in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between startDate and endDate must not exceed 16 days.
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly?` — End date for the forecast in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between startDate and endDate must not exceed 16 days.
    
</dd>
</dl>

<dl>
<dd>

**forecastDays:** `int?` — Number of days for the forecast, from 1 to 16. Default is 7. Maximum value is 16.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**precision:** `WeatherForecastRequestPrecision?` — Precision of the forecast data.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.HistoricalWeatherAsync(request) -&gt; HistoricalWeatherResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Access past weather conditions for specific dates with records going back to 1940. Retrieve comprehensive historical data with both daily and hourly precision options.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new HistoricalWeatherRequest
{
    ApiKey = "your_api_key",
    Date = new DateOnly(2024, 1, 1),
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.HistoricalWeatherAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `HistoricalWeatherRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**date:** `DateOnly` — Required. — Specific date for which to fetch weather data in YYYY-MM-DD format. Historical dates must be past dates only. Current or future dates are not allowed for historical data. Data available from 1940 onwards.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**precision:** `HistoricalWeatherRequestPrecision?` — Precision of the historical data. **Note:** &#x27;daily&#x27; returns daily aggregates, &#x27;hourly&#x27; returns hourly data.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.WeatherTimeSeriesAsync(request) -&gt; WeatherTimeSeriesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Pull historical weather information for date ranges up to 90 days (daily data) or 7 days (hourly data). Get consistent formatting across your specified date range with reliable historical weather patterns.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new WeatherTimeSeriesRequest
{
    ApiKey = "your_api_key",
    StartDate = new DateOnly(2024, 1, 1),
    EndDate = new DateOnly(2024, 1, 1),
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.WeatherTimeSeriesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `WeatherTimeSeriesRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly` — Required. — Starting date for the data in YYYY-MM-DD format. Historical dates must be past dates only. Current or future dates are not allowed for historical data. Data available from 1940 onwards. For precision=daily, the difference between endDate and startDate must not exceed 90 days. For precision=hourly, the difference must not exceed 7 days.
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly` — Required. — End date for the data in YYYY-MM-DD format. Historical dates must be past dates only. Current or future dates are not allowed for historical data. Data available from 1940 onwards. For precision=daily, the difference between endDate and startDate must not exceed 90 days. For precision=hourly, the difference must not exceed 7 days.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**precision:** `WeatherTimeSeriesRequestPrecision?` — Precision of the data.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.MarineWeatherAsync(request) -&gt; MarineWeatherResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Provides hourly forecasts of marine conditions including wave heights, wave directions, wave periods, swell info, sea surface temperatures, and ocean currents. Supports multiple geographical points and returns daily max wave statistics for up to 7 days. Ideal for maritime planning, navigation, and coastal activities.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new MarineWeatherRequest
{
    ApiKey = "your_api_key",
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.MarineWeatherAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `MarineWeatherRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly?` — Starting date for marine forecast data in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between endDate and startDate must not exceed 16 days.
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly?` — End date for marine forecast data in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between endDate and startDate must not exceed 16 days.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**precision:** `MarineWeatherRequestPrecision?` — Precision of the marine data.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.AirQualityAsync(request) -&gt; AirQualityResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Monitor and predict air quality conditions using European and US AQI standards. Track pollutant concentrations including PM10, PM2.5, carbon monoxide, nitrogen dioxide, sulfur dioxide, ozone, and dust particles. Get current readings plus hourly forecasts up to 5 days ahead, complete with UV index and aerosol measurements for comprehensive air quality assessment.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new AirQualityRequest
{
    ApiKey = "your_api_key",
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.AirQualityAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `AirQualityRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly?` — Starting date for AQI forecast data in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between endDate and startDate must not exceed 5 days.
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly?` — End date for AQI forecast data in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between endDate and startDate must not exceed 5 days.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**precision:** `AirQualityRequestPrecision?` — Only hourly precision is supported; returns hourly AQI data for the selected date range.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.FloodForecastAsync(request) -&gt; FloodForecastResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Provides flood forecast data for a given location, including river discharge metrics such as mean, median, maximum, minimum, and percentile values (p25, p75). Requires a startDate and endDate, with the date range limited to 16 days. Location can be specified using city name, latitude/longitude, or IP address.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new FloodForecastRequest
{
    ApiKey = "your_api_key",
    StartDate = new DateOnly(2024, 1, 1),
    EndDate = new DateOnly(2024, 1, 1),
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.FloodForecastAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `FloodForecastRequestFormat?` — Response format returned by the API.
    
</dd>
</dl>

<dl>
<dd>

**startDate:** `DateOnly` — Required. — Starting date for flood forecast data in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between endDate and startDate must not exceed 16 days.
    
</dd>
</dl>

<dl>
<dd>

**endDate:** `DateOnly` — Required. — End date for flood forecast data in YYYY-MM-DD format. Forecast dates must be current or future dates only. Past dates are not allowed for forecast data. The difference between endDate and startDate must not exceed 16 days.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — City name, place name, or full address.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `double?` — Latitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**long:** `double?` — Longitude of the location.
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP(v4 or v6) address for location inference.
    
</dd>
</dl>

<dl>
<dd>

**precision:** `FloodForecastRequestPrecision?` — Only daily precision is supported; returns flood forecast data for the selected date range.
    
</dd>
</dl>

<dl>
<dd>

**timezone:** `string?` — Timezone for the results.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetCountriesAsync(request) -&gt; GetCountriesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve countries, optionally filtered by region or subregion.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetCountriesRequest
{
    ApiKey = "your_api_key",
};

var response = await client.GetCountriesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetCountriesRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**region:** `string?` — Optional filter to return countries within a specific region from the region endpoint.
    
</dd>
</dl>

<dl>
<dd>

**subregion:** `string?` — Optional filter to return countries within a specific subregion from the subregion endpoint.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetCountryDetailsAsync(request) -&gt; GetCountryDetailsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetCountryDetailsRequest
{
    ApiKey = "your_api_key",
    Country = "US",
};

var response = await client.GetCountryDetailsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetCountryDetailsRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetRegionsAsync(request) -&gt; GetRegionsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetRegionsRequest
{
    ApiKey = "your_api_key",
};

var response = await client.GetRegionsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetRegionsRequestFormat?` — Format of the response
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetSubregionsAsync(request) -&gt; GetSubregionsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

No description available.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetSubregionsRequest
{
    ApiKey = "your_api_key",
    Region = "US",
};

var response = await client.GetSubregionsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetSubregionsRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**region:** `string` — Required. — Name of the region.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetAdminLevelsAsync(request) -&gt; GetAdminLevelsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve administrative units based on ISO 3166-1 alpha-2 country code.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetAdminLevelsRequest
{
    ApiKey = "your_api_key",
    Country = "US",
};

var response = await client.GetAdminLevelsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetAdminLevelsRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetAdminUnitsAsync(request) -&gt; GetAdminUnitsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve administrative divisions for a given country using ISO 3166-1 alpha-2 country codes. You can optionally filter by administrative levels.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetAdminUnitsRequest
{
    ApiKey = "your_api_key",
    Country = "US",
};

var response = await client.GetAdminUnitsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetAdminUnitsRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**adminLevels:** `IEnumerable&lt;string&gt;` — Comma-separated list to filter results by one or more administrative levels.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetAdminUnitDetailsAsync(request) -&gt; GetAdminUnitDetailsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve detailed administrative unit information by country and optionally filtered by admin code.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetAdminUnitDetailsRequest
{
    ApiKey = "your_api_key",
    Country = "US",
    AdminUnit = "value",
};

var response = await client.GetAdminUnitDetailsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetAdminUnitDetailsRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**adminUnit:** `string` — Required. — Optional admin code to fetch details for a specific administrative unit.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetCitiesAsync(request) -&gt; GetCitiesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve a list of cities within a country, optionally filtered by an administrative unit code.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetCitiesRequest
{
    ApiKey = "your_api_key",
    Country = "US",
};

var response = await client.GetCitiesAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetCitiesRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**country:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**adminUnit:** `string?` — Administrative unit code used to filter cities within a specific region.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetSupportedFlagsAsync(request) -&gt; IEnumerable&lt;GetSupportedFlagsResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Get list of all supported flags with their metadata

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetSupportedFlagsRequest
{
    ApiKey = "your_api_key",
};

var response = await client.GetSupportedFlagsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GetFlagsAsync(request) -&gt; global::System.IO.Stream</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve the flag for a specific country

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GetFlagsRequest
{
    ApiKey = "your_api_key",
    Name = "US",
    Shape = GetFlagsRequestShape.Flat,
    Type = GetFlagsRequestType.Country,
};

var response = await client.GetFlagsAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**name:** `string` — Required. — Country code in ISO 3166-1 alpha-2 format.
    
</dd>
</dl>

<dl>
<dd>

**shape:** `GetFlagsRequestShape` — Required. — Flag shape. One of: `&#x27;flat&#x27;` or `&#x27;round&#x27;`.
    
</dd>
</dl>

<dl>
<dd>

**format:** `GetFlagsRequestFormat?` — Flag format. Applicable only for PNG or WEBP formats. Default is png.
    
</dd>
</dl>

<dl>
<dd>

**size:** `GetFlagsRequestSize?` — Flag size in pixels. Valid options: `16px`, `24px`, `32px`, `48px`, `64px`. Applicable only for PNG or WEBP formats.
    
</dd>
</dl>

<dl>
<dd>

**type:** `GetFlagsRequestType` — Required. — Type of flag. One of: `country` or `organization`.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.TimezoneLookupAsync(request) -&gt; TimezoneLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve current time, date, and timezone-related information by specifying a timezone name, location address, location coordinates, IP address, or use the client IP address if no parameter is passed.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new TimezoneLookupRequest
{
    ApiKey = "your_api_key",
    Ip = "8.8.8.8",
    Lat = 51.5074,
};

var response = await client.TimezoneLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `TimezoneLookupRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IPv4 or IPv6 address to extract timezone information.
    
</dd>
</dl>

<dl>
<dd>

**tz:** `string?` — Timezone name (e.g., &quot;Asia/Kolkata&quot;) to retrieve information directly.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — Location string (preferably city and country) to extract timezone.
    
</dd>
</dl>

<dl>
<dd>

**lat:** `float?` — Latitude for geolocation lookup.
    
</dd>
</dl>

<dl>
<dd>

**long:** `float?` — Longitude for geolocation lookup.
    
</dd>
</dl>

<dl>
<dd>

**lang:** `TimezoneLookupRequestLang?` — Language code for response localization (default is &quot;en&quot;).
    
</dd>
</dl>

<dl>
<dd>

**iataCode:** `string?` — 3-letter IATA airport code (e.g., JFK).
    
</dd>
</dl>

<dl>
<dd>

**icaoCode:** `string?` — 4-letter ICAO airport code (e.g., KJFK).
    
</dd>
</dl>

<dl>
<dd>

**loCode:** `string?` — 5-letter UN/LO city code.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.TimezoneConvertAsync(request) -&gt; TimezoneConvertResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Converts a given time from one timezone to another using various input types like timezone name, coordinates, location, or codes.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new TimezoneConvertRequest
{
    ApiKey = "your_api_key",
};

var response = await client.TimezoneConvertAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `TimezoneConvertRequestFormat?` — Format of the response .
    
</dd>
</dl>

<dl>
<dd>

**time:** `string?` — Time to convert in `yyyy-MM-dd HH:mm` or `yyyy-MM-dd HH:mm:ss` format.
    
</dd>
</dl>

<dl>
<dd>

**tzFrom:** `string?` — Source timezone name (e.g., `Asia/Kolkata`).
    
</dd>
</dl>

<dl>
<dd>

**tzTo:** `string?` — Target timezone name (e.g., `America/New_York`).
    
</dd>
</dl>

<dl>
<dd>

**latFrom:** `double?` — Latitude of source location.
    
</dd>
</dl>

<dl>
<dd>

**longFrom:** `double?` — Longitude of source location.
    
</dd>
</dl>

<dl>
<dd>

**latTo:** `double?` — Latitude of target location.
    
</dd>
</dl>

<dl>
<dd>

**longTo:** `double?` — Longitude of target location.
    
</dd>
</dl>

<dl>
<dd>

**locationFrom:** `string?` — From location (city/country).
    
</dd>
</dl>

<dl>
<dd>

**locationTo:** `string?` — To location (city/country).
    
</dd>
</dl>

<dl>
<dd>

**iataFrom:** `string?` — From IATA airport code (e.g., JFK).
    
</dd>
</dl>

<dl>
<dd>

**iataTo:** `string?` — To IATA airport code.
    
</dd>
</dl>

<dl>
<dd>

**icaoFrom:** `string?` — From ICAO airport code (e.g., KJFK).
    
</dd>
</dl>

<dl>
<dd>

**icaoTo:** `string?` — To ICAO airport code.
    
</dd>
</dl>

<dl>
<dd>

**locodeFrom:** `string?` — From UN/LO CODE.
    
</dd>
</dl>

<dl>
<dd>

**locodeTo:** `string?` — To UN/LO CODE.
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.UserAgentLookupAsync(request) -&gt; UserAgentLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Parse User Agent string to get detailed browser, device, and operating system information

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new UserAgentLookupRequest
{
    ApiKey = "your_api_key",
};

var response = await client.UserAgentLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `UserAgentLookupRequestFormat?` — Format of the response
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.BulkUserAgentLookupAsync(request) -&gt; IEnumerable&lt;BulkUserAgentLookupResponseItem&gt;</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Parse up to `50,000 User-Agent strings` at once in a single request.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new BulkUserAgentLookupRequest
{
    ApiKey = "your_api_key",
};

var response = await client.BulkUserAgentLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `BulkUserAgentLookupRequestFormat?` — Format of the response
    
</dd>
</dl>

<dl>
<dd>

**uaStrings:** `IEnumerable&lt;string&gt;` — List of user agent strings to parse
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.OcrPredictAsync(request) -&gt; OcrPredictResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Perform Optical Character Recognition (OCR) on images, PDFs, or ZIP archives. Supports two models: `mini-ocr-v1` for CAPTCHA-optimized OCR and `ocr-v1` for general-purpose document text extraction. Supports zonal OCR to extract text from specific regions of an image.<br><br>**Notes:**<br>- The `zone` query parameter cannot be given with .pdf and .zip types as it can only be applied to single image query.<br>- The `page_range` query parameter cannot be given in any other type except .pdf types.<br>- PDFs containing images in them are allowed only for processing.<br>- The `mini-ocr-v1` model doesn’t support the following query parameters:<br>- `page_range` (.pdf types)<br>- `zone`

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new OcrPredictRequest
{
    ApiKey = "your_api_key",
    Model = OcrPredictRequestModel.MiniOcrV1,
    OcrPredictRequestModel = OcrPredictRequestModel.MiniOcrV1,
    Url = "https://example.com",
};

var response = await client.OcrPredictAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**url:** `string?` — URL of the image or PDF (required if `file` not provided)
    
</dd>
</dl>

<dl>
<dd>

**model:** `OcrPredictRequestModel` — Required. — OCR model to use.
    
</dd>
</dl>

<dl>
<dd>

**pageRange:** `string?` — Specify page range for multi-page PDFs (e.g., &#x27;1,3,5-10&#x27; or &#x27;allpages&#x27;). **Note:** This parameter can only be used with .pdf file types.
    
</dd>
</dl>

<dl>
<dd>

**zone:** `string?` — Define OCR zones using coordinates (top:left:height:width). Multiple zones can be defined using commas. Only available for model &#x27;ocr-v1&#x27;. **Note:** This parameter cannot be used with .pdf and .zip file types as it can only be applied to single image queries.
    
</dd>
</dl>

<dl>
<dd>

**newLine:** `int?` — Set to 1 to split output text into individual lines (default: 0)
    
</dd>
</dl>

<dl>
<dd>

**ocrPredictRequestUrl:** `string?` — URL of the image or PDF (required if `file` not provided)
    
</dd>
</dl>

<dl>
<dd>

**ocrPredictRequestModel:** `OcrPredictRequestModel` — Required. — OCR model to use. `mini-ocr-v1` for CAPTCHA OCR, `ocr-v1` for general OCR
    
</dd>
</dl>

<dl>
<dd>

**ocrPredictRequestPageRange:** `string?` — Specify page range for multi-page PDFs (e.g., &#x27;1,3,5-10&#x27; or &#x27;allpages&#x27;). **Note:** This parameter can only be used with .pdf file types.
    
</dd>
</dl>

<dl>
<dd>

**ocrPredictRequestZone:** `string?` — Define OCR zones using coordinates (top:left:height:width). Multiple zones can be defined using commas. Only available for model &#x27;ocr-v1&#x27;. **Note:** This parameter cannot be used with .pdf and .zip file types as it can only be applied to single image queries.
    
</dd>
</dl>

<dl>
<dd>

**ocrPredictRequestNewLine:** `int?` — Set to 1 to split output text into individual lines (default: 0)
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GrammarDetectAsync(request) -&gt; GrammarDetectResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Analyze text for grammar errors and return the exact words flagged as grammatically incorrect with zero-based word positions.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GrammarDetectRequest
{
    ApiKey = "your_api_key",
    Text = "Example text to process.",
};

var response = await client.GrammarDetectAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**text:** `string` — Required. — Text to analyze for grammar errors
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.GrammarCorrectAsync(request) -&gt; GrammarCorrectResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Submit text with grammatical issues and receive a clean grammar-corrected result for proofreading and content workflows.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new GrammarCorrectRequest
{
    ApiKey = "your_api_key",
    Text = "Example text to process.",
};

var response = await client.GrammarCorrectAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**text:** `string` — Required. — Text to correct
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.WeakWordsDetectAsync(request) -&gt; WeakWordsDetectResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Analyze text and return weak, vague, or filler words with zero-based word positions to help writers produce clearer and more concise content.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new WeakWordsDetectRequest
{
    ApiKey = "your_api_key",
    Text = "Example text to process.",
};

var response = await client.WeakWordsDetectAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**text:** `string` — Required. — Text to analyze for weak words
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.ReadabilityScoreAsync(request) -&gt; ReadabilityScoreResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Analyze text readability using industry-standard formulas including Flesch Reading Ease, Flesch-Kincaid Grade Level, Gunning Fog Index, SMOG Index, Coleman-Liau Index, and Automated Readability Index.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new ReadabilityScoreRequest
{
    ApiKey = "your_api_key",
    Text = "Example text to process.",
};

var response = await client.ReadabilityScoreAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**target:** `ReadabilityScoreRequestTarget?` — Target audience used to tune sentence difficulty levels
    
</dd>
</dl>

<dl>
<dd>

**exclude:** `string?` — Comma-separated response sections to omit. Possible values are readability_scores, sentence_readability, readability_grade
    
</dd>
</dl>

<dl>
<dd>

**text:** `string` — Required. — Text to analyze for readability
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>

<details><summary><code>client.AstronomyLookupAsync(request) -&gt; AstronomyLookupResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

Retrieve sunrise and sunset times, current position of the moon, and other related information by specifying a location address, location coordinates, IP address, or using the client IP address if no parameter is passed.

</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

```csharp
using ApifreaksApi;

var client = new ApifreaksApiClient();

var request = new AstronomyLookupRequest
{
    ApiKey = "your_api_key",
    Lat = 51.5074,
    Ip = "8.8.8.8",
};

var response = await client.AstronomyLookupAsync(request);
```

</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**apiKey:** `string` — Required. — Your API key
    
</dd>
</dl>

<dl>
<dd>

**format:** `AstronomyLookupRequestFormat?` — Format of the response.
    
</dd>
</dl>

<dl>
<dd>

**location:** `string?` — Location name or address
    
</dd>
</dl>

<dl>
<dd>

**lat:** `float?` — Latitude for location coordinates
    
</dd>
</dl>

<dl>
<dd>

**long:** `float?` — Longitude for location coordinates
    
</dd>
</dl>

<dl>
<dd>

**ip:** `string?` — IP address for location detection
    
</dd>
</dl>

<dl>
<dd>

**lang:** `string?`
    
</dd>
</dl>

<dl>
<dd>

**date:** `DateOnly?` — Date for astronomy data (YYYY-MM-DD)
    
</dd>
</dl>

<dl>
<dd>

**elevation:** `double?` — Timezone of the location for which astronomy data is required
    
</dd>
</dl>

<dl>
<dd>

**timeZone:** `string?`
    
</dd>
</dl>

</dd>
</dl>

</dd>
</dl>
</details>
