// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreDispatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Provides the Windows Runtime core event message dispatcher. Instances of this type are responsible for processing the window messages and dispatching the events to the client.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100794368)]
  public sealed class CoreDispatcher : 
    ICoreDispatcher,
    ICoreAcceleratorKeys,
    ICoreDispatcherWithTaskPriority,
    ICoreDispatcher2
  {
    /// <summary>Gets a value that specifies whether the event dispatcher provided by this instance of CoreWindow has access to the current thread or not.</summary>
    /// <returns>True if the event dispatcher has thread access; false it does not.</returns>
    public extern bool HasThreadAccess { [MethodImpl] get; }

    /// <summary>Starts the dispatcher processing the input event queue for this instance of CoreWindow.</summary>
    /// <param name="options">Determines how many events to process, and if this method should block.</param>
    [MethodImpl]
    public extern void ProcessEvents(CoreProcessEventsOption options);

    /// <summary>Schedules the provided callback on the UI thread from a worker thread, and returns the results asynchronously.</summary>
    /// <param name="priority">Specifies the priority for event dispatch. Set this to CoreDispatcherPriority.Normal.</param>
    /// <param name="agileCallback">The callback on which the dispatcher returns when the event is dispatched.</param>
    /// <returns>The object that provides handlers for the completed async event dispatch.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    /// <summary>Schedules a callback on the UI thread from a worker thread at idle priority, and returns the results asynchronously.</summary>
    /// <param name="agileCallback">The callback on which the idle priority dispatcher returns when the event is dispatched.</param>
    /// <returns>Object that contains the results of the asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RunIdleAsync(IdleDispatchedHandler agileCallback);

    /// <summary>Fired when an accelerator key is activated (pressed or held down).</summary>
    public extern event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> AcceleratorKeyActivated;

    /// <summary>Gets and sets the priority of the current task.</summary>
    /// <returns>A CoreDispatcherPriority enumeration value that specifies the priority of the current task.</returns>
    public extern CoreDispatcherPriority CurrentPriority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Queries whether the caller should yield if there are items in the task queue of higher priority than the current task.</summary>
    /// <returns>**true** if the current work item should yield to higher priority work; **false** if it should not.</returns>
    [Overload("ShouldYield")]
    [MethodImpl]
    public extern bool ShouldYield();

    /// <summary>Queries whether the caller should yield if there are items in the task queue of the specified priority or higher.</summary>
    /// <param name="priority">The minimum priority level for which the current work item should yield.</param>
    /// <returns>**true** if the current work item should yield to higher priority work; **false** if it should not.</returns>
    [Overload("ShouldYieldToPriority")]
    [MethodImpl]
    public extern bool ShouldYield(CoreDispatcherPriority priority);

    /// <summary>Stops the dispatcher from processing any queued events.</summary>
    [MethodImpl]
    public extern void StopProcessEvents();

    /// <summary>Attempts to schedule the specified callback on the UI thread from a worker thread, and returns the results asynchronously.</summary>
    /// <param name="priority">Specifies the priority for event dispatch. Set this to CoreDispatcherPriority.Normal.</param>
    /// <param name="agileCallback">The callback on which the dispatcher returns when the event is dispatched.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRunAsync(
      CoreDispatcherPriority priority,
      DispatchedHandler agileCallback);

    /// <summary>Attempts to schedule a callback on the UI thread from a worker thread at idle priority, and returns the results asynchronously.</summary>
    /// <param name="agileCallback">The callback on which the idle priority dispatcher returns when the event is dispatched.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRunIdleAsync(
      IdleDispatchedHandler agileCallback);
  }
}
