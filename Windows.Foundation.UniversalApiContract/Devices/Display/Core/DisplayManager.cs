// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Manages the ownership of a DisplayTarget object or objects, and provides methods to create DisplayState objects.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDisplayManagerStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayManager : IDisplayManager, IClosable
  {
    /// <summary>Enumerates the set of display targets currently present on the system.</summary>
    /// <returns>A collection of DisplayTarget values.</returns>
    [MethodImpl]
    public extern IVectorView<DisplayTarget> GetCurrentTargets();

    /// <summary>Enumerates the set of display adapters currently present on the system.</summary>
    /// <returns>A collection of DisplayAdapter values.</returns>
    [MethodImpl]
    public extern IVectorView<DisplayAdapter> GetCurrentAdapters();

    /// <summary>Attempts to acquire exclusive ownership of a DisplayTarget.</summary>
    /// <param name="target">The DisplayTarget to try to acquire exclusive ownership of.</param>
    /// <returns>A DisplayManagerResult value detailing the success or failure of acquiring the target.</returns>
    [MethodImpl]
    public extern DisplayManagerResult TryAcquireTarget(DisplayTarget target);

    /// <summary>Releases ownership of the specified display target, allowing other components on the system to acquire ownership.</summary>
    /// <param name="target">The DisplayTarget to release ownership of.</param>
    [MethodImpl]
    public extern void ReleaseTarget(DisplayTarget target);

    /// <summary>Creates a read-only DisplayState object populated with the entire system display state for all targets.</summary>
    /// <returns>A DisplayManagerResultWithState value.</returns>
    [MethodImpl]
    public extern DisplayManagerResultWithState TryReadCurrentStateForAllTargets();

    [MethodImpl]
    public extern DisplayManagerResultWithState TryAcquireTargetsAndReadCurrentState(
      IIterable<DisplayTarget> targets);

    [MethodImpl]
    public extern DisplayManagerResultWithState TryAcquireTargetsAndCreateEmptyState(
      IIterable<DisplayTarget> targets);

    [MethodImpl]
    public extern DisplayManagerResultWithState TryAcquireTargetsAndCreateSubstate(
      DisplayState existingState,
      IIterable<DisplayTarget> targets);

    /// <summary>Creates a DisplayDevice object for the given adapter. The **DisplayDevice** can be used to create and present full-screen content to targets on the given adapter.</summary>
    /// <param name="adapter">The DisplayAdapter to create a DisplayDevice for.</param>
    /// <returns>A DisplayDevice value.</returns>
    [MethodImpl]
    public extern DisplayDevice CreateDisplayDevice(DisplayAdapter adapter);

    /// <summary>An event raised whenever the current session's display stack is enabled, and when DisplayManager.Start is called. You can re-enable the session display stack in several cases, such as switching Terminal Services sessions, or to recover from driver failures. We recommend that subscribers re-enumerate all targets and state in this call, since the system display stack could be left in any state before this event is raised.</summary>
    public extern event TypedEventHandler<DisplayManager, DisplayManagerEnabledEventArgs> Enabled;

    /// <summary>An event raised whenever the current session's display stack is disabled, and when DisplayManager.Stop is called. You can disable the session display stack in several cases, such as switching Terminal Services sessions, or to recover from driver failures. We recommend that subscribers attempt to clean up when **Disabled** is invoked. Most display APIs will fail while the session display stack is disabled.</summary>
    public extern event TypedEventHandler<DisplayManager, DisplayManagerDisabledEventArgs> Disabled;

    /// <summary>An event that is raised when system display hardware is added, removed, or modified. This can occur whenever the enumerations of DisplayAdapter objects and DisplayTarget objects are different, so we recommended that you subscribe to this event and call GetCurrentAdapters and/or GetCurrentTargets to determine what has changed.</summary>
    public extern event TypedEventHandler<DisplayManager, DisplayManagerChangedEventArgs> Changed;

    /// <summary>An event that is raised whenever a display path is failed or invalidated asynchronously by the system. This can be due to changing hardware bandwidth requirements, or due to driver failures.</summary>
    public extern event TypedEventHandler<DisplayManager, DisplayManagerPathsFailedOrInvalidatedEventArgs> PathsFailedOrInvalidated;

    /// <summary>Starts listening for all DisplayManager events atomically. DisplayManager events are not raised until you call **Start**.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops listening to all DisplayManager events atomically, and triggers Disabled synchronously.</summary>
    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a DisplayManager instance with the specified options.</summary>
    /// <param name="options">
    /// </param>
    /// <returns>A DisplayManager value.</returns>
    [MethodImpl]
    public static extern DisplayManager Create(DisplayManagerOptions options);
  }
}
