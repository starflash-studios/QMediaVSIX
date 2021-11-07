// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnNamespaceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>**VpnNamespaceInfo** is not supported and may be altered or unavailable in the future. Instead, use VpnDomainNameInfo.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IVpnNamespaceInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnNamespaceInfo : IVpnNamespaceInfo
  {
    [MethodImpl]
    public extern VpnNamespaceInfo(
      string name,
      IVector<HostName> dnsServerList,
      IVector<HostName> proxyServerList);

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern string Namespace { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern IVector<HostName> DnsServers { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Not supported.</summary>
    /// <returns>Not supported.</returns>
    public extern IVector<HostName> WebProxyServers { [MethodImpl] set; [MethodImpl] get; }
  }
}
