// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.WindowManagement
{
  /// <summary>Represents a system-managed container for the content of an app.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Static(typeof (IAppWindowStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppWindow : IAppWindow
  {
    /// <summary>Gets the app content currently attached to the window.</summary>
    /// <returns>The app content currently attached to the window.</returns>
    public extern UIContentRoot Content { [MethodImpl] get; }

    /// <summary>Gets the dispatcher queue for the app window.</summary>
    /// <returns>The dispatcher queue for the app window.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    /// <summary>Gets the frame for the app window.</summary>
    /// <returns>The frame for the app window.</returns>
    public extern AppWindowFrame Frame { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the window can be seen on a display.</summary>
    /// <returns>**true** if the window can be seen on a display; otherwise, **false**.</returns>
    public extern bool IsVisible { [MethodImpl] get; }

    /// <summary>Gets or sets a string that identifies this window for tracking and saving state.</summary>
    /// <returns>A string that identifies this window for tracking and saving state.</returns>
    public extern string PersistedStateId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the presenter for the app window.</summary>
    /// <returns>The presenter for the app window.</returns>
    public extern AppWindowPresenter Presenter { [MethodImpl] get; }

    /// <summary>Gets or sets the displayed title of the app window.</summary>
    /// <returns>The displayed title of the app window.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the title bar of the app window.</summary>
    /// <returns>The title bar of the app window.</returns>
    public extern AppWindowTitleBar TitleBar { [MethodImpl] get; }

    /// <summary>Gets the UI context for the app window.</summary>
    /// <returns>The UI context for the app window.</returns>
    public extern UIContext UIContext { [MethodImpl] get; }

    /// <summary>Gets the windowing environment for the app window.</summary>
    /// <returns>The windowing environment for the app window.</returns>
    public extern WindowingEnvironment WindowingEnvironment { [MethodImpl] get; }

    /// <summary>Closes the app window.</summary>
    /// <returns>Returns a IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CloseAsync();

    /// <summary>Returns a placement object that describes the app window's display region, offset, and size.</summary>
    /// <returns>A placement object that describes the app window's display region, offset, and size.</returns>
    [MethodImpl]
    public extern AppWindowPlacement GetPlacement();

    /// <summary>Returns the collection of display regions available for the app window.</summary>
    /// <returns>The collection of display regions available for the app window.</returns>
    [MethodImpl]
    public extern IVectorView<DisplayRegion> GetDisplayRegions();

    /// <summary>Makes a request to position the window in the specified display region.</summary>
    /// <param name="displayRegion">The display region to move the window to.</param>
    [MethodImpl]
    public extern void RequestMoveToDisplayRegion(DisplayRegion displayRegion);

    /// <summary>Makes a request to position the window next to the current view.</summary>
    [MethodImpl]
    public extern void RequestMoveAdjacentToCurrentView();

    /// <summary>Makes a request to position the window next to the specified anchor window.</summary>
    /// <param name="anchorWindow">The window to position this window next to.</param>
    [MethodImpl]
    public extern void RequestMoveAdjacentToWindow(AppWindow anchorWindow);

    /// <summary>Makes a request to position the window at the specified offset relative to the anchor window.</summary>
    /// <param name="anchorWindow">The window to position this window relative to.</param>
    /// <param name="contentOffset">The offset of the window relative to the anchor window.</param>
    [MethodImpl]
    public extern void RequestMoveRelativeToWindowContent(
      AppWindow anchorWindow,
      Point contentOffset);

    /// <summary>Makes a request to position the window at the specified offset relative to the current view.</summary>
    /// <param name="contentOffset">The offset of the window relative to the current view.</param>
    [MethodImpl]
    public extern void RequestMoveRelativeToCurrentViewContent(Point contentOffset);

    /// <summary>Makes a request to position the window in the specified display region at the specified offset.</summary>
    /// <param name="displayRegion">The display region to move the window to.</param>
    /// <param name="displayRegionOffset">The offset of the window in the display region.</param>
    [MethodImpl]
    public extern void RequestMoveRelativeToDisplayRegion(
      DisplayRegion displayRegion,
      Point displayRegionOffset);

    /// <summary>Makes a request to set the window to the specified size.</summary>
    /// <param name="frameSize">The requested size.</param>
    [MethodImpl]
    public extern void RequestSize(Size frameSize);

    /// <summary>Attempts to asynchronously show the current app window.</summary>
    /// <returns>**true** if the window was shown successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryShowAsync();

    /// <summary>Occurs when a property of the app window has changed.</summary>
    public extern event TypedEventHandler<AppWindow, AppWindowChangedEventArgs> Changed;

    /// <summary>Occurs when the app window has been closed.</summary>
    public extern event TypedEventHandler<AppWindow, AppWindowClosedEventArgs> Closed;

    /// <summary>Occurs after the window starts to close, but before it is closed and before the Closed event occurs.</summary>
    public extern event TypedEventHandler<AppWindow, AppWindowCloseRequestedEventArgs> CloseRequested;

    /// <summary>Attempts to asynchronously create a new instance of AppWindow.</summary>
    /// <returns>The new instance of AppWindow if it was created successfully.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppWindow> TryCreateAsync();

    /// <summary>Clears any properties the system has saved for any window PersistedStateId for the given application.</summary>
    [MethodImpl]
    public static extern void ClearAllPersistedState();

    /// <summary>Clears any properties the system has saved for the window with the specified ID for the given application.</summary>
    /// <param name="key">The PersistedStateId for the view to be cleared.</param>
    [MethodImpl]
    public static extern void ClearPersistedState(string key);
  }
}
