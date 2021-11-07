// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectAdvertisement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Represents a Wi-Fi Direct advertisement and allows the app to control the listen state and custom information elements in the advertisement.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WiFiDirectAdvertisement : IWiFiDirectAdvertisement, IWiFiDirectAdvertisement2
  {
    /// <summary>Information elements to advertise in the Wi-Fi Direct advertisement.</summary>
    /// <returns>Information elements to advertise.</returns>
    public extern IVector<WiFiDirectInformationElement> InformationElements { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the listen state and whether the Wi-Fi Direct device is discoverable.</summary>
    /// <returns>The listen state and whether the Wi-Fi Direct device is discoverable.</returns>
    public extern WiFiDirectAdvertisementListenStateDiscoverability ListenStateDiscoverability { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Whether autonomous group owner will be enabled.</summary>
    /// <returns>Whether autonomous group owner will be enabled.</returns>
    public extern bool IsAutonomousGroupOwnerEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the settings object for "legacy" (non-Wi-Fi Direct) connections.</summary>
    /// <returns>The legacy settings object.</returns>
    public extern WiFiDirectLegacySettings LegacySettings { [MethodImpl] get; }

    /// <summary>Gets a device's supported configuration methods.</summary>
    /// <returns>A list of WiFiDirectConfigurationMethod values representing supported configuration methods.</returns>
    public extern IVector<WiFiDirectConfigurationMethod> SupportedConfigurationMethods { [MethodImpl] get; }
  }
}
