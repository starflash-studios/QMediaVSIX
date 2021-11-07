// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IDirect3D11CaptureFramePoolStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;

namespace Windows.Graphics.Capture
{
  [WebHostHidden]
  [Guid(2005140842, 26538, 19795, 174, 84, 16, 136, 213, 168, 202, 33)]
  [ExclusiveTo(typeof (Direct3D11CaptureFramePool))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IDirect3D11CaptureFramePoolStatics
  {
    Direct3D11CaptureFramePool Create(
      IDirect3DDevice device,
      DirectXPixelFormat pixelFormat,
      int numberOfBuffers,
      SizeInt32 size);
  }
}
