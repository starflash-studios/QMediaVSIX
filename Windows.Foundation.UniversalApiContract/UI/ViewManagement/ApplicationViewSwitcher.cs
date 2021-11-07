// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationViewSwitcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  /// <summary>Represents the app view switching behaviors for an app.</summary>
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IApplicationViewSwitcherStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewSwitcherStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IApplicationViewSwitcherStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ApplicationViewSwitcher
  {
    /// <summary>Displays a view as a standalone view in the desired view mode.</summary>
    /// <param name="viewId">The ID of the window to display.</param>
    /// <param name="viewMode">The desired view mode for the window.</param>
    /// <returns>Asynchronously returns **true** if the call succeeds; **false** if it does not.</returns>
    [Overload("TryShowAsViewModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode);

    /// <summary>Displays a view as a standalone view in the desired view mode with the specified options.</summary>
    /// <param name="viewId">The ID of the window to display.</param>
    /// <param name="viewMode">The desired view mode for the window.</param>
    /// <param name="viewModePreferences">Preferred settings for the desired view mode.</param>
    /// <returns>Asynchronously returns **true** if the call succeeds; **false** if it does not.</returns>
    [RemoteAsync]
    [Overload("TryShowAsViewModeWithPreferencesAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);

    /// <summary>Disables Windows shell control of the view selection on activation, and lets the app handle it instead.</summary>
    [MethodImpl]
    public static extern void DisableSystemViewActivationPolicy();

    /// <summary>Disables the primary window (app view) when the app is activated, showing the most recently displayed window instead.</summary>
    [MethodImpl]
    public static extern void DisableShowingMainViewOnActivation();

    /// <summary>Displays another window (app view) for the app on the screen, adjacent to the original window</summary>
    /// <param name="viewId">The ID of the new window to display.</param>
    /// <returns>Asynchronously returns **true** if the call succeeds; **false** if it does not.</returns>
    [RemoteAsync]
    [Overload("TryShowAsStandaloneAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsStandaloneAsync(int viewId);

    /// <summary>Displays another window (app view) for the app on the screen, adjacent to the original window</summary>
    /// <param name="viewId">The ID of the new window to display.</param>
    /// <param name="sizePreference">The preferred general sizing of the new window.</param>
    /// <returns>Asynchronously returns **true** if the call succeeds; **false** if it does not.</returns>
    [RemoteAsync]
    [Overload("TryShowAsStandaloneWithSizePreferenceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference);

    /// <summary>Displays another window (app view) for the app on the screen, adjacent to the original window.</summary>
    /// <param name="viewId">The ID of the new window to display.</param>
    /// <param name="sizePreference">The preferred general sizing of the new window.</param>
    /// <param name="anchorViewId">The ID of the calling (anchor) window.</param>
    /// <param name="anchorSizePreference">The preferred new general sizing of the calling window if this call succeeds.</param>
    /// <returns>Asynchronously returns **true** if the call succeeds; **false** if it does not.</returns>
    [RemoteAsync]
    [Overload("TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference,
      int anchorViewId,
      ViewSizePreference anchorSizePreference);

    /// <summary>Visually replaces the calling window (app view) with a specified window.</summary>
    /// <param name="viewId">The ID of the window under preparation for display.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [RemoteAsync]
    [Overload("SwitchAsync")]
    [MethodImpl]
    public static extern IAsyncAction SwitchAsync(int viewId);

    /// <summary>Visually replaces the calling window (app view) with a specified window.</summary>
    /// <param name="toViewId">The ID of the window under preparation for display.</param>
    /// <param name="fromViewId">The ID of the calling, currently displayed window.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [Overload("SwitchFromViewAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SwitchAsync(int toViewId, int fromViewId);

    /// <summary>Visually replaces the calling window (app view) with a specified window.</summary>
    /// <param name="toViewId">The ID of the window under preparation for display.</param>
    /// <param name="fromViewId">The ID of the calling, currently displayed window.</param>
    /// <param name="options">Options for the display transition behaviors.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [Overload("SwitchFromViewWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);

    /// <summary>Prepares your app to visually transition between two windows with a custom animation.</summary>
    /// <param name="toViewId">The ID of the window from which your app is transitioning.</param>
    /// <param name="fromViewId">The ID of the window to which your app is transitioning.</param>
    /// <param name="options">Enumeration value that specifies thw view switching behaviors.</param>
    /// <returns>Asynchronously returns **true** if the call succeeds; **false** if it does not.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> PrepareForCustomAnimatedSwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);
  }
}
