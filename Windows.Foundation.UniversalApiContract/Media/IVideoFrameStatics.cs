// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoFrameStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;

namespace Windows.Media
{
  [Guid(2871678319, 24849, 19251, 142, 195, 43, 32, 154, 2, 225, 122)]
  [ExclusiveTo(typeof (VideoFrame))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IVideoFrameStatics
  {
    [Overload("CreateAsDirect3D11SurfaceBacked")]
    VideoFrame CreateAsDirect3D11SurfaceBacked(
      DirectXPixelFormat format,
      int width,
      int height);

    [Overload("CreateAsDirect3D11SurfaceBackedWithDevice")]
    VideoFrame CreateAsDirect3D11SurfaceBacked(
      DirectXPixelFormat format,
      int width,
      int height,
      IDirect3DDevice device);

    VideoFrame CreateWithSoftwareBitmap(SoftwareBitmap bitmap);

    VideoFrame CreateWithDirect3D11Surface(IDirect3DSurface surface);
  }
}
