// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnDomainNameInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Specifies the name policy for a specific namespace. It can specify the DNS servers to use for name resolution of the namespace, the web proxies to use when connecting to the namespace, or whether it should be exempted from the policy itself.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IVpnDomainNameInfoFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class VpnDomainNameInfo : IVpnDomainNameInfo, IVpnDomainNameInfo2
  {
    [MethodImpl]
    public extern VpnDomainNameInfo(
      string name,
      VpnDomainNameType nameType,
      IIterable<HostName> dnsServerList,
      IIterable<HostName> proxyServerList);

    /// <summary>Gets or sets the domain name. This could be an FQDN, or a DNS suffix.</summary>
    /// <returns>The domain name. This could be an FQDN, or a DNS suffix.</returns>
    public extern HostName DomainName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the namespace in question is a FQDN, or a DNS suffix.</summary>
    /// <returns>An enum value indicating whether the namespace in question is a FQDN, or a DNS suffix.</returns>
    public extern VpnDomainNameType DomainNameType { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a list of DNS servers to perform DNS resolution against when resolving a name in the namespace.</summary>
    /// <returns>A list of DNS servers to perform DNS resolution against when resolving a name in the namespace.</returns>
    public extern IVector<HostName> DnsServers { [MethodImpl] get; }

    /// <summary>Gets a list of web proxy servers to be used when connecting to a resource in the specified namespace.</summary>
    /// <returns>A list of web proxy servers to be used when connecting to a resource in the specified namespace.</returns>
    public extern IVector<HostName> WebProxyServers { [MethodImpl] get; }

    /// <summary>Gets a web proxy URI to be used when connecting to a resource in the specified namespace. This value differs from WebProxyServers in that the URI can be specify a custom port number, while the WebProxyServers value assumes port 80.</summary>
    /// <returns>A list of web proxy server URIs to be used when connecting to a resource in the specified namespace.</returns>
    public extern IVector<Uri> WebProxyUris { [MethodImpl] get; }
  }
}
