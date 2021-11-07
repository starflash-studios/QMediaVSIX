// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(36552886, 4528, 18064, 149, 71, 11, 57, 197, 175, 33, 20)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (LineDisplay))]
  internal interface ILineDisplayStatics
  {
    [RemoteAsync]
    IAsyncOperation<LineDisplay> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<LineDisplay> GetDefaultAsync();

    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    string GetDeviceSelector(PosConnectionTypes connectionTypes);
  }
}
