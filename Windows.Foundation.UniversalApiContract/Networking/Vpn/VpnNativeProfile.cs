// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnNativeProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Represents a profile for an OS Native/Inbox VPN protocol.</summary>
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VpnNativeProfile : IVpnNativeProfile, IVpnProfile, IVpnNativeProfile2
  {
    /// <summary>Allows a VPN management app to create a native VPN profile.</summary>
    [MethodImpl]
    public extern VpnNativeProfile();

    /// <summary>Gets a list of VPN servers for the Inbox VPN profile.</summary>
    /// <returns>A list of VPN servers for the Inbox VPN profile.</returns>
    public extern IVector<string> Servers { [MethodImpl] get; }

    /// <summary>Gets or sets whether the apps allowed by this traffic filter are force tunneled through the VPN interface, or whether they are split tunneled and allowed to talk through other interfaces.</summary>
    /// <returns>An enum value indicating whether a VPN profile is Split Tunneled or Force Tunneled.</returns>
    public extern VpnRoutingPolicyType RoutingPolicyType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the tunnel protocol type for the Inbox VPN connection.</summary>
    /// <returns>An enum value indicating tunnel protocol type for the Inbox VPN connection.</returns>
    public extern VpnNativeProtocolType NativeProtocolType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the authentication method to be used to authenticate the user.</summary>
    /// <returns>An enum value indicating authentication method to be used to authenticate the user.</returns>
    public extern VpnAuthenticationMethod UserAuthenticationMethod { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the authentication method to be used in the tunnel layer of the native VPN protocol.</summary>
    /// <returns>An enum value indicating authentication method to be used in the tunnel layer of the native VPN protocol.</returns>
    public extern VpnAuthenticationMethod TunnelAuthenticationMethod { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the EAP Authentication configuration for an Inbox/Native VPN profile.</summary>
    /// <returns>The EAP Authentication configuration for an Inbox/Native VPN profile.</returns>
    public extern string EapConfiguration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the profile name for the Inbox/Native VPN profile.</summary>
    /// <returns>The profile name for the Inbox/Native VPN profile.</returns>
    public extern string ProfileName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of apps that can trigger the Inbox VPN profile.</summary>
    /// <returns>A list of apps that can trigger the Inbox VPN profile.</returns>
    public extern IVector<VpnAppId> AppTriggers { [MethodImpl] get; }

    /// <summary>Gets a list of routes that should go over the VPN interface in the case of a Split Tunneled VPN.</summary>
    /// <returns>A list of routes that should go over the VPN interface in the case of a Split Tunneled VPN.</returns>
    public extern IVector<VpnRoute> Routes { [MethodImpl] get; }

    /// <summary>Gets a list of domain name policies to be used for the profile.</summary>
    /// <returns>A list of domain name policies to be used for the profile.</returns>
    public extern IVector<VpnDomainNameInfo> DomainNameInfoList { [MethodImpl] get; }

    /// <summary>Gets a list of Traffic Filters (including per App) included in the VPN profile.</summary>
    /// <returns>A list of Traffic Filters (including per App) included in the VPN profile.</returns>
    public extern IVector<VpnTrafficFilter> TrafficFilters { [MethodImpl] get; }

    /// <summary>Gets or sets whether the credentials for the VPN profile will be cached. If TRUE, the credentials for the VPN profile will be cached where applicable.</summary>
    /// <returns>If the credentials for the VPN profile will be cached, it is TRUE; otherwise , it is FALSE.</returns>
    public extern bool RememberCredentials { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the profile is for Always On VPN.</summary>
    /// <returns>`true` if the VPN profile is always connected, otherwise `false`.</returns>
    public extern bool AlwaysOn { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether this VPN profile appears in the system's VPN connection UI.</summary>
    /// <returns>When true, this profile should appear in the system VPN connection user interface. By default, this value is **false**.</returns>
    public extern bool RequireVpnClientAppUI { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the current connection status.</summary>
    /// <returns>An enumeration value giving current connection status.</returns>
    public extern VpnManagementConnectionStatus ConnectionStatus { [MethodImpl] get; }
  }
}
