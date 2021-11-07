// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3369015833, 61622, 19440, 134, 137, 65, 48, 61, 226, 217, 244)]
  internal interface IBluetoothLEDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<BluetoothLEDevice> FromIdAsync(string deviceId);

    [Overload("FromBluetoothAddressAsync")]
    [RemoteAsync]
    IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress);

    string GetDeviceSelector();
  }
}
