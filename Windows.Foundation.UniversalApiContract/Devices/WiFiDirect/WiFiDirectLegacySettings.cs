// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectLegacySettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Settings governing "legacy" mode (non-Wi-Fi Direct connections to the access point being advertised.)</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectLegacySettings : IWiFiDirectLegacySettings
  {
    /// <summary>Gets or sets a value specifying whether "legacy mode" is enabled. When enabled, this mode causes this device to act as a normal Wi-Fi access point, and is intended to support devices which do not support connection via Wi-Fi Direct.</summary>
    /// <returns>When true, "legacy mode" is enabled.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Service Set Identifier (SSID, or "access point ID").</summary>
    /// <returns>The SSID for the access point. This access point functions as a normal Wi-Fi access point, and is intended to support devices which do not support connection via Wi-Fi Direct.</returns>
    public extern string Ssid { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the pass phrase used by non-Wi-Fi Direct clients to connect to this access point in "legacy mode".</summary>
    /// <returns>The pass phrase for the Wi-Fi network. This access point functions as a normal Wi-Fi access point, and is intended to support devices which do not support connection via Wi-Fi Direct.</returns>
    public extern PasswordCredential Passphrase { [MethodImpl] get; [MethodImpl] set; }
  }
}
