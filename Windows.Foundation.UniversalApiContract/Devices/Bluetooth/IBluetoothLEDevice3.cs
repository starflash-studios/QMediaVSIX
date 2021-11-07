// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2934563987, 17580, 16604, 175, 51, 178, 193, 60, 1, 202, 70)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  internal interface IBluetoothLEDevice3
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [Overload("GetGattServicesAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync();

    [RemoteAsync]
    [Overload("GetGattServicesWithCacheModeAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetGattServicesForUuidAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid);

    [Overload("GetGattServicesForUuidWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);
  }
}
