// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Provides data for the AudioFrameInputNode.QuantumStarted event. This event is raised when the audio graph containing the audio frame input node is ready to begin processing a new quantum of data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class FrameInputNodeQuantumStartedEventArgs : IFrameInputNodeQuantumStartedEventArgs
  {
    /// <summary>Gets the number of samples that the audio graph requires to fill the quantum with data.</summary>
    /// <returns>The number of samples that the audio graph requires to fill the quantum with data.</returns>
    public extern int RequiredSamples { [MethodImpl] get; }
  }
}
