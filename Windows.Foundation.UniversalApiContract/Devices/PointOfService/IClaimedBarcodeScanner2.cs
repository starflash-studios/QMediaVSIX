// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3820330636, 11659, 20336, 138, 243, 52, 72, 190, 221, 95, 226)]
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IClaimedBarcodeScanner2
  {
    [RemoteAsync]
    IAsyncOperation<BarcodeSymbologyAttributes> GetSymbologyAttributesAsync(
      uint barcodeSymbology);

    [RemoteAsync]
    IAsyncOperation<bool> SetSymbologyAttributesAsync(
      uint barcodeSymbology,
      BarcodeSymbologyAttributes attributes);
  }
}
