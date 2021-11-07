// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommServiceProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3940285892, 45558, 17663, 159, 124, 231, 168, 42, 184, 104, 33)]
  internal interface IRfcommServiceProvider
  {
    RfcommServiceId ServiceId { get; }

    IMap<uint, IBuffer> SdpRawAttributes { get; }

    void StartAdvertising(StreamSocketListener listener);

    void StopAdvertising();
  }
}
