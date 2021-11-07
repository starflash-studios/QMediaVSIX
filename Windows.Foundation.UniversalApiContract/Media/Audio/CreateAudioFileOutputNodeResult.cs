// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.CreateAudioFileOutputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the result of attempting to create an audio file output node.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CreateAudioFileOutputNodeResult : 
    ICreateAudioFileOutputNodeResult,
    ICreateAudioFileOutputNodeResult2
  {
    /// <summary>Gets the result status of an operation to create an AudioFileOutputNode with a call to CreateFileOutputNodeAsync.</summary>
    /// <returns>An enumeration value indicating node creation status. If the result status is **Success**, get the instance of the node with the Node property.</returns>
    public extern AudioFileNodeCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the audio file output node.</summary>
    /// <returns>An object representing the audio file output node.</returns>
    public extern AudioFileOutputNode FileOutputNode { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the creation of a AudioFileOutputNode object.</summary>
    /// <returns>The extended error code associated with the creation of a AudioFileOutputNode object.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
