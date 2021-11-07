// Decompiled with JetBrains decompiler
// Type: Windows.Web.WebErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web
{
  /// <summary>Defines errors encountered during operations involving web services, such as authentication, proxy configuration, and destination URIs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebErrorStatus
  {
    /// <summary>An unknown error has occurred.</summary>
    Unknown = 0,
    /// <summary>The SSL certificate common name does not match the web address.</summary>
    CertificateCommonNameIsIncorrect = 1,
    /// <summary>The SSL certificate has expired.</summary>
    CertificateExpired = 2,
    /// <summary>The SSL certificate contains errors.</summary>
    CertificateContainsErrors = 3,
    /// <summary>The SSL certificate has been revoked.</summary>
    CertificateRevoked = 4,
    /// <summary>The SSL certificate is invalid.</summary>
    CertificateIsInvalid = 5,
    /// <summary>The server is not responding.</summary>
    ServerUnreachable = 6,
    /// <summary>The connection has timed out.</summary>
    Timeout = 7,
    /// <summary>The server returned an invalid or unrecognized response.</summary>
    ErrorHttpInvalidServerResponse = 8,
    /// <summary>The connection was aborted.</summary>
    ConnectionAborted = 9,
    /// <summary>The connection was reset.</summary>
    ConnectionReset = 10, // 0x0000000A
    /// <summary>The connection was ended.</summary>
    Disconnected = 11, // 0x0000000B
    /// <summary>Redirected from a location to a secure location.</summary>
    HttpToHttpsOnRedirection = 12, // 0x0000000C
    /// <summary>Redirected from a secure location to an unsecure location.</summary>
    HttpsToHttpOnRedirection = 13, // 0x0000000D
    /// <summary>Cannot connect to destination.</summary>
    CannotConnect = 14, // 0x0000000E
    /// <summary>Could not resolve provided host name.</summary>
    HostNameNotResolved = 15, // 0x0000000F
    /// <summary>The operation was canceled.</summary>
    OperationCanceled = 16, // 0x00000010
    /// <summary>The request redirect failed.</summary>
    RedirectFailed = 17, // 0x00000011
    /// <summary>An unexpected status code indicating a failure was received.</summary>
    UnexpectedStatusCode = 18, // 0x00000012
    /// <summary>A request was unexpectedly redirected.</summary>
    UnexpectedRedirection = 19, // 0x00000013
    /// <summary>An unexpected client-side error has occurred.</summary>
    UnexpectedClientError = 20, // 0x00000014
    /// <summary>An unexpected server-side error has occurred.</summary>
    UnexpectedServerError = 21, // 0x00000015
    /// <summary>The request does not support the range.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] InsufficientRangeSupport = 22, // 0x00000016
    /// <summary>The request is mising the file size.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] MissingContentLengthSupport = 23, // 0x00000017
    /// <summary>The requested URL represents a high level grouping of which lower level selections need to be made.</summary>
    MultipleChoices = 300, // 0x0000012C
    /// <summary>This and all future requests should be directed to the given URI.</summary>
    MovedPermanently = 301, // 0x0000012D
    /// <summary>The resource was found but is available in a location different from the one included in the request.</summary>
    Found = 302, // 0x0000012E
    /// <summary>The response to the request can be found under another URI using a GET method.</summary>
    SeeOther = 303, // 0x0000012F
    /// <summary>Indicates the resource has not been modified since last requested.</summary>
    NotModified = 304, // 0x00000130
    /// <summary>The requested resource must be accessed through the proxy given by the Location field.</summary>
    UseProxy = 305, // 0x00000131
    /// <summary>The requested resource resides temporarily under a different URI.</summary>
    TemporaryRedirect = 307, // 0x00000133
    /// <summary>The request cannot be fulfilled due to bad syntax.</summary>
    BadRequest = 400, // 0x00000190
    /// <summary>Authentication has failed or credentials have not yet been provided.</summary>
    Unauthorized = 401, // 0x00000191
    /// <summary>Reserved.</summary>
    PaymentRequired = 402, // 0x00000192
    /// <summary>The server has refused the request.</summary>
    Forbidden = 403, // 0x00000193
    /// <summary>The requested resource could not be found but may be available again in the future.</summary>
    NotFound = 404, // 0x00000194
    /// <summary>A request was made of a resource using a request method not supported by that resource.</summary>
    MethodNotAllowed = 405, // 0x00000195
    /// <summary>The requested resource is only capable of generating content not acceptable according to the Accept headers sent in the request.</summary>
    NotAcceptable = 406, // 0x00000196
    /// <summary>The client must first authenticate itself with the proxy.</summary>
    ProxyAuthenticationRequired = 407, // 0x00000197
    /// <summary>The server timed out waiting for the request.</summary>
    RequestTimeout = 408, // 0x00000198
    /// <summary>Indicates that the request could not be processed because of conflict in the request.</summary>
    Conflict = 409, // 0x00000199
    /// <summary>Indicates that the resource requested is no longer available and will not be available again.</summary>
    Gone = 410, // 0x0000019A
    /// <summary>The request did not specify the length of its content, which is required by the requested resource.</summary>
    LengthRequired = 411, // 0x0000019B
    /// <summary>The server does not meet one of the preconditions that the requester put on the request.</summary>
    PreconditionFailed = 412, // 0x0000019C
    /// <summary>The request is larger than the server is willing or able to process.</summary>
    RequestEntityTooLarge = 413, // 0x0000019D
    /// <summary>Provided URI length exceeds the maximum length the server can process.</summary>
    RequestUriTooLong = 414, // 0x0000019E
    /// <summary>The request entity has a media type which the server or resource does not support.</summary>
    UnsupportedMediaType = 415, // 0x0000019F
    /// <summary>The client has asked for a portion of the file, but the server cannot supply that portion.</summary>
    RequestedRangeNotSatisfiable = 416, // 0x000001A0
    /// <summary>The server cannot meet the requirements of the Expect request-header field.</summary>
    ExpectationFailed = 417, // 0x000001A1
    /// <summary>A generic error message, given when no more specific message is suitable.</summary>
    InternalServerError = 500, // 0x000001F4
    /// <summary>The server either does not recognize the request method, or it lacks the ability to fulfill the request.</summary>
    NotImplemented = 501, // 0x000001F5
    /// <summary>The server was acting as a gateway or proxy and received an invalid response from the upstream server.</summary>
    BadGateway = 502, // 0x000001F6
    /// <summary>The server is currently unavailable.</summary>
    ServiceUnavailable = 503, // 0x000001F7
    /// <summary>The server was acting as a gateway or proxy and did not receive a timely response from the upstream server.</summary>
    GatewayTimeout = 504, // 0x000001F8
    /// <summary>The server does not support the HTTP protocol version used in the request.</summary>
    HttpVersionNotSupported = 505, // 0x000001F9
  }
}
