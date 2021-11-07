// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.IThreadPoolStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  [WebHostHidden]
  [Guid(3065997277, 33981, 17656, 172, 28, 147, 235, 203, 157, 186, 145)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ThreadPool))]
  internal interface IThreadPoolStatics
  {
    [Overload("RunAsync")]
    [RemoteAsync]
    IAsyncAction RunAsync(WorkItemHandler handler);

    [Overload("RunWithPriorityAsync")]
    [RemoteAsync]
    IAsyncAction RunAsync(WorkItemHandler handler, WorkItemPriority priority);

    [RemoteAsync]
    [Overload("RunWithPriorityAndOptionsAsync")]
    IAsyncAction RunAsync(
      WorkItemHandler handler,
      WorkItemPriority priority,
      WorkItemOptions options);
  }
}
