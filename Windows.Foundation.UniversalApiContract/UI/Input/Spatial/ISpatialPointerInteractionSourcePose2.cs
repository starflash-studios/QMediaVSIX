// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialPointerInteractionSourcePose2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [Guid(3972892344, 21211, 18079, 158, 63, 128, 196, 127, 116, 188, 233)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SpatialPointerInteractionSourcePose))]
  internal interface ISpatialPointerInteractionSourcePose2 : ISpatialPointerInteractionSourcePose
  {
    Quaternion Orientation { get; }

    SpatialInteractionSourcePositionAccuracy PositionAccuracy { get; }
  }
}
