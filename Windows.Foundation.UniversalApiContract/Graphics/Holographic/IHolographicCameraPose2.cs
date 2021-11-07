// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraPose2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(590078067, 23853, 17760, 129, 78, 38, 151, 196, 252, 225, 107)]
  [ExclusiveTo(typeof (HolographicCameraPose))]
  internal interface IHolographicCameraPose2
  {
    void OverrideViewTransform(
      SpatialCoordinateSystem coordinateSystem,
      HolographicStereoTransform coordinateSystemToViewTransform);

    void OverrideProjectionTransform(HolographicStereoTransform projectionTransform);

    void OverrideViewport(Rect leftViewport, Rect rightViewport);
  }
}
