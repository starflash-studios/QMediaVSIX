// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpBaseProtocolFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;
using Windows.System;

namespace Windows.Web.Http.Filters
{
  /// <summary>The base protocol filter for an HttpClient instance.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHttpBaseProtocolFilterStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpBaseProtocolFilter : 
    IHttpBaseProtocolFilter,
    IHttpBaseProtocolFilter2,
    IHttpBaseProtocolFilter3,
    IHttpBaseProtocolFilter4,
    IHttpBaseProtocolFilter5,
    IHttpFilter,
    IClosable
  {
    /// <summary>Initializes a new instance of the HttpBaseProtocolFilter class.</summary>
    [MethodImpl]
    public extern HttpBaseProtocolFilter();

    /// <summary>Get or set a value that indicates whether the HttpBaseProtocolFilter should follow redirection responses.</summary>
    /// <returns>A value that indicates whether the HttpBaseProtocolFilter should follow redirection responses.</returns>
    public extern bool AllowAutoRedirect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set a value that indicates whether the HttpBaseProtocolFilter can prompt for user credentials when requested by the server.</summary>
    /// <returns>A value that indicates whether HttpBaseProtocolFilter can prompt for user credentials when requested by the server.</returns>
    public extern bool AllowUI { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the HttpBaseProtocolFilter can automatically decompress the HTTP content response.</summary>
    /// <returns>A value that indicates whether HttpBaseProtocolFilter can automatically decompress the HTTP content response.</returns>
    public extern bool AutomaticDecompression { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the read and write cache control behavior to be used on the HttpBaseProtocolFilter object.</summary>
    /// <returns>The cache control behavior to be used on the HttpBaseProtocolFilter object.</returns>
    public extern HttpCacheControl CacheControl { [MethodImpl] get; }

    /// <summary>Get the HttpCookieManager with the cookies associated with an app.</summary>
    /// <returns>The HttpCookieManager object that contains the cookies associated with an app.</returns>
    public extern HttpCookieManager CookieManager { [MethodImpl] get; }

    /// <summary>Get or set the client SSL certificate that will be sent to the server if the server requests a client certificate.</summary>
    /// <returns>The client SSl certificate.</returns>
    public extern Certificate ClientCertificate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get a vector of SSL server certificate errors that the app might subsequently choose to ignore.</summary>
    /// <returns>A vector of SSL server certificate errors that the app might subsequently choose to ignore.</returns>
    public extern IVector<ChainValidationResult> IgnorableServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Get or set the maximum number of TCP connections allowed per HTTP server by the HttpBaseProtocolFilter object.</summary>
    /// <returns>The maximum number of connections allowed per HTTP server.</returns>
    public extern uint MaxConnectionsPerServer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the credentials to be used to negotiate with an HTTP proxy.</summary>
    /// <returns>The credentials to be used to negotiate with an HTTP proxy.</returns>
    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the credentials to be used to authenticate with an HTTP server.</summary>
    /// <returns>The credentials to be used to authenticate with an HTTP server.</returns>
    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set a value that indicates whether the HttpBaseProtocolFilter can use a proxy for sending HTTP requests.</summary>
    /// <returns>A value that indicates whether HttpBaseProtocolFilter can use a proxy to send HTTP requests.</returns>
    public extern bool UseProxy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the version of the HTTP protocol used.</summary>
    /// <returns>An enumeration value that specifies the version of HTTP used.</returns>
    public extern HttpVersion MaxVersion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the cookie usage behavior. By default, cookies are handled automatically.</summary>
    /// <returns>The cookie usage behavior.</returns>
    public extern HttpCookieUsageBehavior CookieUsageBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This event is raised when the SSL/TLS connection is being established with the server. You should implement an event handler for this event if you need to perform extra validation (in addition to the OS default) of the server SSL certificate.</summary>
    public extern event TypedEventHandler<HttpBaseProtocolFilter, HttpServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;

    /// <summary>Clears authentication credentials currently cached on the device.</summary>
    [MethodImpl]
    public extern void ClearAuthenticationCache();

    /// <summary>Gets the User associated with the HttpBaseProtocolFilter.</summary>
    /// <returns>The User associated with the HttpBaseProtocolFilter.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Send an HTTP request using the HttpBaseProtocolFilter as an asynchronous operation.</summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <returns>The object representing the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a new HttpBaseProtocolFilter for a specific User.</summary>
    /// <param name="user">The User for which you want to create the HttpBaseProtocolFilter.</param>
    /// <returns>Returns an HttpBaseProtocolFilter for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern HttpBaseProtocolFilter CreateForUser(User user);
  }
}
