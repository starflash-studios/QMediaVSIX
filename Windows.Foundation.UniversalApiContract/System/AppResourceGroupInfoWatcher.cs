// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupInfoWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Allows you to monitor the set of resource groups (AppResourceGroupInfo objects) for an app, and get notifications when a resource group is added or removed.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class AppResourceGroupInfoWatcher : IAppResourceGroupInfoWatcher
  {
    /// <summary>Event that fires when a resource group is added.</summary>
    public extern event TypedEventHandler<AppResourceGroupInfoWatcher, AppResourceGroupInfoWatcherEventArgs> Added;

    /// <summary>Fires when one of the resource groups has been removed from the list of AppResourceGroupInfos in the package.</summary>
    public extern event TypedEventHandler<AppResourceGroupInfoWatcher, AppResourceGroupInfoWatcherEventArgs> Removed;

    /// <summary>Fires when the watcher has completed enumerating the resource groups that are available to monitor.</summary>
    public extern event TypedEventHandler<AppResourceGroupInfoWatcher, object> EnumerationCompleted;

    /// <summary>Event that fires when this **AppResourceGroupInfoWatcher** stops watching for resource group changes.</summary>
    public extern event TypedEventHandler<AppResourceGroupInfoWatcher, object> Stopped;

    /// <summary>Event that fires when the execution state (running, suspending, an so on) for this group changes.</summary>
    public extern event TypedEventHandler<AppResourceGroupInfoWatcher, AppResourceGroupInfoWatcherExecutionStateChangedEventArgs> ExecutionStateChanged;

    /// <summary>Gets this **AppResourceGroupInfoWatcher** status.</summary>
    /// <returns>The status such as Started, Stopped, and so on.</returns>
    public extern AppResourceGroupInfoWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Start firing events when the execution state changes, or resource groups change, within the set of resource groups for this app.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops firing events when the execution state changes, or resource groups change, within the set of resource groups for this app.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
