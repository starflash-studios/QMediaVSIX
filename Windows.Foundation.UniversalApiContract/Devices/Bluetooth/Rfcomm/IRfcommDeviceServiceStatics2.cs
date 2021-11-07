// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceServiceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [Guid(2861347273, 59277, 19428, 128, 118, 10, 61, 135, 160, 160, 95)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRfcommDeviceServiceStatics2 : IRfcommDeviceServiceStatics
  {
    [Overload("GetDeviceSelectorForBluetoothDevice")]
    string GetDeviceSelectorForBluetoothDevice(BluetoothDevice bluetoothDevice);

    [Overload("GetDeviceSelectorForBluetoothDeviceWithCacheMode")]
    string GetDeviceSelectorForBluetoothDevice(
      BluetoothDevice bluetoothDevice,
      BluetoothCacheMode cacheMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceId")]
    string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId);

    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode")]
    string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);
  }
}
