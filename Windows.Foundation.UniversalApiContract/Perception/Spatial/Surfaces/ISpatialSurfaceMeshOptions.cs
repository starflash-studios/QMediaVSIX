// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMeshOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Perception.Spatial.Surfaces
{
  [ExclusiveTo(typeof (SpatialSurfaceMeshOptions))]
  [Guid(3530923913, 13682, 15661, 161, 13, 95, 238, 147, 148, 170, 55)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialSurfaceMeshOptions
  {
    DirectXPixelFormat VertexPositionFormat { get; set; }

    DirectXPixelFormat TriangleIndexFormat { get; set; }

    DirectXPixelFormat VertexNormalFormat { get; set; }

    bool IncludeVertexNormals { get; set; }
  }
}
