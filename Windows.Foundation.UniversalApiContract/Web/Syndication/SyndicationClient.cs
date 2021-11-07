// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.SyndicationClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.Syndication
{
  /// <summary>Implements the ISyndicationClient interface which retrieves feeds from a URI asynchronously.</summary>
  [Activatable(typeof (ISyndicationClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class SyndicationClient : ISyndicationClient
  {
    /// <summary>Creates a new SyndicationClient object with authentication credentials.</summary>
    /// <param name="serverCredential">Credentials for user authentication.</param>
    [MethodImpl]
    public extern SyndicationClient(PasswordCredential serverCredential);

    /// <summary>Creates a new SyndicationClient object.</summary>
    [MethodImpl]
    public extern SyndicationClient();

    /// <summary>Gets or sets the credentials to use when making requests to the server.</summary>
    /// <returns>Initally, this value is a username/password tuple. For domain credentials, the username is in domain\user form.</returns>
    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the credentials to use when making requests via a proxy.</summary>
    /// <returns>The PasswordCredential to use.</returns>
    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of bytes to buffer when receiving a response from a server.</summary>
    /// <returns>Maximum size and default is **UInt32.MaxValue**.</returns>
    public extern uint MaxResponseBufferSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum amount of time, in milliseconds, to wait for any of the asynchronous operations to complete. If the operation is not complete within this amount of time, it will fail with a status code indicating that it timed out.</summary>
    /// <returns>Default value is 30000 (30 seconds). A value of **UInt32.MaxValue** indicates that the syndication client will wait indefinitely for a response.</returns>
    public extern uint Timeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a **Boolean** value that specifies whether to bypass the cache when retrieving the feed.</summary>
    /// <returns>**TRUE** if the cache should be bypassed; otherwise **FALSE**.</returns>
    public extern bool BypassCacheOnRetrieve { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets an HTTP header for the request. This method can be called multiple times to set multiple headers. When the same header is set multiple times, the values will be concatenated and separated by ",".</summary>
    /// <param name="name">The name of the header.</param>
    /// <param name="value">The value of the header.</param>
    [MethodImpl]
    public extern void SetRequestHeader(string name, string value);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync(
      Uri uri);
  }
}
