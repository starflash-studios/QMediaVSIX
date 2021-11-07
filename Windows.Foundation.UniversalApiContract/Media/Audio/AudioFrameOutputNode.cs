// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFrameOutputNode
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
  /// <summary>Represents a node in an audio graph node that outputs audio data from the graph into app-implemented code.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioFrameOutputNode : IAudioFrameOutputNode, IAudioNode, IClosable
  {
    /// <summary>Gets an audio frame containing all of the data accumulated by this node since the previous call to **GetFrame**. If **GetFrame** has not yet been called, the audio frame will contain all of the data accumulated since the node was created.</summary>
    /// <returns>An AudioFrame object representing the frame.</returns>
    [MethodImpl]
    public extern AudioFrame GetFrame();

    /// <summary>Gets the list of effect definitions for the audio frame output node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets the outgoing gain for the audio frame output node.</summary>
    /// <returns>The outgoing gain value.</returns>
    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the encoding properties for the audio frame output node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the audio frame output node consumes input.</summary>
    /// <returns>True if the audio frame output node consumes input, and false otherwise.</returns>
    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the audio frame output node.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the audio frame output node.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Resets the audio frame output node.</summary>
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
  }
}
