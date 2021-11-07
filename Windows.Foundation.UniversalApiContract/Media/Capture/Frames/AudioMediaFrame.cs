// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.AudioMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a frame of audio data retreived from a MediaFrameSource.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class AudioMediaFrame : IAudioMediaFrame
  {
    /// <summary>Gets the MediaFrameReference wrapper object associated with the AudioMediaFrame, which provides access to format information and other properties of the media frame.</summary>
    /// <returns>The MediaFrameReference wrapper object associated with the AudioMediaFrame.</returns>
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    /// <summary>Gets an AudioEncodingProperties object that provides information about the audio data in the frame. This includes information like the bitrate, sample rate, and channel count of the audio data.</summary>
    /// <returns>An AudioEncodingProperties object that provides information about the audio data in the frame.</returns>
    public extern AudioEncodingProperties AudioEncodingProperties { [MethodImpl] get; }

    /// <summary>Creates a copy of the AudioMediaFrame as an AudioFrame object.</summary>
    /// <returns>An AudioFrame containing a copy of the AudioMediaFrame audio data.</returns>
    [MethodImpl]
    public extern AudioFrame GetAudioFrame();
  }
}
