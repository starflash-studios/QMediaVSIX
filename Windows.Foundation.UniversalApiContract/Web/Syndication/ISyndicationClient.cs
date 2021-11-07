// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.Syndication
{
  /// <summary>Encapsulates the data and methods needed to retrieve feeds from a URI asynchronously. It supports authentication.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2652416439, 29257, 19269, 178, 41, 125, 248, 149, 165, 161, 245)]
  public interface ISyndicationClient
  {
    /// <summary>Gets or sets the credentials to use when making requests to the server.</summary>
    /// <returns>Initally, this value is a username/password tuple. For domain credentials, the username is in domain\user form.</returns>
    PasswordCredential ServerCredential { get; set; }

    /// <summary>Gets or sets the credentials to use when making requests using a proxy.</summary>
    /// <returns>Initially, this value is a username/password tuple. For domain credentials, the username is in domain\user form.</returns>
    PasswordCredential ProxyCredential { get; set; }

    /// <summary>Gets or sets the maximum number of bytes to buffer when receiving a response from a server.</summary>
    /// <returns>Maximum size and default is **UInt32.MaxValue**.</returns>
    uint MaxResponseBufferSize { get; set; }

    /// <summary>Gets or sets the maximum amount of time, in milliseconds, to wait for any of the asynchronous operations to complete. If the operation is not complete within this amount of time, it will fail with a status code indicating that it timed out.</summary>
    /// <returns>Default value is 30000 (30 seconds). A value of **UInt32.MaxValue** indicates that the syndication client will wait indefinitely for a response.</returns>
    uint Timeout { get; set; }

    /// <summary>Gets or sets a Boolean that indicates whether cache will be bypassed when retrieving the feed.</summary>
    /// <returns>**TRUE** if the cache should be bypassed; otherwise **FALSE**.</returns>
    bool BypassCacheOnRetrieve { get; set; }

    /// <summary>Sets an HTTP header for the request. This method can be called multiple times to set multiple headers. When the same header is set multiple times, the values will be concatenated and separated by ",".</summary>
    /// <param name="name">The name of the header.</param>
    /// <param name="value">The value of the header.</param>
    void SetRequestHeader(string name, string value);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync(
      Uri uri);
  }
}
