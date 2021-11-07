// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerSetActiveSymbologiesRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [Guid(103832314, 31734, 19794, 128, 26, 51, 2, 114, 246, 10, 225)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BarcodeScannerSetActiveSymbologiesRequestEventArgs))]
  internal interface IBarcodeScannerSetActiveSymbologiesRequestEventArgs
  {
    BarcodeScannerSetActiveSymbologiesRequest Request { get; }

    Deferral GetDeferral();
  }
}
