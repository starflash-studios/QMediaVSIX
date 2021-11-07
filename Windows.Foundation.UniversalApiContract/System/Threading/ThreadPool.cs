// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.ThreadPool
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  /// <summary>Provides access to the thread pool. See Threading and async programming for detailed guidance on using the thread pool:</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IThreadPoolStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ThreadPool
  {
    /// <summary>Creates a work item.</summary>
    /// <param name="handler">The method to call when a thread becomes available to run the work item.</param>
    /// <returns>An IAsyncAction interface that provides access to the work item.</returns>
    [RemoteAsync]
    [Overload("RunAsync")]
    [MethodImpl]
    public static extern IAsyncAction RunAsync(WorkItemHandler handler);

    /// <summary>Creates a work item and specifies its priority relative to other work items in the thread pool.</summary>
    /// <param name="handler">The method to call when a thread becomes available to run the work item.</param>
    /// <param name="priority">The priority of the work item relative to other work items in the thread pool. The value of this parameter can be **Low**, **Normal**, or **High**.</param>
    /// <returns>An IAsyncAction interface that provides access to the work item.</returns>
    [Overload("RunWithPriorityAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction RunAsync(
      WorkItemHandler handler,
      WorkItemPriority priority);

    /// <summary>Creates a work item, specifies its priority relative to other work items in the thread pool, and specifies how long-running work items should be run.</summary>
    /// <param name="handler">The method to call when a thread becomes available to run the work item.</param>
    /// <param name="priority">The priority of the work item relative to other work items in the thread pool.</param>
    /// <param name="options">If this parameter is **TimeSliced**, the work item runs simultaneously with other time-sliced work items with each work item receiving a share of processor time. If this parameter is **None**, the work item runs when a worker thread becomes available.</param>
    /// <returns>An IAsyncAction interface that provides access to the work item.</returns>
    [RemoteAsync]
    [Overload("RunWithPriorityAndOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncAction RunAsync(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);
  }
}
