// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Specifies the set of app view state changes that can be handled.</summary>
  /// <deprecated type="deprecate">ApplicationViewState may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.</deprecated>
  [Deprecated("ApplicationViewState may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ApplicationViewState
  {
    /// <summary>The current app's view is in full-screen (has no snapped app adjacent to it), and has changed to landscape orientation.</summary>
    FullScreenLandscape,
    /// <summary>The current app's view has been reduced to a partial screen view as the result of another app snapping.</summary>
    Filled,
    /// <summary>The current app's view has been snapped.</summary>
    Snapped,
    /// <summary>The current app's view is in full-screen (has no snapped app adjacent to it), and has changed to portrait orientation.</summary>
    FullScreenPortrait,
  }
}
