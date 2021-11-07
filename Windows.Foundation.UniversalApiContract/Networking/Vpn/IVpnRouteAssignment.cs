// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnRouteAssignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VpnRouteAssignment))]
  [Guid(3680820770, 52793, 19062, 149, 80, 246, 16, 57, 248, 14, 72)]
  internal interface IVpnRouteAssignment
  {
    IVector<VpnRoute> Ipv4InclusionRoutes { set; get; }

    IVector<VpnRoute> Ipv6InclusionRoutes { set; get; }

    IVector<VpnRoute> Ipv4ExclusionRoutes { set; get; }

    IVector<VpnRoute> Ipv6ExclusionRoutes { set; get; }

    bool ExcludeLocalSubnets { set; get; }
  }
}
