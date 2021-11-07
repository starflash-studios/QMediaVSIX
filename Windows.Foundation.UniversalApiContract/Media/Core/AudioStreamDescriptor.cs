// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  /// <summary>Represents a description an audio media stream.</summary>
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IAudioStreamDescriptorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioStreamDescriptor : 
    IAudioStreamDescriptor,
    IMediaStreamDescriptor,
    IAudioStreamDescriptor2,
    IMediaStreamDescriptor2,
    IAudioStreamDescriptor3
  {
    /// <summary>Creates an instance of AudioStreamDescriptor class using the specified AudioEncodingProperties.</summary>
    /// <param name="encodingProperties">The encoding properties for the audio stream. This includes information such as the sample rate and channel count of the stream.</param>
    [MethodImpl]
    public extern AudioStreamDescriptor(AudioEncodingProperties encodingProperties);

    /// <summary>Gets an object describing the encoding properties for the audio stream. These properties include the sample rate and channel count of the audio.</summary>
    /// <returns>The encoding properties on the audio stream.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the stream is currently in use by a MediaStreamSource.</summary>
    /// <returns>**true** if the stream is currently in use by a MediaStreamSource; otherwise, **false**.</returns>
    public extern bool IsSelected { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the stream.</summary>
    /// <returns>The name of the stream.</returns>
    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the RFC-1766 language code for the stream.</summary>
    /// <returns>The RFC-1766 language code for the stream.</returns>
    public extern string Language { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the number of samples inserted at the beginning of the audio stream by the encoder as padding. Use this property to explicitly set the padding size the system will use to implement gapless playback for the audio stream.</summary>
    /// <returns>The number of samples inserted at the beginning of the audio stream by the encoder as padding.</returns>
    public extern IReference<uint> LeadingEncoderPadding { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the number of samples inserted at the end of the audio stream by the encoder as padding. Use this property to explicitly set the padding size the system will use to implement gapless playback for the audio stream.</summary>
    /// <returns>The number of samples inserted at the end of the audio stream by the encoder as padding.</returns>
    public extern IReference<uint> TrailingEncoderPadding { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets an app-defined label that identifies an audio stream in a MediaEncodingProfile that contains multiple streams.</summary>
    /// <returns>An app-defined label that identifies an audio stream</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates a copy of the AudioStreamDescriptor.</summary>
    /// <returns>A copy of the AudioStreamDescriptor.</returns>
    [MethodImpl]
    public extern AudioStreamDescriptor Copy();
  }
}
