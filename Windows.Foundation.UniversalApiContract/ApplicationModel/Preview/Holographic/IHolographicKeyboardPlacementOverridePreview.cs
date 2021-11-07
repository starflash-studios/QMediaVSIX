// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.IHolographicKeyboardPlacementOverridePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.ApplicationModel.Preview.Holographic
{
  [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (HolographicKeyboardPlacementOverridePreview))]
  [Guid(3366506042, 57310, 23060, 141, 95, 24, 44, 82, 109, 217, 196)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IHolographicKeyboardPlacementOverridePreview
  {
    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [Overload("SetPlacementOverride")]
    void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Vector3 normal);

    [Overload("SetPlacementOverrideWithMaxSize")]
    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Vector3 normal,
      Vector2 maxSize);

    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    void ResetPlacementOverride();
  }
}
