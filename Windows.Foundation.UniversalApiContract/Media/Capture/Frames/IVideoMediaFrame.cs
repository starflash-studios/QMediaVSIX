// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IVideoMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  [Guid(14503115, 12989, 20449, 160, 19, 124, 193, 60, 245, 219, 207)]
  [ExclusiveTo(typeof (VideoMediaFrame))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVideoMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    VideoMediaFrameFormat VideoFormat { get; }

    SoftwareBitmap SoftwareBitmap { get; }

    IDirect3DSurface Direct3DSurface { get; }

    CameraIntrinsics CameraIntrinsics { get; }

    InfraredMediaFrame InfraredMediaFrame { get; }

    DepthMediaFrame DepthMediaFrame { get; }

    VideoFrame GetVideoFrame();
  }
}
