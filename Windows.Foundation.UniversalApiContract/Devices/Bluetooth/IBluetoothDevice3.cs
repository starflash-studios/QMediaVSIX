// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  [Guid(1476392843, 25882, 17492, 185, 15, 235, 33, 239, 11, 13, 113)]
  internal interface IBluetoothDevice3
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    [Overload("GetRfcommServicesAsync")]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync();

    [RemoteAsync]
    [Overload("GetRfcommServicesWithCacheModeAsync")]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetRfcommServicesForIdAsync")]
    [RemoteAsync]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId);

    [Overload("GetRfcommServicesForIdWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);
  }
}
