// Decompiled with JetBrains decompiler
// Type: Windows.System.AppDiagnosticInfoWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Allows you to monitor diagnostic information for an app and get notifications when an app is added or removed from the list of running apps.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppDiagnosticInfoWatcher : IAppDiagnosticInfoWatcher
  {
    /// <summary>Event that fires when an app is added to the list of running apps.</summary>
    public extern event TypedEventHandler<AppDiagnosticInfoWatcher, AppDiagnosticInfoWatcherEventArgs> Added;

    /// <summary>Fires when one of the apps has been removed from the list of running apps.</summary>
    public extern event TypedEventHandler<AppDiagnosticInfoWatcher, AppDiagnosticInfoWatcherEventArgs> Removed;

    /// <summary>Fires when the watcher has completed enumerating the list of running apps that are available to monitor.</summary>
    public extern event TypedEventHandler<AppDiagnosticInfoWatcher, object> EnumerationCompleted;

    /// <summary>Event that fires when this **AppDiagnosticInfoWatcher** stops watching for changes.</summary>
    public extern event TypedEventHandler<AppDiagnosticInfoWatcher, object> Stopped;

    /// <summary>Gets this **AppDiagnosticInfoWatcher** status.</summary>
    /// <returns>The status such as Started, Stopped, and so on.</returns>
    public extern AppDiagnosticInfoWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Start firing events when the execution state changes, or apps change, within the list of running apps.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops firing events when the execution state changes, or apps change, within the list of running apps.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
