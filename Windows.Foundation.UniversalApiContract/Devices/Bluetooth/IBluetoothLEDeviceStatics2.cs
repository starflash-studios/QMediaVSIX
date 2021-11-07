// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDeviceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(1595064427, 15276, 17384, 173, 22, 86, 50, 113, 189, 65, 194)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IBluetoothLEDeviceStatics2
  {
    string GetDeviceSelectorFromPairingState(bool pairingState);

    string GetDeviceSelectorFromConnectionStatus(BluetoothConnectionStatus connectionStatus);

    string GetDeviceSelectorFromDeviceName(string deviceName);

    [Overload("GetDeviceSelectorFromBluetoothAddress")]
    string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    [Overload("GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType")]
    string GetDeviceSelectorFromBluetoothAddress(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);

    string GetDeviceSelectorFromAppearance(BluetoothLEAppearance appearance);

    [Overload("FromBluetoothAddressWithBluetoothAddressTypeAsync")]
    [RemoteAsync]
    IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);
  }
}
