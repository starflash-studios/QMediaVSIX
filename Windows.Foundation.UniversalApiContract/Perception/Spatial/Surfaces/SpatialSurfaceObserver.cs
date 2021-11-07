// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  /// <summary>Provides methods for observing surfaces in the user's surroundings.</summary>
  [Static(typeof (ISpatialSurfaceObserverStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISpatialSurfaceObserverStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialSurfaceObserver : ISpatialSurfaceObserver
  {
    /// <summary>Initializes a new instance of the SpatialSurfaceObserver class.</summary>
    [MethodImpl]
    public extern SpatialSurfaceObserver();

    /// <summary>Gets metadata for the set of surfaces observed within the bounding volume at the moment.</summary>
    /// <returns>The observed surfaces.</returns>
    [MethodImpl]
    public extern IMapView<Guid, SpatialSurfaceInfo> GetObservedSurfaces();

    /// <summary>Sets the single bounding volume that this observer will track for new, updated or removed surfaces.</summary>
    /// <param name="bounds">The new bounding volume for this observer to track for surface updates.</param>
    [MethodImpl]
    public extern void SetBoundingVolume(SpatialBoundingVolume bounds);

    [MethodImpl]
    public extern void SetBoundingVolumes(IIterable<SpatialBoundingVolume> bounds);

    /// <summary>Occurs when the set of surface metadata observed within the bounding volume has changed.</summary>
    public extern event TypedEventHandler<SpatialSurfaceObserver, object> ObservedSurfacesChanged;

    /// <summary>Gets whether spatial mapping is supported on the current system.</summary>
    /// <returns>Whether spatial mapping is supported.</returns>
    [MethodImpl]
    public static extern bool IsSupported();

    /// <summary>Requests access for an app to use spatial mapping. This requires the spatialPerception capability.</summary>
    /// <returns>Operation that triggers once the user has completed any consent dialog, providing the access status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
