// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.CreateAudioGraphResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the result of attempting to create an audio graph.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CreateAudioGraphResult : ICreateAudioGraphResult, ICreateAudioGraphResult2
  {
    /// <summary>Gets the result status of an operation to create an AudioGraph with a call to AudioGraph.CreateAsync.</summary>
    /// <returns>An enumeration value indicating audio graph creation status.</returns>
    public extern AudioGraphCreationStatus Status { [MethodImpl] get; }

    /// <summary>Gets the audio graph object.</summary>
    /// <returns>An object indicating the audio graph.</returns>
    public extern AudioGraph Graph { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the creation of a AudioGraph object.</summary>
    /// <returns>The extended error code associated with the creation of a AudioGraph object.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
