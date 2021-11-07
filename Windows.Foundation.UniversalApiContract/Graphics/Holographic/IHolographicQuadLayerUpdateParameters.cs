// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicQuadLayerUpdateParameters
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
  [ExclusiveTo(typeof (HolographicQuadLayerUpdateParameters))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(722379696, 31117, 23498, 85, 194, 44, 12, 118, 46, 187, 8)]
  internal interface IHolographicQuadLayerUpdateParameters
  {
    IDirect3DSurface AcquireBufferToUpdateContent();

    void UpdateViewport(Rect value);

    void UpdateContentProtectionEnabled(bool value);

    void UpdateExtents(Vector2 value);

    void UpdateLocationWithStationaryMode(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Quaternion orientation);

    void UpdateLocationWithDisplayRelativeMode(Vector3 position, Quaternion orientation);
  }
}
