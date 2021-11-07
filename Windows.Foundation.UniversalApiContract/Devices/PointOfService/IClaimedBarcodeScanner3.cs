// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [Guid(3872306224, 28974, 17916, 139, 134, 205, 85, 245, 174, 247, 157)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IClaimedBarcodeScanner3
  {
    [RemoteAsync]
    IAsyncOperation<bool> ShowVideoPreviewAsync();

    void HideVideoPreview();

    bool IsVideoPreviewShownOnEnable { set; get; }
  }
}
