// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialStageFrameOfReferenceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(4153236557, 41124, 18844, 141, 145, 168, 201, 101, 212, 6, 84)]
  [ExclusiveTo(typeof (SpatialStageFrameOfReference))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialStageFrameOfReferenceStatics
  {
    SpatialStageFrameOfReference Current { get; }

    event EventHandler<object> CurrentChanged;

    [RemoteAsync]
    IAsyncOperation<SpatialStageFrameOfReference> RequestNewStageAsync();
  }
}
