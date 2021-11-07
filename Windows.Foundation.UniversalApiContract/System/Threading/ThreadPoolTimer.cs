// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.ThreadPoolTimer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  /// <summary>Represents a timer created with CreateTimer or CreatePeriodicTimer.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IThreadPoolTimerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ThreadPoolTimer : IThreadPoolTimer
  {
    /// <summary>Gets the timeout value of a periodic timer created with CreatePeriodicTimer.</summary>
    /// <returns>The timeout value. When the timeout value elapses, the timer expires, its TimerElapsedHandler delegate is called, and the timer reactivates. This behavior continues until the timer is canceled. </returns>
    public extern TimeSpan Period { [MethodImpl] get; }

    /// <summary>Gets the timeout value of a single-use timer created with CreateTimer.</summary>
    /// <returns>The timeout value. When the timeout value elapses, the timer expires and its TimerElapsedHandler delegate is called.</returns>
    public extern TimeSpan Delay { [MethodImpl] get; }

    /// <summary>Cancels a timer.</summary>
    [MethodImpl]
    public extern void Cancel();

    [Overload("CreatePeriodicTimer")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreatePeriodicTimer(
      TimerElapsedHandler handler,
      TimeSpan period);

    [Overload("CreateTimer")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreateTimer(
      TimerElapsedHandler handler,
      TimeSpan delay);

    [Overload("CreatePeriodicTimerWithCompletion")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreatePeriodicTimer(
      TimerElapsedHandler handler,
      TimeSpan period,
      TimerDestroyedHandler destroyed);

    [Overload("CreateTimerWithCompletion")]
    [MethodImpl]
    public static extern ThreadPoolTimer CreateTimer(
      TimerElapsedHandler handler,
      TimeSpan delay,
      TimerDestroyedHandler destroyed);
  }
}
