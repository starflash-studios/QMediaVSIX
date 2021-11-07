// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPlugInProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a VPN plug-in profile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VpnPlugInProfile : IVpnPlugInProfile, IVpnProfile, IVpnPlugInProfile2
  {
    /// <summary>Allows VPN management apps to create, edit, and manage, VPN profiles for VPN plug-ins.</summary>
    [MethodImpl]
    public extern VpnPlugInProfile();

    /// <summary>Gets a list of server URIs to connect to for the VPN profile.</summary>
    /// <returns>A list of server URIs to connect to for the VPN profile.</returns>
    public extern IVector<Uri> ServerUris { [MethodImpl] get; }

    /// <summary>Gets or sets an XML string to configure the VPN plug-in. Refer to the documentation from the VPN plug-in for format and support.</summary>
    /// <returns>A string representing the XML to configure the VPN plug-in.</returns>
    public extern string CustomConfiguration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the package family name of the VPN plug-in to be used for this VPN plug-in profile.</summary>
    /// <returns>The package family name of the VPN plug-in to be used for this VPN plug-in profile.</returns>
    public extern string VpnPluginPackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the VPN profile.</summary>
    /// <returns>The name of the VPN profile.</returns>
    public extern string ProfileName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of apps that will trigger the VPN connection to connect.</summary>
    /// <returns>A list of apps that will trigger the VPN connection to connect.</returns>
    public extern IVector<VpnAppId> AppTriggers { [MethodImpl] get; }

    /// <summary>Gets a list of routes that must go over the VPN interface in the case of a Split Tunneled VPN.</summary>
    /// <returns>A list of routes that must go over the VPN interface in the case of a Split Tunneled VPN.</returns>
    public extern IVector<VpnRoute> Routes { [MethodImpl] get; }

    /// <summary>Gets a list of Name Resolution Policy Table (NRPT) rules for the VPN plug-in profile.</summary>
    /// <returns>A list of Name Resolution Policy Table (NRPT) rules for the VPN plug-in profile.</returns>
    public extern IVector<VpnDomainNameInfo> DomainNameInfoList { [MethodImpl] get; }

    /// <summary>Gets a list of Traffic Filters (including per App) included in the VPN profile.</summary>
    /// <returns>A list of Traffic Filters (including per App) included in the VPN profile.</returns>
    public extern IVector<VpnTrafficFilter> TrafficFilters { [MethodImpl] get; }

    /// <summary>Gets or sets whether the credentials for the VPN profile will be cached. If TRUE, the credentials for the VPN profile will be cached where applicable.</summary>
    /// <returns>If the credentials for the VPN profile will be cached, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool RememberCredentials { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the AlwayOn property. If true, indicates that the VPN profile is always connected.</summary>
    /// <returns>If the VPN profile is an AlwaysOn profile, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool AlwaysOn { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether this VPN profile appears in the system's VPN connection UI.</summary>
    /// <returns>When true, this profile should appear in the system VPN connection user interface. By default, this value is **false**.</returns>
    public extern bool RequireVpnClientAppUI { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the current connection status.</summary>
    /// <returns>An enumeration value giving current connection status.</returns>
    public extern VpnManagementConnectionStatus ConnectionStatus { [MethodImpl] get; }
  }
}
