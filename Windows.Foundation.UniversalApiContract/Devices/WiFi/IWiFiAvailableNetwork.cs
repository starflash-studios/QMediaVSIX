// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.IWiFiAvailableNetwork
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Devices.WiFi
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiAvailableNetwork))]
  [Guid(652829254, 6206, 18180, 152, 38, 113, 180, 162, 240, 246, 104)]
  internal interface IWiFiAvailableNetwork
  {
    TimeSpan Uptime { get; }

    string Ssid { get; }

    string Bssid { get; }

    int ChannelCenterFrequencyInKilohertz { get; }

    double NetworkRssiInDecibelMilliwatts { get; }

    byte SignalBars { get; }

    WiFiNetworkKind NetworkKind { get; }

    WiFiPhyKind PhyKind { get; }

    NetworkSecuritySettings SecuritySettings { get; }

    TimeSpan BeaconInterval { get; }

    bool IsWiFiDirect { get; }
  }
}
