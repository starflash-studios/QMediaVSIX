// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicCameraRenderingParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  [Guid(2393648849, 23540, 19990, 130, 54, 174, 8, 0, 193, 29, 13)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (HolographicCameraRenderingParameters))]
  internal interface IHolographicCameraRenderingParameters
  {
    [Overload("SetFocusPoint")]
    void SetFocusPoint(SpatialCoordinateSystem coordinateSystem, Vector3 position);

    [Overload("SetFocusPointWithNormal")]
    void SetFocusPoint(SpatialCoordinateSystem coordinateSystem, Vector3 position, Vector3 normal);

    [Overload("SetFocusPointWithNormalLinearVelocity")]
    void SetFocusPoint(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Vector3 normal,
      Vector3 linearVelocity);

    IDirect3DDevice Direct3D11Device { get; }

    IDirect3DSurface Direct3D11BackBuffer { get; }
  }
}
