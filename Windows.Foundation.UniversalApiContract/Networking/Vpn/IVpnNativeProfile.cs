// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnNativeProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2762924702, 25623, 17203, 152, 66, 240, 166, 109, 182, 152, 2)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnNativeProfile))]
  internal interface IVpnNativeProfile : IVpnProfile
  {
    IVector<string> Servers { get; }

    VpnRoutingPolicyType RoutingPolicyType { get; set; }

    VpnNativeProtocolType NativeProtocolType { get; set; }

    VpnAuthenticationMethod UserAuthenticationMethod { get; set; }

    VpnAuthenticationMethod TunnelAuthenticationMethod { get; set; }

    string EapConfiguration { get; set; }
  }
}
