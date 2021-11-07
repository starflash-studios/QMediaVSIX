// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [Guid(2927755039, 50593, 19520, 140, 40, 243, 239, 214, 144, 98, 243)]
  internal interface IRfcommDeviceService
  {
    HostName ConnectionHostName { get; }

    string ConnectionServiceName { get; }

    RfcommServiceId ServiceId { get; }

    SocketProtectionLevel ProtectionLevel { get; }

    SocketProtectionLevel MaxProtectionLevel { get; }

    [RemoteAsync]
    [Overload("GetSdpRawAttributesAsync")]
    IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync();

    [RemoteAsync]
    [Overload("GetSdpRawAttributesWithCacheModeAsync")]
    IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync(
      BluetoothCacheMode cacheMode);
  }
}
