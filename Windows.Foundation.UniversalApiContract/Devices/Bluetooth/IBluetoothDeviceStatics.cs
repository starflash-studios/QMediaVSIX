// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothDevice))]
  [Guid(160554833, 22491, 18213, 187, 215, 132, 246, 67, 39, 236, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<BluetoothDevice> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<BluetoothDevice> FromHostNameAsync(
      HostName hostName);

    [RemoteAsync]
    IAsyncOperation<BluetoothDevice> FromBluetoothAddressAsync(
      ulong address);

    string GetDeviceSelector();
  }
}
