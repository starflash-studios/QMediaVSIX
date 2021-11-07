// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnRouteFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Factory to create VpnRoute objects.</summary>
  [Guid(3186275839, 17871, 19353, 131, 251, 219, 59, 194, 103, 43, 2)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnRouteFactory
  {
    /// <summary>Creates VpnRoute objects.</summary>
    /// <param name="address">Represents the ID or the address of the subnet under the route control.</param>
    /// <param name="prefixSize">The size (in bits) to be considered by the subnet.</param>
    /// <returns>Represents a route relative to the VPN channel. It is composed of an address and a prefix size to identify the subnet being routed.</returns>
    VpnRoute CreateVpnRoute(HostName address, [Range(0, 128)] byte prefixSize);
  }
}
