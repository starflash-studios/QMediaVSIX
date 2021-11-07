// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.VideoMediaFrameFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Describes the image format of a VideoMediaFrame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class VideoMediaFrameFormat : IVideoMediaFrameFormat
  {
    /// <summary>Gets an object that provides information about the format of the media frame that is not specific to video frames.</summary>
    /// <returns>An object that provides information about the format of the media frame.</returns>
    public extern MediaFrameFormat MediaFrameFormat { [MethodImpl] get; }

    /// <summary>Gets an object that describes the format of the depth data in a video media frame, if the frame contains depth data.</summary>
    /// <returns>An object that describes the format of the depth data in a video media frame.</returns>
    public extern DepthMediaFrameFormat DepthFormat { [MethodImpl] get; }

    /// <summary>Gets the width of the video media frame, in pixels.</summary>
    /// <returns>The width of the video media frame, in pixels.</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of the video media frame, in pixels.</summary>
    /// <returns>The height of the video media frame, in pixels.</returns>
    public extern uint Height { [MethodImpl] get; }
  }
}
