// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Surfaces.ISpatialSurfaceMeshBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Storage.Streams;

namespace Windows.Perception.Spatial.Surfaces
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2479839712, 34591, 13304, 152, 178, 3, 209, 1, 69, 143, 111)]
  [ExclusiveTo(typeof (SpatialSurfaceMeshBuffer))]
  internal interface ISpatialSurfaceMeshBuffer
  {
    DirectXPixelFormat Format { get; }

    uint Stride { get; }

    uint ElementCount { get; }

    IBuffer Data { get; }
  }
}
