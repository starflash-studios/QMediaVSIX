// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ApplicationView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.UI.WindowManagement;

namespace Windows.UI.ViewManagement
{
  /// <summary>Represents the active application view and associated states and behaviors.</summary>
  [Static(typeof (IApplicationViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IApplicationViewStatics4), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewFullscreenStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewInteropStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IApplicationViewStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ApplicationView : 
    IApplicationView,
    IApplicationView2,
    IApplicationView3,
    IApplicationView4,
    IApplicationView7,
    IApplicationView9,
    IApplicationViewWithContext
  {
    /// <summary>Gets the current orientation (landscape or portrait) of the window (app view) with respect to the display.</summary>
    /// <returns>The current orientation of the calling window.</returns>
    public extern ApplicationViewOrientation Orientation { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the current window is in close proximity to the left edge of the screen.</summary>
    /// <returns>**true** if the current window is in close proximity to the left edge of the screen; otherwise, **false**.</returns>
    public extern bool AdjacentToLeftDisplayEdge { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the current window is in close proximity to the right edge of the screen.</summary>
    /// <returns>**true** if the current window is in close proximity to the right edge of the screen; otherwise, **false**.</returns>
    public extern bool AdjacentToRightDisplayEdge { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the window touches both the left and right sides of the display.</summary>
    /// <returns>**true** if the window touches both the left and right sides of the display; otherwise, **false**.</returns>
    public extern bool IsFullScreen { [Deprecated("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets whether the window (app view) is on the Windows lock screen.</summary>
    /// <returns>**true** if the calling window is on the lock screen; **false** if it is not.</returns>
    public extern bool IsOnLockScreen { [MethodImpl] get; }

    /// <summary>Gets or sets whether screen capture is enabled for the window (app view).</summary>
    /// <returns>**true** if screen capture is enabled for the window; **false** if it is not.</returns>
    public extern bool IsScreenCaptureEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the displayed title of the window.</summary>
    /// <returns>The title of the window.</returns>
    public extern string Title { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the ID of the window (app view).</summary>
    /// <returns>The ID of the window. It is unique for all windows managed by the app.</returns>
    public extern int Id { [MethodImpl] get; }

    /// <summary>Occurs when the window is removed from the list of recently used apps, or if the user executes a close gesture on it.</summary>
    public extern event TypedEventHandler<ApplicationView, ApplicationViewConsolidatedEventArgs> Consolidated;

    /// <summary>Gets or sets a value indicating whether or not system overlays (such as overlay applications or the soft steering wheel) should be shown.</summary>
    /// <returns>**true** if system overlays (such as overlay applications or the soft steering wheel) should be shown; otherwise, **false**.</returns>
    public extern bool SuppressSystemOverlays { [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets the visible region of the window (app view). The visible region is the region not occluded by chrome such as the status bar and app bar.</summary>
    /// <returns>The visible region of the window (app view).</returns>
    public extern Rect VisibleBounds { [MethodImpl] get; }

    /// <summary>This event is raised when the value of VisibleBounds changes, typically as a result of the status bar, app bar, or other chrome being shown or hidden.</summary>
    public extern event TypedEventHandler<ApplicationView, object> VisibleBoundsChanged;

    /// <summary>Sets a value indicating the bounds used by the framework to lay out the contents of the window (app view).</summary>
    /// <param name="boundsMode">The bounds that the framework should use to lay out the contents of the window (app view).</param>
    /// <returns>**true** to confirm that the change to DesiredBoundsMode was successful; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool SetDesiredBoundsMode(ApplicationViewBoundsMode boundsMode);

    /// <summary>Gets a value that indicates the bounds used by the framework to lay out the contents of the window (app view).</summary>
    /// <returns>The current layout bounds of the window. The default is **UseVisible**.</returns>
    public extern ApplicationViewBoundsMode DesiredBoundsMode { [MethodImpl] get; }

    /// <summary>Gets the title bar of the app.</summary>
    /// <returns>The title bar of the app.</returns>
    public extern ApplicationViewTitleBar TitleBar { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates how an app in full-screen mode responds to edge swipe actions.</summary>
    /// <returns>A value from the FullScreenSystemOverlayMode enumeration that indicates how an app in full-screen mode responds to edge swipe actions.</returns>
    public extern FullScreenSystemOverlayMode FullScreenSystemOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the app is running in full-screen mode.</summary>
    /// <returns>**true** if the app is running in full-screen mode; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsFullScreenMode { [MethodImpl] get; }

    /// <summary>Attempts to place the app in full-screen mode.</summary>
    /// <returns>**true** if the app is placed in full-screen mode; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryEnterFullScreenMode();

    /// <summary>Takes the app out of full-screen mode.</summary>
    [MethodImpl]
    public extern void ExitFullScreenMode();

    /// <summary>Shows system UI elements, like the title bar, over a full-screen app.</summary>
    [MethodImpl]
    public extern void ShowStandardSystemOverlays();

    /// <summary>Attempts to change the size of the view to the specified size in effective pixels.</summary>
    /// <param name="value">The new size of the view in effective pixels.</param>
    /// <returns>**true** if the view is resized to the requested size; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryResizeView(Size value);

    /// <summary>Sets the smallest size, in effective pixels, allowed for the app window.</summary>
    /// <param name="minSize">The smallest size allowed for the app window, or a Size whose height and width are both zero to use the system default minimum size.</param>
    [MethodImpl]
    public extern void SetPreferredMinSize(Size minSize);

    /// <summary>Gets the app view mode for the current view.</summary>
    /// <returns>A value of the enumeration that indicates the view mode of the current view.</returns>
    public extern ApplicationViewMode ViewMode { [MethodImpl] get; }

    /// <summary>Determines whether the specified view mode is supported on the current device.</summary>
    /// <param name="viewMode">A value of the enumeration that indicates the desired view mode.</param>
    /// <returns>**true** if the specified view mode is supported; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsViewModeSupported(ApplicationViewMode viewMode);

    /// <summary>Attempts to change the app view to the specified view mode.</summary>
    /// <param name="viewMode">A value of the enumeration that indicates the desired view mode.</param>
    /// <returns>**true** if the app view was changed to the specified view mode; otherwise, **false**.</returns>
    [Overload("TryEnterViewModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryEnterViewModeAsync(
      ApplicationViewMode viewMode);

    /// <summary>Attempts to change the app view to the specified view mode using the specified options.</summary>
    /// <param name="viewMode">A value of the enumeration that indicates the desired view mode.</param>
    /// <param name="viewModePreferences">Preferred settings for the desired view mode.</param>
    /// <returns>**true** if the app view was changed to the specified view mode; otherwise, **false**.</returns>
    [Overload("TryEnterViewModeWithPreferencesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryEnterViewModeAsync(
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);

    /// <summary>Tries to close the current app view. This method is a programmatic equivalent to a user initiating a close gesture for the app view.</summary>
    /// <returns>**true** if the app views are consolidated; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryConsolidateAsync();

    /// <summary>Gets or sets a string that identifies this view for tracking and saving state.</summary>
    /// <returns>A string that identifies this view for tracking and saving state.</returns>
    public extern string PersistedStateId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the windowing environment for the view.</summary>
    /// <returns>The windowing environment for the view.</returns>
    public extern WindowingEnvironment WindowingEnvironment { [MethodImpl] get; }

    /// <summary>Returns the collection of display regions available for the view.</summary>
    /// <returns>The collection of display regions available for the view.</returns>
    [MethodImpl]
    public extern IVectorView<DisplayRegion> GetDisplayRegions();

    /// <summary>Gets the context identifier for the view.</summary>
    /// <returns>The context identifier for the view.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }

    /// <summary>Clears any properties the system has saved for any view PersistedStateId for the given application.</summary>
    [MethodImpl]
    public static extern void ClearAllPersistedState();

    /// <summary>Clears any properties the system has saved for the view with the specified identifier for the given application.</summary>
    /// <param name="key">The PersistedStateId for the view to be cleared.</param>
    [MethodImpl]
    public static extern void ClearPersistedState(string key);

    /// <summary>Gets or sets a value that indicates the windowing mode the app launches with.</summary>
    /// <returns>An enumeration value that indicates the windowing mode of the app.</returns>
    public static extern ApplicationViewWindowingMode PreferredLaunchWindowingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size that the app launches with when the ApplicationView.PreferredLaunchWindowingMode property is set to **PreferredLaunchViewSize**, except in cases where the system manages the window size directly.</summary>
    /// <returns>The size that the app launches with when the ApplicationView.PreferredLaunchWindowingMode property is set to **PreferredLaunchViewSize**, except in cases where the system manages the window size directly.</returns>
    public static extern Size PreferredLaunchViewSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Attempts to unsnap a previously snapped app.</summary>
    /// <deprecated type="deprecate">IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.</deprecated>
    /// <returns>**true** if the app has been successfully unsnapped; **false** if the unsnap attempt failed.</returns>
    [Deprecated("IApplicationViewFullscreenStatics is deprecated after Windows 8. Please use other resize APIs.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool TryUnsnapToFullscreen();

    /// <summary>Gets the window ID that corresponds to a specific CoreWindow managed by the app.</summary>
    /// <param name="window">Reference to the CoreWindow object that contains a window handle used by the app.</param>
    /// <returns>The ID of the window associated with the supplied CoreWindow.</returns>
    [MethodImpl]
    public static extern int GetApplicationViewIdForWindow(ICoreWindow window);

    /// <summary>Gets the view state and behavior settings of the active application.</summary>
    /// <returns>An ApplicationView instance that can be used to get and set app display properties.</returns>
    [MethodImpl]
    public static extern ApplicationView GetForCurrentView();

    /// <summary>Indicates whether the app terminates when the last window is closed.</summary>
    /// <returns>**true** if the app terminates when the last open window is closed; **false** if it doesn't terminate.</returns>
    public static extern bool TerminateAppOnFinalViewClose { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the state of the current window (app view).</summary>
    /// <returns>The state of the current window (app view). This state indicates the orientation (landscape or portrait) and whether or not the app is snapped.</returns>
    public static extern ApplicationViewState Value { [Deprecated("Value may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Attempts to unsnap a previously snapped app. This call will only succeed when the app is running in the foreground.</summary>
    /// <deprecated type="deprecate">TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.</deprecated>
    /// <returns>**true** if the app has been successfully unsnapped; **false** if the unsnap attempt failed.</returns>
    [Deprecated("TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern bool TryUnsnap();
  }
}
