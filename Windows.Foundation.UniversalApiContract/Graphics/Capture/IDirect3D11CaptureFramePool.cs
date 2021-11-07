// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.IDirect3D11CaptureFramePool
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.System;

namespace Windows.Graphics.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Guid(619408674, 6517, 16942, 130, 231, 120, 13, 189, 141, 223, 36)]
  [ExclusiveTo(typeof (Direct3D11CaptureFramePool))]
  internal interface IDirect3D11CaptureFramePool
  {
    void Recreate(
      IDirect3DDevice device,
      DirectXPixelFormat pixelFormat,
      int numberOfBuffers,
      SizeInt32 size);

    Direct3D11CaptureFrame TryGetNextFrame();

    event TypedEventHandler<Direct3D11CaptureFramePool, object> FrameArrived;

    GraphicsCaptureSession CreateCaptureSession(GraphicsCaptureItem item);

    DispatcherQueue DispatcherQueue { get; }
  }
}
