// Decompiled with JetBrains decompiler
// Type: Windows.System.DispatcherQueue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Manages a prioritized queue on which tasks execute in a serial fashion on a thread.</summary>
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDispatcherQueueStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class DispatcherQueue : IDispatcherQueue, IDispatcherQueue2
  {
    /// <summary>Creates a **DispatcherQueueTimer** on the **DispatcherQueue** to execute a task periodically after a time interval has elapsed.</summary>
    /// <returns>An **DispatcherQueueTimer** that can queue tasks on a timed basis to the current **DispatcherQueue**.</returns>
    [MethodImpl]
    public extern DispatcherQueueTimer CreateTimer();

    /// <summary>Adds a task to the **DispatcherQueue** which will be executed on the thread  associated with the **DispatcherQueue**.</summary>
    /// <param name="callback">The task to execute.</param>
    /// <returns>**True** indicates that the task was added to the queue; **false**, otherwise.</returns>
    [Overload("TryEnqueue")]
    [MethodImpl]
    public extern bool TryEnqueue(DispatcherQueueHandler callback);

    /// <summary>Adds a task to the **DispatcherQueue** which will be executed on the thread associated with the **DispatcherQueue**.</summary>
    /// <param name="priority">The priority of the task such as Low, Normal, or High.</param>
    /// <param name="callback">A delegate to the task to execute.</param>
    /// <returns>**True** indicates that the task was added to the queue; **false**, otherwise.</returns>
    [Overload("TryEnqueueWithPriority")]
    [MethodImpl]
    public extern bool TryEnqueue(DispatcherQueuePriority priority, DispatcherQueueHandler callback);

    /// <summary>Fires before the dispatcher queue initiates an exit from its event loop.</summary>
    public extern event TypedEventHandler<DispatcherQueue, DispatcherQueueShutdownStartingEventArgs> ShutdownStarting;

    /// <summary>Fires after the **DispatcherQueue** event loop stops which is the last step in the **DispatcherQueue** shutdown process.</summary>
    public extern event TypedEventHandler<DispatcherQueue, object> ShutdownCompleted;

    /// <summary>Gets a value indicating whether the DispatcherQueue has access to the current thread.</summary>
    /// <returns>
    /// </returns>
    public extern bool HasThreadAccess { [MethodImpl] get; }

    /// <summary>Gets the **DispatcherQueue** associated with the current thread.</summary>
    /// <returns>A **DispatcherQueue** instance that will execute tasks serially on the current thread.</returns>
    [MethodImpl]
    public static extern DispatcherQueue GetForCurrentThread();
  }
}
