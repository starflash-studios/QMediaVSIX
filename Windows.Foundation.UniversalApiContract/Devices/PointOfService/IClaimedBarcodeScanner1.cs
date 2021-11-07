// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner1
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [Guid(4128943372, 34129, 17076, 153, 140, 151, 12, 32, 33, 10, 34)]
  internal interface IClaimedBarcodeScanner1
  {
    [RemoteAsync]
    IAsyncAction StartSoftwareTriggerAsync();

    [RemoteAsync]
    IAsyncAction StopSoftwareTriggerAsync();
  }
}
