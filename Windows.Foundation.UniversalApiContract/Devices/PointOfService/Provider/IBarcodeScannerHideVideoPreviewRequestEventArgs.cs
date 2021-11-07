// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerHideVideoPreviewRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerHideVideoPreviewRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(379748860, 54974, 19399, 157, 241, 51, 116, 31, 62, 173, 234)]
  internal interface IBarcodeScannerHideVideoPreviewRequestEventArgs
  {
    BarcodeScannerHideVideoPreviewRequest Request { get; }

    Deferral GetDeferral();
  }
}
