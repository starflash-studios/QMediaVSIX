// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMeshOptionsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Perception.Spatial.Surfaces
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2603879103, 38785, 17669, 137, 53, 1, 53, 117, 202, 174, 94)]
  [ExclusiveTo(typeof (SpatialSurfaceMeshOptions))]
  internal interface ISpatialSurfaceMeshOptionsStatics
  {
    IVectorView<DirectXPixelFormat> SupportedVertexPositionFormats { get; }

    IVectorView<DirectXPixelFormat> SupportedTriangleIndexFormats { get; }

    IVectorView<DirectXPixelFormat> SupportedVertexNormalFormats { get; }
  }
}
