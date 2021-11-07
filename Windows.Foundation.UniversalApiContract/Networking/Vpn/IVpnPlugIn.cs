// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnPlugIn
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Provides an interface to implement specific third party VPN client operations.</summary>
  [Guid(3468135687, 53416, 18179, 160, 145, 200, 194, 192, 145, 91, 196)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnPlugIn
  {
    /// <summary>This method instructs the VPN plug-in to connect to the VPN server and establish the VPN channel.</summary>
    /// <param name="channel">The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.</param>
    void Connect(VpnChannel channel);

    /// <summary>This method instructs the VPN plug-in to disconnect from the VPN server and destroy the VPN channel.</summary>
    /// <param name="channel">The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.</param>
    void Disconnect(VpnChannel channel);

    /// <summary>This method instructs the VPN plug-in to compute and return a Keep alive payload ready to be sent to the VPN server.</summary>
    /// <param name="channel">The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.</param>
    /// <param name="keepAlivePacket">An VPN protocol specific message payload used by the VPN Plug-in to indicate to the server that the client and its VPN connection are still alive.</param>
    void GetKeepAlivePayload(VpnChannel channel, out VpnPacketBuffer keepAlivePacket);

    /// <summary>This method instructs the VPN plug-in to prepare the indicated L3 IP packet for transmission to the VPN server. The process might include any encapsulation specific to the VPN protocol.</summary>
    /// <param name="channel">The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.</param>
    /// <param name="packets">An L3 IP packets originated by the client machine TCP/IP stack and that needs to be processed to be sent to the corporate network.</param>
    /// <param name="encapulatedPackets">An buffer containing an encapsulated IP packet (framed in a specific VPN protocol message and or potentially encrypted) that is ready to be sent to the VPN server through the **outerTunnelTransport.**</param>
    void Encapsulate(
      VpnChannel channel,
      VpnPacketBufferList packets,
      VpnPacketBufferList encapulatedPackets);

    /// <summary>This method instructs the VPN plug-in to prepare receive a buffer from the VPN server **outerTunnelTransport**, extract any number of IP packets encapsulated in the buffer, and return the IP packets together with any other reply buffers that are needed to be sent back through the **outerTunnelTransport** to the VPN server.</summary>
    /// <param name="channel">The VPN channel object representing the instance VPN connection of the VPN plug-in to the VPN server.</param>
    /// <param name="encapBuffer">A buffer originated from the VPN server and received through the **outerTunnelTransport.**</param>
    /// <param name="decapsulatedPackets">An **IVpnPacketBuffer** chain representing any L3 IP packets extracted and decapsulated from the buffer and which need to be injected through the VPN interface to be received by the client machine's TCP/IP stack.</param>
    /// <param name="controlPacketsToSend">An **IVpnPacketBuffer** chain representing any control messages that VPN plug-in is required by its protocol specification to reply back to the VPN server.</param>
    void Decapsulate(
      VpnChannel channel,
      VpnPacketBuffer encapBuffer,
      VpnPacketBufferList decapsulatedPackets,
      VpnPacketBufferList controlPacketsToSend);
  }
}
