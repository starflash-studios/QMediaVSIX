// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  [Guid(590721366, 37074, 18948, 174, 245, 14, 32, 185, 230, 183, 7)]
  internal interface IBluetoothDevice
  {
    string DeviceId { get; }

    HostName HostName { get; }

    string Name { get; }

    BluetoothClassOfDevice ClassOfDevice { get; }

    IVectorView<IBuffer> SdpRecords { get; }

    IVectorView<RfcommDeviceService> RfcommServices { [Deprecated("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    BluetoothConnectionStatus ConnectionStatus { get; }

    ulong BluetoothAddress { get; }

    event TypedEventHandler<BluetoothDevice, object> NameChanged;

    event TypedEventHandler<BluetoothDevice, object> SdpRecordsChanged;

    event TypedEventHandler<BluetoothDevice, object> ConnectionStatusChanged;
  }
}
