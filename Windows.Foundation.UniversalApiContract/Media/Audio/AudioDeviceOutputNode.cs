// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioDeviceOutputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Audio
{
  /// <summary>Represents a node in an audio graph node that outputs audio data from the graph to an audio device such as a speaker or external audio interface.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioDeviceOutputNode : 
    IAudioDeviceOutputNode,
    IAudioNode,
    IClosable,
    IAudioNodeWithListener
  {
    /// <summary>Gets information about the audio device.</summary>
    /// <returns>A DeviceInformation object representing the device.</returns>
    public extern DeviceInformation Device { [MethodImpl] get; }

    /// <summary>Gets the list of effect definitions for the audio device output node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets the outgoing gain for the audio device output node.</summary>
    /// <returns>The outgoing gain value.</returns>
    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the encoding properties for the audio device output node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the audio device output node consumes input.</summary>
    /// <returns>True if the audio device output node consumes input, and false otherwise.</returns>
    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the audio device output node.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the audio device output node.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Resets the audio device output node.</summary>
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

    /// <summary>Gets or sets the AudioNodeListener that describes the position and other characteristics of the listener from which the AudioDeviceOutputNode audio is heard when spatial audio processing is used.</summary>
    /// <returns>The spatial audio listener associated with the AudioDeviceInputNode.</returns>
    public extern AudioNodeListener Listener { [MethodImpl] set; [MethodImpl] get; }
  }
}
