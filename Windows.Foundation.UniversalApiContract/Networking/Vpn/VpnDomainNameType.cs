// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnDomainNameType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Describes whether a name is a domain name suffix or a fully qualified domain name.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnDomainNameType
  {
    /// <summary>Domain name suffix</summary>
    Suffix = 0,
    /// <summary>Fully qualified domain name (FQDN)</summary>
    FullyQualified = 1,
    /// <summary>Reserved</summary>
    Reserved = 65535, // 0x0000FFFF
  }
}
