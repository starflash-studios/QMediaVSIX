// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.TetheringCapability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines values that can be returned after calling NetworkOperatorTetheringManager.GetTetheringCapability to indicate the tethering capabilities of a network account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TetheringCapability
  {
    /// <summary>Tethering is enabled.</summary>
    Enabled,
    /// <summary>Tethering is disabled according to the current group policy.</summary>
    DisabledByGroupPolicy,
    /// <summary>Tethering not available due to hardware limitations.</summary>
    DisabledByHardwareLimitation,
    /// <summary>Tethering operations disabled for this account by the network operator.</summary>
    DisabledByOperator,
    /// <summary>Tethering is not supported by the current account services.</summary>
    DisabledBySku,
    /// <summary>An application required for tethering operations is not available.</summary>
    DisabledByRequiredAppNotInstalled,
    /// <summary>Tethering is disabled for unknown reasons.</summary>
    DisabledDueToUnknownCause,
    /// <summary>Tethering has been disabled by the system because the app lacks the necessary **DeviceCapability** entry in its manifest. See CreateFromConnectionProfile for more information about manifest requirements.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DisabledBySystemCapability,
  }
}
