// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [Guid(226328112, 4830, 17853, 145, 43, 199, 246, 86, 21, 153, 209)]
  [ExclusiveTo(typeof (HolographicCameraPose))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IHolographicCameraPose
  {
    HolographicCamera HolographicCamera { get; }

    Rect Viewport { get; }

    IReference<HolographicStereoTransform> TryGetViewTransform(
      SpatialCoordinateSystem coordinateSystem);

    HolographicStereoTransform ProjectionTransform { get; }

    IReference<SpatialBoundingFrustum> TryGetCullingFrustum(
      SpatialCoordinateSystem coordinateSystem);

    IReference<SpatialBoundingFrustum> TryGetVisibleFrustum(
      SpatialCoordinateSystem coordinateSystem);

    double NearPlaneDistance { get; }

    double FarPlaneDistance { get; }
  }
}
