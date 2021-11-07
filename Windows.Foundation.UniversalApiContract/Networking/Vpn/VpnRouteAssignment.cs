// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnRouteAssignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents the list of routes assigned to the VPN channel for the correct flow and redirection of traffic.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnRouteAssignment : IVpnRouteAssignment
  {
    /// <summary>Allows a VPN plug-in to create the set of routing traffic policy to be set on a VPN channel.</summary>
    [MethodImpl]
    public extern VpnRouteAssignment();

    /// <summary>Gets or sets a list of IPv4 routes that should send traffic over the VPN interface.</summary>
    /// <returns>A list of IPv4 routes that should send traffic over the VPN interface.</returns>
    public extern IVector<VpnRoute> Ipv4InclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a list of IPv6 routes that should always sent traffic over the VPN interface.</summary>
    /// <returns>The list of IPv6 routes that should always sent traffic over the VPN interface.</returns>
    public extern IVector<VpnRoute> Ipv6InclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a list of IPv4 routes that should not sent traffic over the VPN interface.</summary>
    /// <returns>A list of IPv4 routes that should not sent traffic over the VPN interface.</returns>
    public extern IVector<VpnRoute> Ipv4ExclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a list of IPv6 routes that should not sent traffic over the VPN interface.</summary>
    /// <returns>The list of IPv6 routes that should not sent traffic over the VPN interface.</returns>
    public extern IVector<VpnRoute> Ipv6ExclusionRoutes { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the physical infrastructure network, such as the local subnet, should always be exempted from flowing over the VPN interface.</summary>
    /// <returns>If local subnets are excluded, it is **TRUE**; otherwise , it is **FALSE**.</returns>
    public extern bool ExcludeLocalSubnets { [MethodImpl] set; [MethodImpl] get; }
  }
}
