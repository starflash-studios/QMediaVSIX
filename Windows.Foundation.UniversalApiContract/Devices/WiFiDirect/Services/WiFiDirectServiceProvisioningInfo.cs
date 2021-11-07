// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceProvisioningInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Contains provisioning information about a Wi-Fi Direct Service.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectServiceProvisioningInfo : IWiFiDirectServiceProvisioningInfo
  {
    /// <summary>Gets a value describing the configuration method in use.</summary>
    /// <returns>Enumeration value representing the configuration method in use.</returns>
    public extern WiFiDirectServiceConfigurationMethod SelectedConfigurationMethod { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether Wi-Fi Direct Point to Point (P2P) group formation is needed.</summary>
    /// <returns>When true, group formation is needed.</returns>
    public extern bool IsGroupFormationNeeded { [MethodImpl] get; }
  }
}
