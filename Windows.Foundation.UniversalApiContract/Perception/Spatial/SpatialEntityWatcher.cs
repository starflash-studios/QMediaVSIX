// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntityWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Monitors changes to the set of entities that participants add, update, or remove within a spatial entity store, and provides notifications when that set changes.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialEntityWatcher : ISpatialEntityWatcher
  {
    /// <summary>Gets the operational status of the spatial entity watcher.</summary>
    /// <returns>The status.</returns>
    public extern SpatialEntityWatcherStatus Status { [MethodImpl] get; }

    /// <summary>The event that is raised when a new spatial entity is added to the store by a participant.</summary>
    public extern event TypedEventHandler<SpatialEntityWatcher, SpatialEntityAddedEventArgs> Added;

    /// <summary>The event that is raised when an existing spatial entity has its metadata updated by a participant.</summary>
    public extern event TypedEventHandler<SpatialEntityWatcher, SpatialEntityUpdatedEventArgs> Updated;

    /// <summary>The event that is raised when a spatial entity is removed from the store by a participant.</summary>
    public extern event TypedEventHandler<SpatialEntityWatcher, SpatialEntityRemovedEventArgs> Removed;

    /// <summary>The event that is raised when the initial replay of prior changes to the spatial entity store has completed.</summary>
    public extern event TypedEventHandler<SpatialEntityWatcher, object> EnumerationCompleted;

    /// <summary>Starts watching for changes to the set of spatial entities in the store.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops watching for changes to the set of spatial entities in the store.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
