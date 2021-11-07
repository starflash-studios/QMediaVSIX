// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnNativeProtocolType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Specifies the native protocol types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnNativeProtocolType
  {
    /// <summary>Point-to-Point Tunneling Protocol (PPTP)</summary>
    Pptp,
    /// <summary>Layer 2 Tunneling Protocol (L2TP)</summary>
    L2tp,
    /// <summary>Internet Protocol Security Internet Key Exchange v2 (IPsec IKEv2)</summary>
    IpsecIkev2,
  }
}
