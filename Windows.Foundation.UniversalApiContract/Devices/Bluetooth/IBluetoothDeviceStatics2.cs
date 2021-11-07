// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDeviceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3265170991, 19988, 17527, 170, 27, 184, 180, 126, 91, 126, 206)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IBluetoothDeviceStatics2
  {
    string GetDeviceSelectorFromPairingState(bool pairingState);

    string GetDeviceSelectorFromConnectionStatus(BluetoothConnectionStatus connectionStatus);

    string GetDeviceSelectorFromDeviceName(string deviceName);

    string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    string GetDeviceSelectorFromClassOfDevice(BluetoothClassOfDevice classOfDevice);
  }
}
