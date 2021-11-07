// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFileOutputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.Storage;

namespace Windows.Media.Audio
{
  /// <summary>Represents a node in an audio graph node that outputs audio data from the graph to an audio file.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AudioFileOutputNode : IAudioFileOutputNode, IAudioNode, IClosable
  {
    /// <summary>Gets the file associated with the audio file output node.</summary>
    /// <returns>A StorageFile object representing the file.</returns>
    public extern IStorageFile File { [MethodImpl] get; }

    /// <summary>Gets the file encoding profile supported by the audio file output node.</summary>
    /// <returns>A MediaEncodingProfile object representing the encoding profile.</returns>
    public extern MediaEncodingProfile FileEncodingProfile { [MethodImpl] get; }

    /// <summary>Finalizes the asynchronous operation of the audio file output node.</summary>
    /// <returns>When this operation completes, a TranscodeFailureReason value is returned.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<TranscodeFailureReason> FinalizeAsync();

    /// <summary>Gets the list of effect definitions for the audio file output node. The effects in the list process audio data that flows through the node in the order in which they appear in the list.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    public extern IVector<IAudioEffectDefinition> EffectDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets the outgoing gain for the audio file output node.</summary>
    /// <returns>The outgoing gain value.</returns>
    public extern double OutgoingGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the encoding properties for the audio file output node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    public extern AudioEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the audio file output node consumes input.</summary>
    /// <returns>True if the audio file output node consumes input, and false otherwise.</returns>
    public extern bool ConsumeInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the audio file output node.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the audio file output node.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Resets the audio file output node.</summary>
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
