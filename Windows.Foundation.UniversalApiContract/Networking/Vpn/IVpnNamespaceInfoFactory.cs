// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNamespaceInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>**IVpnNamespaceInfoFactory** is not supported and may be altered or unavailable in the future. Instead, use IVpnDomainNameInfoFactory.</summary>
  [Guid(3409876250, 45262, 17451, 172, 187, 95, 153, 178, 2, 195, 28)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnNamespaceInfoFactory
  {
    VpnNamespaceInfo CreateVpnNamespaceInfo(
      string name,
      IVector<HostName> dnsServerList,
      IVector<HostName> proxyServerList);
  }
}
