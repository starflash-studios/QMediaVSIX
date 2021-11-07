// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDeviceCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Identity.Provider
{
  /// <summary>Represents the capabilities of the companion device.</summary>
  /// <deprecated type="deprecate">SecondaryAuthenticationFactorDeviceCapabilities is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Flags]
  [Deprecated("SecondaryAuthenticationFactorDeviceCapabilities is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public enum SecondaryAuthenticationFactorDeviceCapabilities : uint
  {
    /// <summary>No capabilities.</summary>
    None = 0,
    /// <summary>Set this flag if the companion device supports secure storage and can protect auth key and device key from unauthorized access. In order to make sure your key storage meets the security bar, contact cdfonboardmicrosoft.com.</summary>
    SecureStorage = 1,
    /// <summary>Set this flag if the companion device stores the auth key and device keys.</summary>
    StoreKeys = 2,
    /// <summary>Set this flag if the companion device can confirm user intent to authenticate.</summary>
    ConfirmUserIntentToAuthenticate = 4,
    /// <summary>**Deprecated.** Set this flag if the companion device supports securely confirming the user's identity and presence. In order to make sure your user presence check meets the security bar, contact cdfonboardmicrosoft.com.</summary>
    /// <deprecated type="deprecate">SupportSecureUserPresenceCheck is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("SupportSecureUserPresenceCheck is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 458752, "Windows.Foundation.UniversalApiContract")] SupportSecureUserPresenceCheck = 8,
    /// <summary>Set this flag if the companion device transmits auth keys and devices key over an encrypted channel.</summary>
    TransmittedDataIsEncrypted = 16, // 0x00000010
    /// <summary>The device supports HMacSha256.</summary>
    HMacSha256 = 32, // 0x00000020
    /// <summary>The device supports close range data transmission.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] CloseRangeDataTransmission = 64, // 0x00000040
  }
}
