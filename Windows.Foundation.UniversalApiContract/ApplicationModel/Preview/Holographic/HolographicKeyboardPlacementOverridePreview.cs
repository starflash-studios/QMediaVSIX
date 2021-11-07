// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.ApplicationModel.Preview.Holographic
{
  /// <summary>Provides preview functionality that let apps influence the placement of the system keyboard in the holographic shell. This API is available only to a limited set of apps while in the preview phase.</summary>
  [Static(typeof (IHolographicKeyboardPlacementOverridePreviewStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicKeyboardPlacementOverridePreview : 
    IHolographicKeyboardPlacementOverridePreview
  {
    [Overload("SetPlacementOverride")]
    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Vector3 normal);

    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [Overload("SetPlacementOverrideWithMaxSize")]
    [MethodImpl]
    public extern void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Vector3 normal,
      Vector2 maxSize);

    /// <summary>Resets the placement of the system keyboard in the holographic shell to its natural position. This API is available only to a limited set of apps while in the preview phase.</summary>
    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ResetPlacementOverride();

    /// <summary>Gets an object that allows for override of the placement of the system keyboard in the holographic shell while the current view is visible. This API is available only to a limited set of apps while in the preview phase.</summary>
    /// <returns>The placement override object.</returns>
    [Deprecated("Use Windows.ApplicationModel.Holographic.HolographicKeyboard instead of Windows.ApplicationModel.Preview.Holographic.HolographicKeyboardPlacementOverridePreview. For more info, see MSDN.", DeprecationType.Deprecate, 720896, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern HolographicKeyboardPlacementOverridePreview GetForCurrentView();
  }
}
