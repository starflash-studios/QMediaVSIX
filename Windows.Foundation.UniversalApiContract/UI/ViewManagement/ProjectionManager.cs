// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.ProjectionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ViewManagement
{
  /// <summary>Defines a set of methods for managing the windows (app views) sent to secondary displays, such as projectors.</summary>
  [Static(typeof (IProjectionManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IProjectionManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class ProjectionManager
  {
    /// <summary>Asynchronously sends a window (app view) to the projector or other secondary display, and provides info about the display.</summary>
    /// <param name="projectionViewId">The new ID of the window to be displayed by the projector or other secondary display.</param>
    /// <param name="anchorViewId">The ID of the original window before projection.</param>
    /// <param name="displayDeviceInfo">Information about the display device.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [RemoteAsync]
    [Overload("StartProjectingWithDeviceInfoAsync")]
    [MethodImpl]
    public static extern IAsyncAction StartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      DeviceInformation displayDeviceInfo);

    /// <summary>Makes a request to asynchronously sends a window (app view) to the projector or other secondary display.</summary>
    /// <param name="projectionViewId">The new ID of the window to be displayed by the projector or other secondary display.</param>
    /// <param name="anchorViewId">The ID of the original window before projection.</param>
    /// <param name="selection">The area to one side of which the flyout is displayed.</param>
    /// <returns>**true** if projection started; otherwise, **false**.</returns>
    [Overload("RequestStartProjectingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection);

    /// <summary>Makes a request to asynchronously sends a window (app view) to the projector or other secondary display with the specified preferred placement.</summary>
    /// <param name="projectionViewId">The new ID of the window to be displayed by the projector or other secondary display.</param>
    /// <param name="anchorViewId">The ID of the original window before projection.</param>
    /// <param name="selection">The area to one side of which the flyout is displayed.</param>
    /// <param name="prefferedPlacement">The side of the rectangle where the flyout should appear.</param>
    /// <returns>**true** if projection started; otherwise, **false**.</returns>
    [RemoteAsync]
    [Overload("RequestStartProjectingWithPlacementAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection,
      Placement prefferedPlacement);

    /// <summary>Returns a string that is used to enumerate device services.</summary>
    /// <returns>A string that is used to enumerate device services.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously sends a window (app view) to the projector or other secondary display.</summary>
    /// <param name="projectionViewId">The new ID of the window to be displayed by the projector or other secondary display.</param>
    /// <param name="anchorViewId">The ID of the original window before projection.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [RemoteAsync]
    [Overload("StartProjectingAsync")]
    [MethodImpl]
    public static extern IAsyncAction StartProjectingAsync(
      int projectionViewId,
      int anchorViewId);

    /// <summary>Asynchronously swaps the calling window (app view) with the window displayed on the projector or other secondary display. The result is that the calling window is displayed on the projector, and the formerly projected window is displayed on the device screen.</summary>
    /// <param name="projectionViewId">The ID of the window currently displayed by the projector.</param>
    /// <param name="anchorViewId">The ID of the window to swap with the projected window.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SwapDisplaysForViewsAsync(
      int projectionViewId,
      int anchorViewId);

    /// <summary>Asynchronously hides a window (app view) displayed by a projector or other secondary display.</summary>
    /// <param name="projectionViewId">The ID of the window currently displayed by the projector or other secondary display.</param>
    /// <param name="anchorViewId">The ID of the original window before projection.</param>
    /// <returns>The asynchronous results of the operation. Use this to determine when the async call is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction StopProjectingAsync(
      int projectionViewId,
      int anchorViewId);

    /// <summary>Gets whether or not a projection display is available to use.</summary>
    /// <returns>**true** if a projection display is available on the current computer; **false** if it is not.</returns>
    public static extern bool ProjectionDisplayAvailable { [MethodImpl] get; }

    /// <summary>Occurs when a projector or other secondary display becomes available or unavailable.</summary>
    public static extern event EventHandler<object> ProjectionDisplayAvailableChanged;
  }
}
