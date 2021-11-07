// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpStatusCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Contains the values of status codes defined for HTTP in the response to an HTTP request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpStatusCode
  {
    /// <summary>The client request wasn't successful.</summary>
    None = 0,
    /// <summary>The client should continue with its request.</summary>
    Continue = 100, // 0x00000064
    /// <summary>The HTTP protocol version or protocol is being changed.</summary>
    SwitchingProtocols = 101, // 0x00000065
    /// <summary>The server has received a Web Distributed Authoring and Versioning (WebDAV) request and is processing the request.</summary>
    Processing = 102, // 0x00000066
    /// <summary>The request succeeded and that the requested information is in the response. This is the most common status code to receive.</summary>
    Ok = 200, // 0x000000C8
    /// <summary>The request resulted in a new resource created before the response was sent.</summary>
    Created = 201, // 0x000000C9
    /// <summary>The request has been accepted for further processing.</summary>
    Accepted = 202, // 0x000000CA
    /// <summary>The returned meta-information is from a cached copy instead of the origin server and therefore may be incorrect.</summary>
    NonAuthoritativeInformation = 203, // 0x000000CB
    /// <summary>The request has been successfully processed and that the response is intentionally blank.</summary>
    NoContent = 204, // 0x000000CC
    /// <summary>The client should reset (not reload) the current resource.</summary>
    ResetContent = 205, // 0x000000CD
    /// <summary>The response is a partial response as requested by a **GET** request that includes a byte range.</summary>
    PartialContent = 206, // 0x000000CE
    /// <summary>The response provides status for multiple independent operations. Specific error messages appear in the body of the multi- status response.</summary>
    MultiStatus = 207, // 0x000000CF
    /// <summary>Some of the results of the requested operation were already reported.</summary>
    AlreadyReported = 208, // 0x000000D0
    /// <summary>The server has fulfilled a **GET** request for the resource and the response is the result of one or more actions applied to the current instance.</summary>
    IMUsed = 226, // 0x000000E2
    /// <summary>The requested information has multiple representations. The default action is to treat this status as a redirect and follow the contents of the **Location** header associated with this response.</summary>
    MultipleChoices = 300, // 0x0000012C
    /// <summary>The requested information has been moved to the URI specified in the **Location** header. The default action when this status is received is to follow the **Location** header associated with the response.</summary>
    MovedPermanently = 301, // 0x0000012D
    /// <summary>The requested information is located at the URI specified in the **Location** header. The default action when this status is received is to follow the **Location** header associated with the response. When the original request method was **POST**, the redirected request will use the **GET** method.</summary>
    Found = 302, // 0x0000012E
    /// <summary>Automatically redirects the client to the URI specified in the **Location** header as the result of a **POST**. The request to the resource specified by the **Location** header will be made with the **GET** method.</summary>
    SeeOther = 303, // 0x0000012F
    /// <summary>The client's cached copy is up to date. The contents of the resource are not transferred.</summary>
    NotModified = 304, // 0x00000130
    /// <summary>The request should use the proxy server at the URI specified in the **Location** header.</summary>
    UseProxy = 305, // 0x00000131
    /// <summary>The request information is located at the URI specified in the **Location** header. The default action when this status is received is to follow the **Location** header associated with the response. When the original request method was **POST**, the redirected request will also use the **POST** method.</summary>
    TemporaryRedirect = 307, // 0x00000133
    /// <summary>The target resource has been assigned a new permanent URI and any future references to this resource should use one of the returned URIs specified in the **Location** header.</summary>
    PermanentRedirect = 308, // 0x00000134
    /// <summary>The request could not be understood by the server. This status code is sent when no other error is applicable, or if the exact error is unknown or does not have its own error code.</summary>
    BadRequest = 400, // 0x00000190
    /// <summary>The requested resource requires authentication. The **WWW-Authenticate** header contains the details of how to perform the authentication.</summary>
    Unauthorized = 401, // 0x00000191
    /// <summary>This code is reserved for future use.</summary>
    PaymentRequired = 402, // 0x00000192
    /// <summary>The server refuses to fulfill the request.</summary>
    Forbidden = 403, // 0x00000193
    /// <summary>The requested resource does not exist on the server.</summary>
    NotFound = 404, // 0x00000194
    /// <summary>The HTTP method in the request is not allowed on the requested resource.</summary>
    MethodNotAllowed = 405, // 0x00000195
    /// <summary>The client has indicated with **Accept** headers that it will not accept any of the available representations of the resource.</summary>
    NotAcceptable = 406, // 0x00000196
    /// <summary>The requested proxy requires authentication. The **Proxy-Authenticate** header contains the details of how to perform the authentication.</summary>
    ProxyAuthenticationRequired = 407, // 0x00000197
    /// <summary>The client did not send a request within the time the server was expecting the request.</summary>
    RequestTimeout = 408, // 0x00000198
    /// <summary>The request could not be carried out because of a conflict on the server.</summary>
    Conflict = 409, // 0x00000199
    /// <summary>The requested resource is no longer available.</summary>
    Gone = 410, // 0x0000019A
    /// <summary>The required **Content-Length** header is missing.</summary>
    LengthRequired = 411, // 0x0000019B
    /// <summary>A condition set for this request failed, and the request cannot be carried out. Conditions are set with conditional request headers like **If-Match**, **If-None-Match**, or **If-Unmodified-Since**.</summary>
    PreconditionFailed = 412, // 0x0000019C
    /// <summary>The request is too large for the server to process.</summary>
    RequestEntityTooLarge = 413, // 0x0000019D
    /// <summary>The URI is too long.</summary>
    RequestUriTooLong = 414, // 0x0000019E
    /// <summary>The request is an unsupported type.</summary>
    UnsupportedMediaType = 415, // 0x0000019F
    /// <summary>The range of data requested from the resource cannot be returned, either because the beginning of the range is before the beginning of the resource, or the end of the range is after the end of the resource.</summary>
    RequestedRangeNotSatisfiable = 416, // 0x000001A0
    /// <summary>An expectation given in an **Expect** header could not be met by the server.</summary>
    ExpectationFailed = 417, // 0x000001A1
    /// <summary>The server understands the content type of the request entity and the syntax of the request entity is correct, but the server was unable to process the contained instructions.</summary>
    UnprocessableEntity = 422, // 0x000001A6
    /// <summary>The source or destination resource of a method is locked. This response should contain an appropriate precondition or post-condition code.</summary>
    Locked = 423, // 0x000001A7
    /// <summary>The method could not be performed on the resource because the requested action depended on another action and that action failed.</summary>
    FailedDependency = 424, // 0x000001A8
    /// <summary>The client should switch to a different protocol such as TLS/1.0.</summary>
    UpgradeRequired = 426, // 0x000001AA
    /// <summary>The origin server requires the request to be conditional.</summary>
    PreconditionRequired = 428, // 0x000001AC
    /// <summary>The user has sent too many requests in a given amount of time. The response should include details explaining the condition, and may include a **Retry-After** header indicating how long to wait before making a new request.</summary>
    TooManyRequests = 429, // 0x000001AD
    /// <summary>The server is unwilling to process the request because its header fields are too large. The request may be resubmitted after reducing the size of the request header fields.</summary>
    RequestHeaderFieldsTooLarge = 431, // 0x000001AF
    /// <summary>A generic error has occurred on the server.</summary>
    InternalServerError = 500, // 0x000001F4
    /// <summary>The server does not support the requested function.</summary>
    NotImplemented = 501, // 0x000001F5
    /// <summary>An intermediate proxy server received a bad response from another proxy or the origin server.</summary>
    BadGateway = 502, // 0x000001F6
    /// <summary>The server is temporarily unavailable, usually due to high load or maintenance.</summary>
    ServiceUnavailable = 503, // 0x000001F7
    /// <summary>An intermediate proxy server timed out while waiting for a response from another proxy or the origin server.</summary>
    GatewayTimeout = 504, // 0x000001F8
    /// <summary>The requested HTTP version is not supported by the server.</summary>
    HttpVersionNotSupported = 505, // 0x000001F9
    /// <summary>The server has an internal configuration error. The chosen variant resource is configured to engage in transparent content negotiation itself, and is therefore not a proper end point in the negotiation process.</summary>
    VariantAlsoNegotiates = 506, // 0x000001FA
    /// <summary>The method could not be performed on the resource because the server is unable to store the representation needed to successfully complete the request. This condition is considered to be temporary.</summary>
    InsufficientStorage = 507, // 0x000001FB
    /// <summary>The server terminated an operation because it encountered an infinite loop while processing a request. This status indicates that the entire operation failed.</summary>
    LoopDetected = 508, // 0x000001FC
    /// <summary>The policy for accessing the resource has not been met in the request.</summary>
    NotExtended = 510, // 0x000001FE
    /// <summary>The server indicates that the client needs to authenticate to gain network access. The response should contain a link to a resource that allows the user to submit credentials.</summary>
    NetworkAuthenticationRequired = 511, // 0x000001FF
  }
}
