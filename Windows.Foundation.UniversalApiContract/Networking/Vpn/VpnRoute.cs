// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnRoute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a route relative to the VPN channel. It is composed of an address and a prefix size to identify the subnet being routed. The route can then be either included or excluded from the VPN channel scope.</summary>
  [Activatable(typeof (IVpnRouteFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VpnRoute : IVpnRoute
  {
    /// <summary>Constructs a VpnRoute object.</summary>
    /// <param name="address">The ID or the address of the subnet under the route control.</param>
    /// <param name="prefixSize">The size (in bits) to be considered by the subnet.</param>
    [MethodImpl]
    public extern VpnRoute(HostName address, [Range(0, 128)] byte prefixSize);

    /// <summary>Gets or sets the ID or the address of the subnet under the route control.</summary>
    /// <returns>The ID or the address of the subnet under the route control.</returns>
    public extern HostName Address { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the size (in bits) to be considered by the subnet..</summary>
    /// <returns>The size (in bits) to be considered by the subnet.</returns>
    public extern byte PrefixSize { [MethodImpl] [param: Range(0, 128)] set; [MethodImpl] get; }
  }
}
