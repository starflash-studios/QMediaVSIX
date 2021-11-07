// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceLocation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionSourceLocation))]
  [Guid(1728243294, 59669, 19707, 156, 27, 5, 56, 239, 200, 102, 135)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISpatialInteractionSourceLocation3 : ISpatialInteractionSourceLocation2
  {
    SpatialInteractionSourcePositionAccuracy PositionAccuracy { get; }

    IReference<Vector3> AngularVelocity { get; }

    SpatialPointerInteractionSourcePose SourcePointerPose { get; }
  }
}
