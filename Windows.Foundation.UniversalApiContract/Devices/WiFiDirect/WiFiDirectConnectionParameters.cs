// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectConnectionParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Used by an app to specify the connection parameters for a Wi-Fi Direct connect/pairing operation.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWiFiDirectConnectionParametersStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class WiFiDirectConnectionParameters : 
    IWiFiDirectConnectionParameters,
    IWiFiDirectConnectionParameters2,
    IDevicePairingSettings
  {
    /// <summary>Creates a new WiFiDirectConnectionParameters object.</summary>
    [MethodImpl]
    public extern WiFiDirectConnectionParameters();

    /// <summary>The group owner intent value used for group owner negotiation in a Wi-Fi Direct connect/pairing operation.</summary>
    /// <returns>The group owner intent value used for group owner negotiation in a Wi-Fi Direct connect/pairing operation.</returns>
    public extern short GroupOwnerIntent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of supported configuration methods, in order of preference.</summary>
    /// <returns>A list of WiFiDirectConfigurationMethod values representing supported configuration methods, in order of preference (most preferred first.)</returns>
    public extern IVector<WiFiDirectConfigurationMethod> PreferenceOrderedConfigurationMethods { [MethodImpl] get; }

    /// <summary>Gets or sets a value specifying a device's preferred pairing procedure.</summary>
    /// <returns>The preferred pairing procedure.</returns>
    public extern WiFiDirectPairingProcedure PreferredPairingProcedure { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of the DevicePairingKinds supporting the given configuration method.</summary>
    /// <param name="configurationMethod">A value specifying a configuration method.</param>
    /// <returns>A value specifying a pairing kind, for use with the pairing functionality in the Windows.Devices.Enumeration API.</returns>
    [MethodImpl]
    public static extern DevicePairingKinds GetDevicePairingKinds(
      WiFiDirectConfigurationMethod configurationMethod);
  }
}
