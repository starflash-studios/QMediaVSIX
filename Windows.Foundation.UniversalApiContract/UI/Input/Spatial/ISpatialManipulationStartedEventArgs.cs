// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialManipulationStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(2715204558, 17061, 14203, 173, 166, 210, 142, 61, 56, 71, 55)]
  [ExclusiveTo(typeof (SpatialManipulationStartedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialManipulationStartedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);
  }
}
