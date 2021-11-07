// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploader2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2382762702, 3124, 17507, 128, 127, 25, 138, 27, 139, 212, 173)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  internal interface IBackgroundUploader2
  {
    BackgroundTransferGroup TransferGroup { get; set; }

    ToastNotification SuccessToastNotification { get; set; }

    ToastNotification FailureToastNotification { get; set; }

    TileNotification SuccessTileNotification { get; set; }

    TileNotification FailureTileNotification { get; set; }
  }
}
