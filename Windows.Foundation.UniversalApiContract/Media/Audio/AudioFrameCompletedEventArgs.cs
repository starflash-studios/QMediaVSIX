// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioFrameCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents arguments for an AudioFrameCompleted event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AudioFrameCompletedEventArgs : IAudioFrameCompletedEventArgs
  {
    /// <summary>Gets the audio frame that was just completed by the AudioFrameInputNode. A frame is completed when all of the audio in the frame has been consumed by the audio graph.</summary>
    /// <returns>An AudioFrame object representing the audio frame.</returns>
    public extern AudioFrame Frame { [MethodImpl] get; }
  }
}
