// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedLineDisplayStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedLineDisplay))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2026543355, 35691, 18803, 134, 240, 62, 87, 12, 53, 24, 37)]
  internal interface IClaimedLineDisplayStatics
  {
    [RemoteAsync]
    IAsyncOperation<ClaimedLineDisplay> FromIdAsync(string deviceId);

    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
