// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1561419631, 55881, 16872, 140, 140, 240, 203, 98, 169, 196, 252)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BarcodeScanner))]
  internal interface IBarcodeScannerStatics
  {
    [RemoteAsync]
    IAsyncOperation<BarcodeScanner> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<BarcodeScanner> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
