// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechRecognitionQualityDegradingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Provides data for the SpeechRecognitionQualityDegradingEvent event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechRecognitionQualityDegradingEventArgs : 
    ISpeechRecognitionQualityDegradingEventArgs
  {
    /// <summary>Gets the audio problem that occurred.</summary>
    /// <returns>The audio problem that occurred.</returns>
    public extern SpeechRecognitionAudioProblem Problem { [MethodImpl] get; }
  }
}
