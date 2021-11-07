// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.CreateAudioFileInputNodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the result of attempting to create an audio file input node.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class CreateAudioFileInputNodeResult : 
    ICreateAudioFileInputNodeResult,
    ICreateAudioFileInputNodeResult2
  {
    /// <summary>Gets the result status of an operation to create an AudioFileInputNode with a call to CreateFileInputNodeAsync.</summary>
    /// <returns>An enumeration value indicating file node creation status. If the result status is **Success**, get the instance of the node with the Node property.</returns>
    public extern AudioFileNodeCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the audio file input node.</summary>
    /// <returns>An object representing the audio file input node.</returns>
    public extern AudioFileInputNode FileInputNode { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the creation of a AudioFileInputNode object.</summary>
    /// <returns>The extended error code associated with the creation of a AudioFileInputNode object.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
