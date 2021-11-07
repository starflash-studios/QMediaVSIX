// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntityStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a shared pool of spatial entities, synchronized automatically among the participants in a remote session.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ISpatialEntityStoreStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpatialEntityStore : ISpatialEntityStore
  {
    /// <summary>Saves a new or updated spatial entity into the store, to be synchronized with all participants.</summary>
    /// <param name="entity">The new or updated spatial entity.</param>
    /// <returns>Action that triggers once the entity data has been communicated to the host.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync(SpatialEntity entity);

    /// <summary>Removes a spatial entity from the store for all participants.</summary>
    /// <param name="entity">The spatial entity to remove.</param>
    /// <returns>Action that triggers once the entity removal has been communicated to the host.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveAsync(SpatialEntity entity);

    /// <summary>Gets a watcher that lets an app observe when participants add, update or remove entities in the store.</summary>
    /// <returns>The entity watcher.</returns>
    [MethodImpl]
    public extern SpatialEntityWatcher CreateEntityWatcher();

    /// <summary>Gets whether spatial entity sharing is supported on this system.</summary>
    /// <returns>Whether spatial entity sharing is supported on this system.</returns>
    public static extern bool IsSupported { [MethodImpl] get; }

    /// <summary>Establishes or retrieves an automatically-synchronized pool of spatial entities for a remote session.</summary>
    /// <param name="session">The remote session with the participants that will share spatial entities.</param>
    /// <returns>The spatial entity store.</returns>
    [Overload("TryGetForRemoteSystemSession")]
    [MethodImpl]
    public static extern SpatialEntityStore TryGet(RemoteSystemSession session);
  }
}
