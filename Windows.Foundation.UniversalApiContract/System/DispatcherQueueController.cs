// Decompiled with JetBrains decompiler
// Type: Windows.System.DispatcherQueueController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Manages the lifetime of a DispatcherQueue. Provides methods to create and shutdown the **DispatcherQueue**.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IDispatcherQueueControllerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class DispatcherQueueController : IDispatcherQueueController
  {
    /// <summary>Gets the **DispatcherQueue** associated with this **DispatcherQueueController**.</summary>
    /// <returns>The **DispatcherQueue** instance that you use to queue tasks that run on a thread.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    /// <summary>Stops the **DispatcherQueue** associated with this **DispatcherQueueController**. Shuts down the thread if the **DispatcherQueueController** was created by **CreateOnDedicatedThread**.</summary>
    /// <returns>An asynchronous operation which will complete after the queue has dispatched all of its remaining work.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShutdownQueueAsync();

    /// <summary>Creates a DispatcherQueue that you can use to run tasks on a dedicated thread.</summary>
    /// <returns>The created **DispatcherQueueController**.</returns>
    [MethodImpl]
    public static extern DispatcherQueueController CreateOnDedicatedThread();
  }
}
