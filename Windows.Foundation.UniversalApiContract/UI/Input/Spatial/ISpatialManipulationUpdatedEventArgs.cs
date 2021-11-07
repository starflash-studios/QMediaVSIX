// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1596132251, 24774, 19910, 189, 201, 159, 74, 111, 21, 254, 73)]
  [ExclusiveTo(typeof (SpatialManipulationUpdatedEventArgs))]
  internal interface ISpatialManipulationUpdatedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialManipulationDelta TryGetCumulativeDelta(
      SpatialCoordinateSystem coordinateSystem);
  }
}
