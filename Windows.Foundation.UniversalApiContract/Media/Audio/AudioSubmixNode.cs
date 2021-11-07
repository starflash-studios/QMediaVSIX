// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioSubmixNode
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
  /// <summary>Represents an audio submix node that mixes the output of one or more nodes into single output that can be connected to output nodes or other submix nodes.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class AudioSubmixNode : IAudioInputNode, IAudioNode, IClosable, IAudioInputNode2
  {
    /// <summary>Gets outgoing connections from the audio submix node to other nodes in the audio graph.</summary>
    /// <returns>A collection of objects representing audio graph connections.</returns>
    public extern IVectorView<AudioGraphConnection> OutgoingConnections { [MethodImpl] get; }

    /// <summary>Adds an outgoing connection to the audio submix node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    [Overload("AddOutgoingConnection")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination);

    /// <summary>Adds an outgoing connection with gain to the audio submix node.</summary>
    /// <param name="destination">The destination node for the connection.</param>
    /// <param name="gain">A value indicating the gain associated with the connection. This is a scalar multiplier of the audio signal. The default value is 1.0.</param>
    [Overload("AddOutgoingConnectionWithGain")]
    [MethodImpl]
    public extern void AddOutgoingConnection(IAudioNode destination, double gain);

    /// <summary>Removes the outgoing connection from the audio submix node to the specified node.</summary>
    /// <param name="destination">The audio node for which the outgoing connection is removed.</param>
    [MethodImpl]
    public extern void RemoveOutgoingConnection(IAudioNode destination);

    /// <summary>Gets the list of effect definitions for the audio submix node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets the outgoing gain for the audio submix node.</summary>
    /// <returns>The outgoing gain value.</returns>
    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the encoding properties for the audio device submix node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the audio submix node consumes input.</summary>
    /// <returns>True if the audio submix node consumes input, and false otherwise.</returns>
    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the audio submix node.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the audio submix node.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Resets the audio submix node.</summary>
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

    /// <summary>Gets the AudioNodeEmitter that describes the position and other physical characteristics of the emitter from which the AudioSubmixNode output audio is emitted when spatial audio processing is used.</summary>
    /// <returns>The spatial audio emitter associated with the AudioSubmixNode.</returns>
    public extern AudioNodeEmitter Emitter { [MethodImpl] get; }
  }
}
