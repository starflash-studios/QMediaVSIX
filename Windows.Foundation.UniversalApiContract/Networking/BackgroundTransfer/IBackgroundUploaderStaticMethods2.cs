// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploaderStaticMethods2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3910773858, 59912, 17136, 162, 172, 7, 228, 103, 84, 144, 128)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  internal interface IBackgroundUploaderStaticMethods2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsForTransferGroupAsync(
      BackgroundTransferGroup group);
  }
}
