// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceServiceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(100931694, 9382, 19213, 162, 242, 48, 204, 1, 84, 93, 37)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattDeviceService))]
  internal interface IGattDeviceServiceStatics2
  {
    [RemoteAsync]
    [Overload("FromIdWithSharingModeAsync")]
    IAsyncOperation<GattDeviceService> FromIdAsync(
      string deviceId,
      GattSharingMode sharingMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceId")]
    string GetDeviceSelectorForBluetoothDeviceId(BluetoothDeviceId bluetoothDeviceId);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdWithCacheMode")]
    string GetDeviceSelectorForBluetoothDeviceId(
      BluetoothDeviceId bluetoothDeviceId,
      BluetoothCacheMode cacheMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuid")]
    string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode")]
    string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);
  }
}
