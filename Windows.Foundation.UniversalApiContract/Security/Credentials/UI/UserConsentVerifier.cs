// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.UserConsentVerifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Checks for availability of a verification device (such as a Microsoft Passport PIN, Windows Hello biometric, or fingerprint reader) and performs a verification.</summary>
  [Static(typeof (IUserConsentVerifierStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class UserConsentVerifier
  {
    /// <summary>Checks to see whether a verifier device, such as a Microsoft Passport PIN, Windows Hello, or fingerprint reader, is available.</summary>
    /// <returns>A UserConsentVerifierAvailability value that describes the result of the availability check operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UserConsentVerifierAvailability> CheckAvailabilityAsync();

    /// <summary>Performs a verification using a device such as Microsoft Passport PIN, Windows Hello, or a fingerprint reader.</summary>
    /// <param name="message">A message to display to the user for this biometric verification request.</param>
    /// <returns>A UserConsentVerificationResult value that describes the result of the biometric verification.</returns>
    [MethodImpl]
    public static extern IAsyncOperation<UserConsentVerificationResult> RequestVerificationAsync(
      string message);
  }
}
