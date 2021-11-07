// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class used to enumerate the eSIMs carried by a device and to watch for eSIMs being added to the device, removed from it, or updated.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class ESimWatcher : IESimWatcher
  {
    /// <summary>Gets the status of the eSIM watcher.</summary>
    /// <returns>The status of the eSIM watcher.</returns>
    public extern ESimWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Starts the eSIM watcher watching for eSIMs being added to the device, removed from it, or updated.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the eSIM watcher watching for eSIMs being added to the device, removed from it, or updated.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Occurs when an ESim is added to the device.</summary>
    public extern event TypedEventHandler<ESimWatcher, ESimAddedEventArgs> Added;

    /// <summary>Occurs when the watcher has finished enumerating the collection of ESim objects carried by the device.</summary>
    public extern event TypedEventHandler<ESimWatcher, object> EnumerationCompleted;

    /// <summary>Occurs when an ESim is removed from the device.</summary>
    public extern event TypedEventHandler<ESimWatcher, ESimRemovedEventArgs> Removed;

    /// <summary>Occurs when the eSIM watcher is stopped.</summary>
    public extern event TypedEventHandler<ESimWatcher, object> Stopped;

    /// <summary>Occurs when an ESim on the device is updated.</summary>
    public extern event TypedEventHandler<ESimWatcher, ESimUpdatedEventArgs> Updated;
  }
}
