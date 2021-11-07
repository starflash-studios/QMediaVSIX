// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(84436994, 62209, 17219, 146, 80, 47, 186, 165, 248, 122, 55)]
  [ExclusiveTo(typeof (SpatialManipulationCompletedEventArgs))]
  internal interface ISpatialManipulationCompletedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialManipulationDelta TryGetCumulativeDelta(
      SpatialCoordinateSystem coordinateSystem);
  }
}
