// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnInterfaceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents an interface ID used in the construction and assignment of an IPv6 address to the VPN interface. The ID contained in this class fills the interface ID portion of the IPv6 address.</summary>
  [Activatable(typeof (IVpnInterfaceIdFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnInterfaceId : IVpnInterfaceId
  {
    /// <summary>Allows the VPN plug-in to construct this object and use it in the VpnChannel.Start method.</summary>
    /// <param name="address">The address represented as a set of bytes.</param>
    [MethodImpl]
    public extern VpnInterfaceId([Range(0, 8)] byte[] address);

    /// <summary>Gets the address represented as the set of bytes to be used as the interface ID.</summary>
    /// <param name="id">The address represented as the set of bytes.</param>
    [MethodImpl]
    public extern void GetAddressInfo(out byte[] id);
  }
}
