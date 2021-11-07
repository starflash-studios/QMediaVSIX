// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IDirect3D11CaptureFramePoolStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Capture
{
  [Guid(1486557247, 27580, 24053, 169, 145, 2, 226, 139, 59, 102, 213)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Direct3D11CaptureFramePool))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDirect3D11CaptureFramePoolStatics2
  {
    Direct3D11CaptureFramePool CreateFreeThreaded(
      IDirect3DDevice device,
      DirectXPixelFormat pixelFormat,
      int numberOfBuffers,
      SizeInt32 size);
  }
}
