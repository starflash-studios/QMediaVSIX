// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerSetSymbologyAttributesRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerSetSymbologyAttributesRequestEventArgs))]
  [Guid(2998441993, 38948, 18388, 133, 189, 208, 7, 123, 170, 123, 210)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IBarcodeScannerSetSymbologyAttributesRequestEventArgs
  {
    BarcodeScannerSetSymbologyAttributesRequest Request { get; }

    Deferral GetDeferral();
  }
}
