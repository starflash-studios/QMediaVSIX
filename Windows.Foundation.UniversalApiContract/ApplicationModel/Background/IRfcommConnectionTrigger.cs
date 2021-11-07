// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IRfcommConnectionTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (RfcommConnectionTrigger))]
  [Guid(3905211106, 2899, 17508, 147, 148, 253, 135, 86, 84, 222, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRfcommConnectionTrigger : IBackgroundTrigger
  {
    RfcommInboundConnectionInformation InboundConnection { get; }

    RfcommOutboundConnectionInformation OutboundConnection { get; }

    bool AllowMultipleConnections { get; set; }

    SocketProtectionLevel ProtectionLevel { get; set; }

    HostName RemoteHostName { get; set; }
  }
}
