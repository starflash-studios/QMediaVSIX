// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNamespaceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ExclusiveTo(typeof (VpnNamespaceInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(820902723, 17487, 17605, 129, 103, 163, 90, 145, 241, 175, 148)]
  internal interface IVpnNamespaceInfo
  {
    string Namespace { set; get; }

    IVector<HostName> DnsServers { set; get; }

    IVector<HostName> WebProxyServers { set; get; }
  }
}
