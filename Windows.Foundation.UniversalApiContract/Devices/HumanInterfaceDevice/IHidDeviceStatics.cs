// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ExclusiveTo(typeof (HidDevice))]
  [Guid(2656666084, 38998, 16780, 159, 115, 119, 222, 12, 216, 87, 84)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(ushort usagePage, ushort usageId);

    [Overload("GetDeviceSelectorVidPid")]
    string GetDeviceSelector(ushort usagePage, ushort usageId, ushort vendorId, ushort productId);

    [RemoteAsync]
    IAsyncOperation<HidDevice> FromIdAsync(
      string deviceId,
      FileAccessMode accessMode);
  }
}
