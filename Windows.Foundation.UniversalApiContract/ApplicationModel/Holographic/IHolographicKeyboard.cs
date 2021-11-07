// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Holographic.IHolographicKeyboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.ApplicationModel.Holographic
{
  [Guid(131926163, 43553, 24175, 169, 27, 17, 178, 179, 253, 123, 227)]
  [ExclusiveTo(typeof (HolographicKeyboard))]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IHolographicKeyboard
  {
    [Overload("SetPlacementOverride")]
    void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Quaternion orientation);

    [Overload("SetPlacementOverrideWithMaxSize")]
    void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Quaternion orientation,
      Vector2 maxSize);

    void ResetPlacementOverride();
  }
}
