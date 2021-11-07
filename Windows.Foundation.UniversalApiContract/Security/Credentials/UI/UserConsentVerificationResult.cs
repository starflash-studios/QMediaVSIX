// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.UserConsentVerificationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Describes the result of a verification operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UserConsentVerificationResult
  {
    /// <summary>The fingerprint was verified.</summary>
    Verified,
    /// <summary>There is no biometric verifier device available.</summary>
    DeviceNotPresent,
    /// <summary>A biometric verifier device is not configured for this user.</summary>
    NotConfiguredForUser,
    /// <summary>Group policy has disabled the biometric verifier device.</summary>
    DisabledByPolicy,
    /// <summary>The biometric verifier device is performing an operation and is unavailable.</summary>
    DeviceBusy,
    /// <summary>After 10 attempts, the original verification request and all subsequent attempts at the same verification were not verified.</summary>
    RetriesExhausted,
    /// <summary>The verification operation was canceled.</summary>
    Canceled,
  }
}
