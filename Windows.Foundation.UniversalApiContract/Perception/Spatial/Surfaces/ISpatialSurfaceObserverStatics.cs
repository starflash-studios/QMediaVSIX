// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceObserverStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceObserver))]
  [Guid(374952429, 8456, 16744, 145, 117, 135, 224, 39, 188, 146, 133)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialSurfaceObserverStatics
  {
    [RemoteAsync]
    IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
