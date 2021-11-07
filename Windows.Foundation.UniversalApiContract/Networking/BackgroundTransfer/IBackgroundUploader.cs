// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  [Guid(3314928046, 52909, 18011, 136, 1, 197, 90, 201, 10, 1, 206)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  internal interface IBackgroundUploader : IBackgroundTransferBase
  {
    UploadOperation CreateUpload(Uri uri, IStorageFile sourceFile);

    [RemoteAsync]
    IAsyncOperation<UploadOperation> CreateUploadFromStreamAsync(
      Uri uri,
      IInputStream sourceStream);

    [RemoteAsync]
    [Overload("CreateUploadWithFormDataAndAutoBoundaryAsync")]
    IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts);

    [Overload("CreateUploadWithSubTypeAsync")]
    [RemoteAsync]
    IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType);

    [Overload("CreateUploadWithSubTypeAndBoundaryAsync")]
    [RemoteAsync]
    IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType,
      string boundary);
  }
}
