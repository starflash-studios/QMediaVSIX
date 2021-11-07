// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnChannelConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>The configuration of the VpnChannel, which dictates how to establish the communication with the VPN server.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnChannelConfiguration : IVpnChannelConfiguration, IVpnChannelConfiguration2
  {
    /// <summary>Gets the service name of the VPN server listening for remote access connections.</summary>
    /// <returns>The service name of the VPN server listening for remote access connections. Also known as the VPN server port.</returns>
    public extern string ServerServiceName { [MethodImpl] get; }

    /// <summary>Gets the server hostname of the VPN server to which the VPN plug-in should connect.</summary>
    /// <returns>The server hostname of the VPN server to which the VPN plug-in should connect.</returns>
    public extern IVectorView<HostName> ServerHostNameList { [MethodImpl] get; }

    /// <summary>Gets the custom configuration as a string which the VPN plug-in parses to configure VPN vendor specific settings. The field is a string to allow XML as the data format of the configuration.</summary>
    /// <returns>The custom configuration string data which the VPN plug-in parses to configure VPN vendor specific settings.</returns>
    public extern string CustomField { [MethodImpl] get; }

    /// <summary>Gets the list of URIs that describe the VPN servers to connect to and the URI to use when connecting to them. This is analogous to the ServerHostNames, but are in URI format which allows for more information to be carried per server.</summary>
    /// <returns>The list of URIs that describe the VPN servers to connect to and the URI to use when connecting to them.</returns>
    public extern IVectorView<Uri> ServerUris { [MethodImpl] get; }
  }
}
