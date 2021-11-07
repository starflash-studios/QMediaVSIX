// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Holographic.HolographicKeyboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.ApplicationModel.Holographic
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  [Static(typeof (IHolographicKeyboardStatics), 720896, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicKeyboard : IHolographicKeyboard
  {
    [Overload("SetPlacementOverride")]
    [MethodImpl]
    public extern void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Quaternion orientation);

    [Overload("SetPlacementOverrideWithMaxSize")]
    [MethodImpl]
    public extern void SetPlacementOverride(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 topCenterPosition,
      Quaternion orientation,
      Vector2 maxSize);

    [MethodImpl]
    public extern void ResetPlacementOverride();

    [MethodImpl]
    public static extern HolographicKeyboard GetDefault();
  }
}
