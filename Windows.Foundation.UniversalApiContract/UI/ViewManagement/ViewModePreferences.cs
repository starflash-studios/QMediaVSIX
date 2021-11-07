// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ViewModePreferences
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Represents the preferred settings to be applied to a view when it's changed to a new view mode.</summary>
  [Static(typeof (IViewModePreferencesStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ViewModePreferences : IViewModePreferences
  {
    /// <summary>Gets or sets the preferred size of the app window.</summary>
    /// <returns>A value of the enumeration that indicates the preferred size of the app window.</returns>
    public extern ViewSizePreference ViewSizePreference { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a custom preferred size for the app window.</summary>
    /// <returns>The preferred size for the app window.</returns>
    public extern Size CustomSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a new instance of **ViewModePreferences** with default property values set for the specified view mode.</summary>
    /// <param name="mode">The view mode to set default preferences for.</param>
    /// <returns>A new instance of **ViewModePreferences** with default property values set for the specified view mode.</returns>
    [MethodImpl]
    public static extern ViewModePreferences CreateDefault(
      ApplicationViewMode mode);
  }
}
