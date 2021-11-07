// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Contains continuous recognition event data for the SpeechContinuousRecognitionSession.Completed event.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SpeechContinuousRecognitionCompletedEventArgs : 
    ISpeechContinuousRecognitionCompletedEventArgs
  {
    /// <summary>Gets the status of a continuous speech recognition session (or the result of a grammar constraint compilation).</summary>
    /// <returns>The status of a continuous speech recognition session (or the result of a grammar constraint compilation).</returns>
    public extern SpeechRecognitionResultStatus Status { [MethodImpl] get; }
  }
}
