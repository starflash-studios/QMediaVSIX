// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiAvailableNetwork
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Devices.WiFi
{
  /// <summary>Describes an available Wi-Fi network.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiAvailableNetwork : IWiFiAvailableNetwork
  {
    /// <summary>Gets the uptime value reported by the network.</summary>
    /// <returns>TimeSpan value representing the value of the Timestamp field from the 802.11 Beacon or Probe Response frame received by the wireless LAN interface.</returns>
    public extern TimeSpan Uptime { [MethodImpl] get; }

    /// <summary>Gets the SSID (name) of the network.</summary>
    /// <returns>The network SSID.</returns>
    public extern string Ssid { [MethodImpl] get; }

    /// <summary>Gets the MAC address of the access point.</summary>
    /// <returns>The MAC address of the access point, formatted as xx:xx:xx:xx:xx:xx with always lower-case characters.</returns>
    public extern string Bssid { [MethodImpl] get; }

    /// <summary>Gets the channel center frequency of the band on which the 802.11 Beacon or Probe Response was received.</summary>
    /// <returns>The channel center frequency of the band on which the 802.11 Beacon or Probe Response frame was received. The value of this property is in units of kilohertz (kHz). Note that this member is only valid for PHY types that are not frequency-hopping spread spectrum (FHSS). In all other cases the value returned is zero.</returns>
    public extern int ChannelCenterFrequencyInKilohertz { [MethodImpl] get; }

    /// <summary>Gets the signal strength of the network.</summary>
    /// <returns>The signal strength, expressed in dBm.</returns>
    public extern double NetworkRssiInDecibelMilliwatts { [MethodImpl] get; }

    /// <summary>Gets the strength of the signal as a number of bars.</summary>
    /// <returns>The current number of signal bars displayed by the Windows UI for the network.</returns>
    public extern byte SignalBars { [MethodImpl] get; }

    /// <summary>Gets a value describing the kind of network being described.</summary>
    /// <returns>A WiFiNetworkKind enumeration member indicating the BSS network type.</returns>
    public extern WiFiNetworkKind NetworkKind { [MethodImpl] get; }

    /// <summary>Gets a value describing the kind of PHY used by this network.</summary>
    /// <returns>A WiFiPhyKind value indicating the PHY kind of the network.</returns>
    public extern WiFiPhyKind PhyKind { [MethodImpl] get; }

    /// <summary>Gets the security configuration of the network.</summary>
    /// <returns>An Instance of Windows.Networking.Connectivity.NetworkSecuritySettings describing the security configuration of the network.</returns>
    public extern NetworkSecuritySettings SecuritySettings { [MethodImpl] get; }

    /// <summary>Gets the interval between 802.11 Beacon frames used by this network.</summary>
    /// <returns>A TimeSpan representing the interval between beacons on this network.</returns>
    public extern TimeSpan BeaconInterval { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether this network originates from a Wi-Fi Direct access point.</summary>
    /// <returns>When true, the network is originated by a Wi-Fi Direct access point. Otherwise, it is not.</returns>
    public extern bool IsWiFiDirect { [MethodImpl] get; }
  }
}
