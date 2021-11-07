// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [Guid(1565532055, 14186, 16808, 162, 48, 47, 55, 193, 148, 157, 222)]
  internal interface IClaimedBarcodeScanner4
  {
    event TypedEventHandler<ClaimedBarcodeScanner, ClaimedBarcodeScannerClosedEventArgs> Closed;
  }
}
