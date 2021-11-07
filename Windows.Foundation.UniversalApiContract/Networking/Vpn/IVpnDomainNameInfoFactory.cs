// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnDomainNameInfoFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Factory to create VpnDomainNameInfo objects.</summary>
  [Guid(621263733, 655, 18056, 141, 58, 196, 83, 29, 243, 125, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnDomainNameInfoFactory
  {
    VpnDomainNameInfo CreateVpnDomainNameInfo(
      string name,
      VpnDomainNameType nameType,
      IIterable<HostName> dnsServerList,
      IIterable<HostName> proxyServerList);
  }
}
