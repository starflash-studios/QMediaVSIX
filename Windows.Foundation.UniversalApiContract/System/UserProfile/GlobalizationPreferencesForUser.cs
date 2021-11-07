// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.GlobalizationPreferencesForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.System.UserProfile
{
  /// <summary>A class for holding the various globalization preferences of a user. This API is part of support for multi-user apps (MUA).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GlobalizationPreferencesForUser : IGlobalizationPreferencesForUser
  {
    /// <summary>Gets the user represented by this class instance.</summary>
    /// <returns>The represented user.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the set of calendars that are preferred by the represented user, in order of preference.</summary>
    /// <returns>One or more calendar identifiers.</returns>
    public extern IVectorView<string> Calendars { [MethodImpl] get; }

    /// <summary>Gets the set of clocks that are preferred by the represented user, in order of preference.</summary>
    /// <returns>One or more clock identifiers.</returns>
    public extern IVectorView<string> Clocks { [MethodImpl] get; }

    /// <summary>Gets the set of currencies that are preferred by the represented user, in order of preference.</summary>
    /// <returns>One or more currency identifiers.</returns>
    public extern IVectorView<string> Currencies { [MethodImpl] get; }

    /// <summary>Gets the set of languages that are preferred by the represented user, in order of preference.</summary>
    /// <returns>One or more language identifiers.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets the represented user's home geographic region.</summary>
    /// <returns>A geographic region identifier.</returns>
    public extern string HomeGeographicRegion { [MethodImpl] get; }

    /// <summary>Gets the day of the week that is considered by the represented user to be the first day of the week.</summary>
    /// <returns>The day of the week that the week starts on.</returns>
    public extern DayOfWeek WeekStartsOn { [MethodImpl] get; }
  }
}
