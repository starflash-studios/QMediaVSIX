// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnInterfaceIdFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Factory to create VpnInterfaceId objects.</summary>
  [Guid(2653805730, 5906, 19684, 177, 121, 140, 101, 44, 109, 16, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnInterfaceIdFactory
  {
    /// <summary>Creates a VpnInterfaceId object.</summary>
    /// <param name="address">The address represented as a set of bytes.</param>
    /// <returns>Represents an interface ID used in the construction and assignment of an IPv6 address to the VPN interface. The ID contained in this class fills the interface ID portion of the IPv6 address.</returns>
    VpnInterfaceId CreateVpnInterfaceId([Range(0, 8)] byte[] address);
  }
}
