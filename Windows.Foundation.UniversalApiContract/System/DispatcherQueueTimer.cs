// Decompiled with JetBrains decompiler
// Type: Windows.System.DispatcherQueueTimer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Executes a task in a **DispatcherQueue** periodically after a time interval has elapsed.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DispatcherQueueTimer : IDispatcherQueueTimer
  {
    /// <summary>Gets and sets the interval for the timer.</summary>
    /// <returns>The amount of time before the timer ticks.</returns>
    public extern TimeSpan Interval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether the timer is currently running.</summary>
    /// <returns>**True** indicates that the timer is running; otherwise **false**</returns>
    public extern bool IsRunning { [MethodImpl] get; }

    /// <summary>Indicates whether the timer is repeating.</summary>
    /// <returns>**True** indicates that the timer fires every **DispatcherQueueTimer.Interval**; **false** means that it fires once, after **DispatcherQueueTimer.Interval** elapses.</returns>
    public extern bool IsRepeating { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the timer.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the timer.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Event that fires when the timer **Interval** elapses.</summary>
    public extern event TypedEventHandler<DispatcherQueueTimer, object> Tick;
  }
}
