// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.GlobalizationPreferences
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
  /// <summary>A static class for holding various user globalization preferences.</summary>
  [Static(typeof (IGlobalizationPreferencesStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGlobalizationPreferencesStatics3), 393216, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IGlobalizationPreferencesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class GlobalizationPreferences
  {
    /// <summary>Retrieves an object representing the globalization preferences of the specified user. This API is part of support for multi-user apps (MUA).</summary>
    /// <param name="user">The user to retrieve preferences for.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern GlobalizationPreferencesForUser GetForUser(
      User user);

    /// <summary>Attempts to set the user's home geographic region on an IoT device.</summary>
    /// <param name="region">The GeographicRegion identifier that represents the user's home location.</param>
    /// <returns>**true** if HomeGeographicRegion was set; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TrySetHomeGeographicRegion(string region);

    [MethodImpl]
    public static extern bool TrySetLanguages(IIterable<string> languageTags);

    /// <summary>Gets the set of calendars that are preferred by the user, in order of preference.</summary>
    /// <returns>One or more calendar identifiers for the user's preferred calendars.</returns>
    public static extern IVectorView<string> Calendars { [MethodImpl] get; }

    /// <summary>Gets the set of clocks that are preferred by the user, in order of preference.</summary>
    /// <returns>One or more clock identifiers for the user's preferred clocks.</returns>
    public static extern IVectorView<string> Clocks { [MethodImpl] get; }

    /// <summary>Gets the set of currencies that are preferred by the user, in order of preference.</summary>
    /// <returns>One or more currency identifiers for the user's preferred currencies.</returns>
    public static extern IVectorView<string> Currencies { [MethodImpl] get; }

    /// <summary>Gets the set of languages that are preferred by the user, in order of preference.</summary>
    /// <returns>One or more language identifiers for the user's preferred languages.</returns>
    public static extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets the user's home geographic region.</summary>
    /// <returns>The GeographicRegion identifier that represents the user's home location.</returns>
    public static extern string HomeGeographicRegion { [MethodImpl] get; }

    /// <summary>Gets the day of the week that is considered to be the first day of the week.</summary>
    /// <returns>The day of the week that the week starts on.</returns>
    public static extern DayOfWeek WeekStartsOn { [MethodImpl] get; }
  }
}
