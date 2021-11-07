// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Describes the format of a media frame obtained from a MediaFrameSource and represented by a MediaFrameReference.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaFrameFormat : IMediaFrameFormat, IMediaFrameFormat2
  {
    /// <summary>Gets a string identifying the major type of a media frame.</summary>
    /// <returns>A string identifying the major type of a media frame.</returns>
    public extern string MajorType { [MethodImpl] get; }

    /// <summary>Gets a string identifying the subtype of a media frame.</summary>
    /// <returns>A string identifying the subtype of a media frame.</returns>
    public extern string Subtype { [MethodImpl] get; }

    /// <summary>Gets the frame rate of the media frame.</summary>
    /// <returns>The frame rate, in frames per second.</returns>
    public extern MediaRatio FrameRate { [MethodImpl] get; }

    /// <summary>Gets a map of properties for the frame format.</summary>
    /// <returns>A map of properties for the frame format.</returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    /// <summary>Gets an object describing the image format of a video media frame.</summary>
    /// <returns>An object describing the image format of a video media frame.</returns>
    public extern VideoMediaFrameFormat VideoFormat { [MethodImpl] get; }

    /// <summary>Gets an AudioEncodingProperties object that provides information about the audio data in an audio frame. This includes information like the bitrate, sample rate, and channel count of the audio data.</summary>
    /// <returns>An AudioEncodingProperties object that provides information about the audio data in the frame.</returns>
    public extern AudioEncodingProperties AudioEncodingProperties { [MethodImpl] get; }
  }
}
