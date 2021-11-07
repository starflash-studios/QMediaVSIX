// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3052285819, 19160, 17986, 172, 72, 128, 160, 181, 0, 232, 135)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  internal interface IBluetoothLEDevice
  {
    string DeviceId { get; }

    string Name { get; }

    IVectorView<GattDeviceService> GattServices { [Deprecated("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    BluetoothConnectionStatus ConnectionStatus { get; }

    ulong BluetoothAddress { get; }

    [Deprecated("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    GattDeviceService GetGattService(Guid serviceUuid);

    event TypedEventHandler<BluetoothLEDevice, object> NameChanged;

    event TypedEventHandler<BluetoothLEDevice, object> GattServicesChanged;

    event TypedEventHandler<BluetoothLEDevice, object> ConnectionStatusChanged;
  }
}
