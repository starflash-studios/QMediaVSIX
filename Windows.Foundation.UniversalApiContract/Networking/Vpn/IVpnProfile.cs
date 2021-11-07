// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Exposes the **VpnProfile** base object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2020980561, 45271, 17371, 138, 147, 211, 254, 36, 121, 229, 106)]
  public interface IVpnProfile
  {
    /// <summary>Gets or sets the name of the VPN profile.</summary>
    /// <returns>The name of the VPN profile.</returns>
    string ProfileName { get; set; }

    /// <summary>Gets a list of apps that will trigger the VPN connection to connect.</summary>
    /// <returns>A list of apps that will trigger the VPN connection to connect.</returns>
    IVector<VpnAppId> AppTriggers { get; }

    /// <summary>Gets a list of routes that must go over the VPN interface in the case of a Split Tunneled VPN.</summary>
    /// <returns>A list of routes that must go over the VPN interface in the case of a Split Tunneled VPN.</returns>
    IVector<VpnRoute> Routes { get; }

    /// <summary>Gets a list of Name Resolution Policy Table (NRPT) rules for the VPN plug-in profile.</summary>
    /// <returns>A list of Name Resolution Policy Table (NRPT) rules for the VPN plug-in profile.</returns>
    IVector<VpnDomainNameInfo> DomainNameInfoList { get; }

    /// <summary>Gets a list of Traffic Filters (including per App) included in the VPN profile.</summary>
    /// <returns>A list of Traffic Filters (including per App) included in the VPN profile.</returns>
    IVector<VpnTrafficFilter> TrafficFilters { get; }

    /// <summary>Gets or sets whether the credentials for the VPN profile will be cached. If TRUE, the credentials for the VPN profile will be cached where applicable.</summary>
    /// <returns>If the credentials for the VPN profile will be cached, it is TRUE; otherwise , it is FALSE.</returns>
    bool RememberCredentials { get; set; }

    /// <summary>Gets or sets the AlwayOn property. If true, indicates that the VPN profile is always connected.</summary>
    /// <returns>If the VPN profile is an AlwaysOn profile, it is TRUE; otherwise , it is FALSE.</returns>
    bool AlwaysOn { get; set; }
  }
}
