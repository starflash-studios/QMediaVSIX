// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionDetectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionDetectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(123238628, 22881, 15169, 157, 251, 206, 165, 216, 156, 195, 138)]
  internal interface ISpatialInteractionDetectedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);

    SpatialInteraction Interaction { get; }
  }
}
