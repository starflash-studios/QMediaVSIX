// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.VideoMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Graphics.Imaging;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a frame from a MediaFrameSource that provides data in a video frame represented by a IDirect3DSurface or SoftwareBitmap.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VideoMediaFrame : IVideoMediaFrame
  {
    /// <summary>Gets the MediaFrameReference wrapper object associated with the VideoMediaFrame, which provides access to format information and other properties of the media frame.</summary>
    /// <returns>The MediaFrameReference wrapper object associated with the VideoMediaFrame.</returns>
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    /// <summary>Gets an object describing the format of the VideoMediaFrame image data.</summary>
    /// <returns>An object describing the format of the VideoMediaFrame image data.</returns>
    public extern VideoMediaFrameFormat VideoFormat { [MethodImpl] get; }

    /// <summary>Gets a SoftwareBitmap object containing the image data for the VideoMediaFrame.</summary>
    /// <returns>A SoftwareBitmap object containing the image data for the VideoMediaFrame.</returns>
    public extern SoftwareBitmap SoftwareBitmap { [MethodImpl] get; }

    /// <summary>Gets an IDirect3DSurface object containing the image data for the VideoMediaFrame.</summary>
    /// <returns>An IDirect3DSurface object containing the image data for the VideoMediaFrame.</returns>
    public extern IDirect3DSurface Direct3DSurface { [MethodImpl] get; }

    /// <summary>Gets an object that describes the distortion model of the camera that generated the VideoMediaFrame.</summary>
    /// <returns>An object that describes the distortion model of the camera that generated the VideoMediaFrame.</returns>
    public extern CameraIntrinsics CameraIntrinsics { [MethodImpl] get; }

    /// <summary>Gets an InfraredMediaFrame containing depth data for the VideoMediaFrame, if the frame contains infrared data.</summary>
    /// <returns>A InfraredMediaFrame containing infrared data.</returns>
    public extern InfraredMediaFrame InfraredMediaFrame { [MethodImpl] get; }

    /// <summary>Gets a DepthMediaFrame containing depth data for the VideoMediaFrame, if the frame contains depth data.</summary>
    /// <returns>A DepthMediaFrame containing depth data.</returns>
    public extern DepthMediaFrame DepthMediaFrame { [MethodImpl] get; }

    /// <summary>Creates a copy of the VideoMediaFrame as a VideoFrame object.</summary>
    /// <returns>The VideoFrame containing a copy of the VideoMediaFrame image data.</returns>
    [MethodImpl]
    public extern VideoFrame GetVideoFrame();
  }
}
