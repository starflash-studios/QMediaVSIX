// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.DiagnosticsSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  /// <summary>Provides properties and methods to access the user's diagnostics settings.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IDiagnosticsSettingsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DiagnosticsSettings : IDiagnosticsSettings
  {
    /// <summary>Gets a value that indicates whether the user has turned on access to diagnostic data for tailored experiences in the Windows *Feedback &amp; diagnostics* settings.</summary>
    /// <returns>**true** if access to diagnostic data is turned on; otherwise, **false**.</returns>
    public extern bool CanUseDiagnosticsToTailorExperiences { [MethodImpl] get; }

    /// <summary>Gets the User associated with this instance of diagnostics settings.</summary>
    /// <returns>The user associated with this instance of diagnostics settings.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Retrieves the default diagnostics settings.</summary>
    /// <returns>A settings object that contains the user's current diagnostics settings.</returns>
    [MethodImpl]
    public static extern DiagnosticsSettings GetDefault();

    /// <summary>Retrieves the diagnostics settings for the specified user.</summary>
    /// <param name="user">The user to get settings for.</param>
    /// <returns>A settings object that contains the user's current diagnostics settings.</returns>
    [MethodImpl]
    public static extern DiagnosticsSettings GetForUser(User user);
  }
}
