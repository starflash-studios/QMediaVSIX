// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionVideoFrameAllocator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>An allocator that can create PerceptionFrames directly which can be written into or copied from Windows::Media::VideoFrame into a PerceptionFrame.</summary>
  /// <deprecated type="deprecate">PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IPerceptionVideoFrameAllocatorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PerceptionVideoFrameAllocator : IPerceptionVideoFrameAllocator, IClosable
  {
    /// <summary>Initializes a new PerceptionVideoFrameAllocator with the required properties for use by the IPerceptionFrameProvider to create PerceptionFrames published via PerceptionFrameProviderManagerService::PublishFrameForProvider.</summary>
    /// <deprecated type="deprecate">PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="maxOutstandingFrameCountForWrite">This is the number of buffers in flight required by the FrameProvider to produce its * frames at framerate. The suggestion is at least 2.</param>
    /// <param name="format">The Windows::Graphics::Imaging::BitmapPixelFormat describing the format of the bytes of the frame.</param>
    /// <param name="resolution">The resolution in pixels of the frame.</param>
    /// <param name="alpha">The Windows::Graphics::Imaging::BitmapAlphaMode describing how transparency is handled in the pixels.</param>
    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionVideoFrameAllocator(
      uint maxOutstandingFrameCountForWrite,
      BitmapPixelFormat format,
      Size resolution,
      BitmapAlphaMode alpha);

    /// <summary>Creates an empty PerceptionFrame with the properties specified when creating the PerceptionVideoFrameAllocator.</summary>
    /// <deprecated type="deprecate">PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <returns>The empty frame with the properties specified when creating the PerceptionVideoFrameAllocator.</returns>
    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionFrame AllocateFrame();

    /// <summary>Creates a deep copy of the video FrameProvider with the bytes already filled in with the resulting PerceptionFrame.</summary>
    /// <deprecated type="deprecate">PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="frame">The input frame from which to copy the pixel data.</param>
    /// <returns>The resulting filled PerceptionFrame.</returns>
    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionFrame CopyFromVideoFrame(VideoFrame frame);

    [MethodImpl]
    public extern void Close();
  }
}
