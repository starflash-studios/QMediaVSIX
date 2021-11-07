// Decompiled with JetBrains decompiler
// Type: Windows.System.IDispatcherQueue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (DispatcherQueue))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1614711012, 41784, 20478, 164, 87, 165, 207, 185, 206, 184, 153)]
  internal interface IDispatcherQueue
  {
    DispatcherQueueTimer CreateTimer();

    [Overload("TryEnqueue")]
    bool TryEnqueue(DispatcherQueueHandler callback);

    [Overload("TryEnqueueWithPriority")]
    bool TryEnqueue(DispatcherQueuePriority priority, DispatcherQueueHandler callback);

    event TypedEventHandler<DispatcherQueue, DispatcherQueueShutdownStartingEventArgs> ShutdownStarting;

    event TypedEventHandler<DispatcherQueue, object> ShutdownCompleted;
  }
}
