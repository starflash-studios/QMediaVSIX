// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.Core.SignalNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading.Core
{
  /// <summary>Runs a method when an event or semaphore is signaled. A timeout value can also be specified, causing the delegate to run after the time span has elapsed if the named event does not occur (or if the semaphore does not reach a signaled state).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISignalNotifierStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [global::Windows.Foundation.Metadata.Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class SignalNotifier : ISignalNotifier
  {
    /// <summary>Submits the SignalNotifier to the thread pool.</summary>
    [MethodImpl]
    public extern void Enable();

    /// <summary>Terminates the SignalNotifier if it has not already started running.</summary>
    [MethodImpl]
    public extern void Terminate();

    /// <summary>Attaches a SignalHandler delegate to an event. The delegated method will run the next time the event occurs.</summary>
    /// <param name="name">Indicates the event that causes the method to run.</param>
    /// <param name="handler">Indicates the method that will run in response to the event.</param>
    /// <returns>The resulting SignalNotifier object.</returns>
    [Overload("AttachToEvent")]
    [MethodImpl]
    public static extern SignalNotifier AttachToEvent(
      string name,
      SignalHandler handler);

    [Overload("AttachToEventWithTimeout")]
    [MethodImpl]
    public static extern SignalNotifier AttachToEvent(
      string name,
      SignalHandler handler,
      TimeSpan timeout);

    /// <summary>Attaches a SignalHandler delegate to a named semaphore. The delegated method will run when the named semaphore is signaled.</summary>
    /// <param name="name">Names the semaphore that signals the method to run.</param>
    /// <param name="handler">Indicates the delegate that will run in response to the named semaphore entering the signaled state.</param>
    /// <returns>The resulting SignalNotifier object.</returns>
    [Overload("AttachToSemaphore")]
    [MethodImpl]
    public static extern SignalNotifier AttachToSemaphore(
      string name,
      SignalHandler handler);

    [Overload("AttachToSemaphoreWithTimeout")]
    [MethodImpl]
    public static extern SignalNotifier AttachToSemaphore(
      string name,
      SignalHandler handler,
      TimeSpan timeout);
  }
}
