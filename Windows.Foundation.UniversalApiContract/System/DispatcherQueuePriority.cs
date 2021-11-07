// Decompiled with JetBrains decompiler
// Type: Windows.System.DispatcherQueuePriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Defines the priority levels that can be given to work assigned to a DispatcherQueue.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum DispatcherQueuePriority
  {
    /// <summary>**Low** priority work will be scheduled when there isn't any other work to process. Work at **Low** priority can be preempted by new incoming **High** and **Normal** priority tasks.</summary>
    Low = -10, // 0xFFFFFFF6
    /// <summary>Work will be dispatched once all **High** priority tasks are dispatched. If a new **High** priority work is scheduled, all new **High** priority tasks are processed before resuming **Normal** tasks. This is the default priority.</summary>
    Normal = 0,
    /// <summary>Work scheduled at **High** priority will be dispatched first, along with other **High** priority System tasks, before processing **Normal** or **Low** priority work.</summary>
    High = 10, // 0x0000000A
  }
}
