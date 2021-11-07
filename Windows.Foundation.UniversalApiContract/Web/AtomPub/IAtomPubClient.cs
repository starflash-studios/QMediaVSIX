// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IAtomPubClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Syndication;

namespace Windows.Web.AtomPub
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(892939320, 52717, 19788, 150, 55, 5, 241, 92, 28, 148, 6)]
  [ExclusiveTo(typeof (AtomPubClient))]
  internal interface IAtomPubClient : ISyndicationClient
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync(
      Uri uri,
      string description,
      SyndicationItem item);

    [RemoteAsync]
    IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync(
      Uri uri,
      string mediaType,
      string description,
      IInputStream mediaStream);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync(
      Uri uri,
      string mediaType,
      IInputStream mediaStream);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync(
      Uri uri,
      SyndicationItem item);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync(
      SyndicationItem item);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync(
      Uri uri);

    [RemoteAsync]
    IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync(
      SyndicationItem item);

    void CancelAsyncOperations();
  }
}
