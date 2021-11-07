// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerDisableScannerRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [Guid(1879499074, 59394, 18165, 182, 4, 53, 42, 21, 206, 146, 50)]
  [ExclusiveTo(typeof (BarcodeScannerDisableScannerRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IBarcodeScannerDisableScannerRequestEventArgs
  {
    BarcodeScannerDisableScannerRequest Request { get; }

    Deferral GetDeferral();
  }
}
