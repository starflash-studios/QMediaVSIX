// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnDomainNameAssignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Contains VPN domain name policies, like name resolution, namespace configuration, and web proxies.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class VpnDomainNameAssignment : IVpnDomainNameAssignment
  {
    /// <summary>Allows the plugin to construct a VpnDomainNameAssignment object to create name resolution policy, and assign it to the VPN channel.</summary>
    [MethodImpl]
    public extern VpnDomainNameAssignment();

    /// <summary>Gets a list of name resolution rule policies.</summary>
    /// <returns>A list of name resolution rule policies.</returns>
    public extern IVector<VpnDomainNameInfo> DomainNameList { [MethodImpl] get; }

    /// <summary>Gets or sets the location of the global AutoConfigURL script in the corporate network. [This is an optional property.]</summary>
    /// <returns>The location of the global AutoConfigURL script in the corporate network. [This is an optional property.]</returns>
    public extern Uri ProxyAutoConfigurationUri { [MethodImpl] set; [MethodImpl] get; }
  }
}
