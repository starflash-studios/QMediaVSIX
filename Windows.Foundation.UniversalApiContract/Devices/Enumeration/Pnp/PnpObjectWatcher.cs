// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Pnp.PnpObjectWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration.Pnp
{
  /// <summary>Raises events to notify the client that a PnpObject has been added, updated, or removed from an enumerated collection of Pnp device objects in an incremental and asynchronous way.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PnpObjectWatcher : IPnpObjectWatcher
  {
    /// <summary>Occurs when a PnpObject is added to the collection enumerated by the PnpObjectWatcher.</summary>
    public extern event TypedEventHandler<PnpObjectWatcher, PnpObject> Added;

    /// <summary>Occurs when the properties of a PnpObject in the collection enumerated by the PnpObjectWatcher are updated.</summary>
    public extern event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Updated;

    /// <summary>Occurs when a PnpObject is removed from the collection enumerated by the PnpObjectWatcher.</summary>
    public extern event TypedEventHandler<PnpObjectWatcher, PnpObjectUpdate> Removed;

    /// <summary>Occurs when the enumeration of Pnp device objects has been completed.</summary>
    public extern event TypedEventHandler<PnpObjectWatcher, object> EnumerationCompleted;

    /// <summary>Occurs when the PnpObjectWatcher has stopped monitoring changes to the collection of Pnp device objects.</summary>
    public extern event TypedEventHandler<PnpObjectWatcher, object> Stopped;

    /// <summary>The status associated with the asynchronous operation.</summary>
    /// <returns>The status.</returns>
    public extern DeviceWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Starts raising the events to inform the client that a PnpObject has been added, updated, or removed.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops raising the events to inform the client that a PnpObject has been added, updated, or removed.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
