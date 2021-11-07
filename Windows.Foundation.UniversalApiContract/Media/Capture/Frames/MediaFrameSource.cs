// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a source of media frames, such as a color or infrared camera.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class MediaFrameSource : IMediaFrameSource
  {
    /// <summary>Gets the MediaFrameSourceInfo object that provides information about the MediaFrameSource.</summary>
    /// <returns>The MediaFrameSourceInfo object that provides information about the media frame source.</returns>
    public extern MediaFrameSourceInfo Info { [MethodImpl] get; }

    /// <summary>Gets the MediaFrameSourceController for the MediaFrameSource.</summary>
    /// <returns>The MediaFrameSourceController for the media frame source.</returns>
    public extern MediaFrameSourceController Controller { [MethodImpl] get; }

    /// <summary>Gets a read-only list of MediaFrameFormat objects representing the frame formats supported by the MediaFrameSource.</summary>
    /// <returns>A read-only list of frame formats supported by the media frame source.</returns>
    public extern IVectorView<MediaFrameFormat> SupportedFormats { [MethodImpl] get; }

    /// <summary>Gets a value indicating the current frame format of the MediaFrameSource.</summary>
    /// <returns>A value indicating the current frame format of the media frame source.</returns>
    public extern MediaFrameFormat CurrentFormat { [MethodImpl] get; }

    /// <summary>Asynchronously sets the frame format of the MediaFrameSource.</summary>
    /// <param name="format">The new frame format for the media frame source.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetFormatAsync(MediaFrameFormat format);

    /// <summary>Occurs when the current frame format of the MediaFrameSource changes.</summary>
    public extern event TypedEventHandler<MediaFrameSource, object> FormatChanged;

    /// <summary>Attempts to retrieve the media frame source's camera intrinsics, which describe a camera's distortion model, for the specified MediaFrameFormat.</summary>
    /// <param name="format">The media frame format for which the camera intrinsics should be retrieved.</param>
    /// <returns>An object representing the camera intrinsics for the frame source, if they can be retrieved; otherwise, null.</returns>
    [MethodImpl]
    public extern CameraIntrinsics TryGetCameraIntrinsics(MediaFrameFormat format);
  }
}
