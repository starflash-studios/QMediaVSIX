// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferCompletionGroupTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferCompletionGroupTriggerDetails))]
  [Guid(2070667910, 28231, 20790, 127, 203, 250, 67, 137, 244, 111, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBackgroundTransferCompletionGroupTriggerDetails
  {
    IVectorView<DownloadOperation> Downloads { get; }

    IVectorView<UploadOperation> Uploads { get; }
  }
}
