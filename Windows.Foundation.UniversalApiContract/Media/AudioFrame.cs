// Decompiled with JetBrains decompiler
// Type: Windows.Media.AudioFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents a single frame of audio data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IAudioFrameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioFrame : IAudioFrame, IMediaFrame, IClosable
  {
    /// <summary>Initializes a new instance of the AudioFrame class.</summary>
    /// <param name="capacity">The maximum number of bytes that the buffer can hold.</param>
    [MethodImpl]
    public extern AudioFrame([Range(0, 2147483647)] uint capacity);

    /// <summary>Gets a AudioBuffer object that allows you to operate directly on the frame's audio data.</summary>
    /// <param name="mode">A value indicating the access mode of the returned audio buffer.</param>
    /// <returns>The buffer containing audio sample data.</returns>
    [MethodImpl]
    public extern AudioBuffer LockBuffer(AudioBufferAccessMode mode);

    /// <summary>Gets a string indicating the type of audio data the audio frame contains.</summary>
    /// <returns>A string indicating the type of audio data the audio frame contains.</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the audio frame is read-only.</summary>
    /// <returns>True if the audio frame is read-only; otherwise, false.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets or sets the relative time of the frame within the audio stream.</summary>
    /// <returns>The relative time of the frame within the audio stream.</returns>
    public extern IReference<TimeSpan> RelativeTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a timestamp that is relative to the system and is correlatable across multiple media sources on the same device.</summary>
    /// <returns>A timestamp relative to the system.</returns>
    public extern IReference<TimeSpan> SystemRelativeTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the audio frame.</summary>
    /// <returns>The duration of the audio frame.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether an audio frame is the first frame after a gap in the stream.</summary>
    /// <returns>True if the audio frame is the first frame after a gap in the stream; otherwise, false.</returns>
    public extern bool IsDiscontinuous { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the extended property set which enables getting and setting properties on the AudioFrame.</summary>
    /// <returns>The extended properties map.</returns>
    public extern IPropertySet ExtendedProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
