// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.PreallocatedWorkItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  /// <summary>A preallocated work item is constructed in advance of its submission to the thread pool, ensuring that the work item is constructed so that it can be submitted to the thread pool when necessary. For example, a PreallocatedWorkItem can be created in case it is needed for a resource deallocation routine, since the resource deallocation routine may be called in circumstances when not enough resources would be available to create the work item.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(typeof (IPreallocatedWorkItemFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  public sealed class PreallocatedWorkItem : IPreallocatedWorkItem
  {
    /// <summary>Initializes a new work item with a WorkItemHandler delegate, allocating resources for the work item in advance.</summary>
    /// <param name="handler">Indicates the method that the preallocated work item will run.</param>
    [MethodImpl]
    public extern PreallocatedWorkItem(WorkItemHandler handler);

    /// <summary>Initializes a new work item with a WorkItemHandler delegate, allocating resources for the work item in advance, and specifies the priority of the work item relative to other work items in the thread pool.</summary>
    /// <param name="handler">Indicates the method that the preallocated work item will run.</param>
    /// <param name="priority">The priority of the work item relative to other work items in the thread pool. The value of this parameter can be **Low**, **Normal**, or **High**.</param>
    [MethodImpl]
    public extern PreallocatedWorkItem(WorkItemHandler handler, WorkItemPriority priority);

    /// <summary>Initializes a new work item with a WorkItemHandler delegate, allocating resources for the work item in advance, and specifies the priority of the work item relative to other work items in the thread pool. Also specifies how the thread pool will allocate processor time for the work item.</summary>
    /// <param name="handler">Indicates the method that the preallocated work item will run.</param>
    /// <param name="priority">The priority of the work item relative to other work items in the thread pool. The value of this parameter can be **Low**, **Normal**, or **High**.</param>
    /// <param name="options">If this parameter is set to **TimeSliced**, the work item runs simultaneously with other time-sliced work items, with each work item receiving a share of processor time. If this parameter is set to **None**, the work item runs when a worker thread becomes available.</param>
    [MethodImpl]
    public extern PreallocatedWorkItem(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);

    /// <summary>Submits the preallocated work item to the thread pool, without requiring any additional resources to be allocated.</summary>
    /// <returns>Provides access to the running IAsyncAction that was previously constructed and given the necessary resource allocation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RunAsync();
  }
}
