// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUploadOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (UploadOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1045832928, 29577, 17228, 139, 53, 66, 127, 211, 107, 189, 174)]
  internal interface IUploadOperation : IBackgroundTransferOperation
  {
    IStorageFile SourceFile { get; }

    BackgroundUploadProgress Progress { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();
  }
}
