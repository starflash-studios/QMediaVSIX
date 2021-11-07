// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnTrafficFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Defines the traffic filtering properties (including per app VPN). A description of the type of network traffic that will be allowed over the VPN connection, such as a specific application and protocol allowed for the connection.</summary>
  [Activatable(typeof (IVpnTrafficFilterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnTrafficFilter : IVpnTrafficFilter
  {
    /// <summary>Allows a VPN plug-in or VPN management app to create a traffic filter.</summary>
    /// <param name="appId">The app ID associated with the new traffic filter.</param>
    [MethodImpl]
    public extern VpnTrafficFilter(VpnAppId appId);

    /// <summary>Gets or sets the ID of the app that is allowed by this traffic filter.</summary>
    /// <returns>The ID of the app that is allowed by this traffic filter.</returns>
    public extern VpnAppId AppId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a security descriptor specifying the set of checks of claims a process must have to be allowed by this traffic filter.</summary>
    /// <returns>A security descriptor specifying the set of checks of claims a process must have to be allowed by this traffic filter.</returns>
    public extern IVector<string> AppClaims { [MethodImpl] get; }

    /// <summary>Gets or sets the IP protocol that is allowed by this traffic filter.</summary>
    /// <returns>An enum value indicating which IP protocol is allowed by this traffic filter.</returns>
    public extern VpnIPProtocol Protocol { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of the local port ranges that are allowed by this traffic filter. Specially useful for identifying SMB.</summary>
    /// <returns>A list of the local port ranges that are allowed by this traffic filter. Specifically useful for identifying SMB.</returns>
    public extern IVector<string> LocalPortRanges { [MethodImpl] get; }

    /// <summary>Gets a list of the remote port ranges that are allowed by this traffic filter.</summary>
    /// <returns>A list of the remote port ranges that are allowed by this traffic filter.</returns>
    public extern IVector<string> RemotePortRanges { [MethodImpl] get; }

    /// <summary>Gets a list of the local address ranges that are allowed by this traffic filter.</summary>
    /// <returns>A list of the local address ranges that are allowed by this traffic filter.</returns>
    public extern IVector<string> LocalAddressRanges { [MethodImpl] get; }

    /// <summary>Gets a list of the remote address ranges that are allowed by this traffic filter.</summary>
    /// <returns>A list of the remote address ranges that are allowed by this traffic filter.</returns>
    public extern IVector<string> RemoteAddressRanges { [MethodImpl] get; }

    /// <summary>Gets or sets whether the apps allowed by this traffic filter are force tunneled through the VPN interface, or whether they are split tunneled and allowed to talk through other interfaces.</summary>
    /// <returns>An enum value indicating the routing policy.</returns>
    public extern VpnRoutingPolicyType RoutingPolicyType { [MethodImpl] get; [MethodImpl] set; }
  }
}
