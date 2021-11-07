// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFrameInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Audio
{
  /// <summary>Represents a node in an audio graph node that inputs audio data into the graph from app-implemented code that generates audio samples programmatically.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioFrameInputNode : 
    IAudioFrameInputNode,
    IAudioInputNode,
    IAudioNode,
    IClosable,
    IAudioInputNode2
  {
    /// <summary>Gets or sets the playback speed factor for the audio frame input node.</summary>
    /// <returns>A value indicating the playback speed factor.</returns>
    public extern double PlaybackSpeedFactor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Adds an audio frame to the audio frame input node.</summary>
    /// <param name="frame">An AudioFrame object representing the frame.</param>
    [MethodImpl]
    public extern void AddFrame(AudioFrame frame);

    /// <summary>Removes queued frames from the audio frame input node.</summary>
    [MethodImpl]
    public extern void DiscardQueuedFrames();

    /// <summary>Gets the queued sample count for the audio frame input node.</summary>
    /// <returns>A value indicating the queued sample count.</returns>
    public extern ulong QueuedSampleCount { [MethodImpl] get; }

    /// <summary>Notifies of a completed audio frame that has been submitted to the graph with a call to AddFrame.</summary>
    public extern event TypedEventHandler<AudioFrameInputNode, AudioFrameCompletedEventArgs> AudioFrameCompleted;

    /// <summary>Raised when the audio graph is ready to begin processing a new quantum of data.</summary>
    public extern event TypedEventHandler<AudioFrameInputNode, FrameInputNodeQuantumStartedEventArgs> QuantumStarted;

    /// <summary>Gets the list of outgoing connections from the audio frame input node to other nodes in the audio graph.</summary>
    /// <returns>A collection of AudioGraphConnection objects representing the supported connections.</returns>
    public extern IVectorView<AudioGraphConnection> OutgoingConnections { [MethodImpl] get; }

    /// <summary>Adds an outgoing connection to the audio frame input node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    [Overload("AddOutgoingConnection")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination);

    /// <summary>Adds an outgoing connection with gain to the audio frame input node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    /// <param name="gain">A value indicating the gain associated with the connection. This is a scalar multiplier of the audio signal. The default value is 1.0.</param>
    [Overload("AddOutgoingConnectionWithGain")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination, double gain);

    /// <summary>Removes the outgoing connection from the audio frame input node to the specified node.</summary>
    /// <param name="destination">The audio node for which the outgoing connection is removed.</param>
    [MethodImpl]
    public extern void RemoveOutgoingConnection(IAudioNode destination);

    /// <summary>Gets the list of effect definitions for the audio frame input node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets the outgoing gain for the audio frame input node.</summary>
    /// <returns>The outgoing gain value.</returns>
    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the encoding properties for the audio frame input node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the audio frame input node consumes input.</summary>
    /// <returns>True if the audio frame input node consumes input, and false otherwise.</returns>
    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the audio frame input node.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the audio frame input node.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Resets the audio frame input node.</summary>
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

    /// <summary>Gets the AudioNodeEmitter that describes the position and other physical characteristics of the emitter from which the AudioFrameInputNode audio is emitted when spatial audio processing is used.</summary>
    /// <returns>The spatial audio emitter associated with the AudioFrameInputNode.</returns>
    public extern AudioNodeEmitter Emitter { [MethodImpl] get; }
  }
}
