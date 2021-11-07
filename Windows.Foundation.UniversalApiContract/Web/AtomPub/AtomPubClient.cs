// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.AtomPubClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  /// <summary>Encapsulates the methods needed to implement the AtomPub protocol which enables HTTP CRUD access to Web resources using the Atom 1.0 wire format.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAtomPubClientFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class AtomPubClient : IAtomPubClient, ISyndicationClient
  {
    /// <summary>Creates a new AtomPubClient object with the credential to use when making requests to the server. Initially, a 'username/password' tuple. However, for domain credentials, the username must be in 'domain\user form'.</summary>
    /// <param name="serverCredential">The specified security credentials.</param>
    [MethodImpl]
    public extern AtomPubClient(PasswordCredential serverCredential);

    /// <summary>Creates a new AtomPubClient object.</summary>
    [MethodImpl]
    public extern AtomPubClient();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync(
      Uri uri);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync(
      Uri uri,
      string description,
      SyndicationItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync(
      Uri uri,
      string mediaType,
      string description,
      IInputStream mediaStream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync(
      Uri uri,
      string mediaType,
      IInputStream mediaStream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync(
      Uri uri,
      SyndicationItem item);

    /// <summary>Updates an existing Entry or Media Link resource. This differs from the UpdateResourceAsync method in that the EditUri property of the specified SyndicationItem object is used as the Uri of the resource to be updated.</summary>
    /// <param name="item">The resource to be updated.</param>
    /// <returns>The object that is used to update the resource asynchronously and to report the progress and completion status of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync(
      SyndicationItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync(
      Uri uri);

    /// <summary>Deletes an existing Entry or Media Link resource. This differs from the DeleteResourceAsync method in that the SyndicationItem object that represents the resource to be deleted is specified instead of the Uri. The DeleteResourceItemAsync method uses the  property of the specified SyndicationItem as the Uri of the resource to be deleted.</summary>
    /// <param name="item">The resource to be deleted.</param>
    /// <returns>The object that is used to delete the resource asynchronously and to report the progress and completion status of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync(
      SyndicationItem item);

    /// <summary>Cancels any in-progress asynchronous operations, causing them to fail (asynchronously) with an error code indicating cancellation.</summary>
    [MethodImpl]
    public extern void CancelAsyncOperations();

    /// <summary>Gets or sets the credentials to use when making requests to the server.</summary>
    /// <returns>Initially, this value is a username/password tuple. For domain credentials, the username is in domain\user form.</returns>
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
