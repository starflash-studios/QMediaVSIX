// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceObserver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(280401945, 56778, 13443, 172, 58, 116, 143, 232, 200, 109, 245)]
  [ExclusiveTo(typeof (SpatialSurfaceObserver))]
  internal interface ISpatialSurfaceObserver
  {
    IMapView<Guid, SpatialSurfaceInfo> GetObservedSurfaces();

    void SetBoundingVolume(SpatialBoundingVolume bounds);

    void SetBoundingVolumes(IIterable<SpatialBoundingVolume> bounds);

    event TypedEventHandler<SpatialSurfaceObserver, object> ObservedSurfacesChanged;
  }
}
