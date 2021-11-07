// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFileInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Audio
{
  /// <summary>Represents a node in an audio graph node that inputs audio data into the graph from an audio file.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class AudioFileInputNode : 
    IAudioFileInputNode,
    IAudioInputNode,
    IAudioNode,
    IClosable,
    IAudioInputNode2
  {
    /// <summary>Gets or sets the playback speed factor for the audio file input node.</summary>
    /// <returns>A value indicating the playback speed factor.</returns>
    public extern double PlaybackSpeedFactor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the playback position of the audio file input node.</summary>
    /// <returns>The current playback position within the audio file, in seconds.</returns>
    public extern TimeSpan Position { [MethodImpl] get; }

    [MethodImpl]
    public extern void Seek(TimeSpan position);

    /// <summary>Gets or sets the start time for the audio file input node.</summary>
    /// <returns>A value indicating the start time.</returns>
    public extern IReference<TimeSpan> StartTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the end time for the audio file input node, which determines when playback of the media content ends.</summary>
    /// <returns>A value indicating the end time.</returns>
    public extern IReference<TimeSpan> EndTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the loop count of the audio file input node.</summary>
    /// <returns>A reference to an integer representing the loop count.</returns>
    public extern IReference<int> LoopCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the duration for the audio input file.</summary>
    /// <returns>A value indicating the duration for the audio input file.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }

    /// <summary>Gets the source audio file for the audio file input node.</summary>
    /// <returns>A StorageFile object representing the source audio file.</returns>
    public extern StorageFile SourceFile { [MethodImpl] get; }

    /// <summary>Occurs when the playback position reaches the end of the audio file or the position specified with the EndTime property.</summary>
    public extern event TypedEventHandler<AudioFileInputNode, object> FileCompleted;

    /// <summary>Gets the list of outgoing connections from the audio file input node to other nodes in the audio graph.</summary>
    /// <returns>A collection of AudioGraphConnection objects representing the supported connections.</returns>
    public extern IVectorView<AudioGraphConnection> OutgoingConnections { [MethodImpl] get; }

    /// <summary>Adds an outgoing connection to the audio file input node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    [Overload("AddOutgoingConnection")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination);

    /// <summary>Adds an outgoing connection with gain to the audio file input node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    /// <param name="gain">A value indicating the gain associated with the connection. This is a scalar multiplier of the audio signal. The default value is 1.0.</param>
    [Overload("AddOutgoingConnectionWithGain")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination, double gain);

    /// <summary>Removes the outgoing connection from the audio file input node to the specified node.</summary>
    /// <param name="destination">The audio node for which the outgoing connection is removed.</param>
    [MethodImpl]
    public extern void RemoveOutgoingConnection(IAudioNode destination);

    /// <summary>Gets the list of effect definitions for the audio file input node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets the outgoing gain for the audio file input node.</summary>
    /// <returns>The outgoing gain value.</returns>
    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the encoding properties for the audio file input node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the audio file input node consumes input.</summary>
    /// <returns>True if the audio file input node consumes input, and false otherwise.</returns>
    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the audio file input node.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the audio file input node.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Resets the audio file input node.</summary>
    [MethodImpl]
    public extern void Reset();

    /// <summary>Disables all effects in the EffectDefinitions list with the specified effect definition.</summary>
    /// <param name="definition">The effect definition of the effects to disable.</param>
    [MethodImpl]
    public extern void DisableEffectsByDefinition(IAudioEffectDefinition definition);

    /// <summary>Enables all effects in the EffectDefinitions list with the specified effect definition.</summary>
    /// <param name="definition">The effect definition of the effects to enable.</param>
    [MethodImpl]
    public extern void EnableEffectsByDefinition(IAudioEffectDefinition definition);

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets the AudioNodeEmitter that describes the position and other physical characteristics of the emitter from which the AudioFileInputNode audio is emitted when spatial audio processing is used.</summary>
    /// <returns>The spatial audio emitter associated with the AudioFileInputNode.</returns>
    public extern AudioNodeEmitter Emitter { [MethodImpl] get; }
  }
}
