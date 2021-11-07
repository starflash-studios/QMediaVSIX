// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.CreateMediaSourceAudioInputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the result of attempting to create a MediaSourceAudioInputNode.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class CreateMediaSourceAudioInputNodeResult : 
    ICreateMediaSourceAudioInputNodeResult,
    ICreateMediaSourceAudioInputNodeResult2
  {
    /// <summary>Gets the result status of an operation to create a MediaSourceAudioInputNode with a call to AudioGraph.CreateMediaSourceAudioInputNodeAsync.</summary>
    /// <returns>An enumeration value indicating audio graph creation status.</returns>
    public extern MediaSourceAudioInputNodeCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the **MediaSource** audio input node.</summary>
    /// <returns>The **MediaSource** audio input node.</returns>
    public extern MediaSourceAudioInputNode Node { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the creation of a MediaSourceAudioInputNode object.</summary>
    /// <returns>The extended error code associated with the creation of a MediaSourceAudioInputNode object.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
