// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.SpeechContinuousRecognitionResultGeneratedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  /// <summary>Contains event data for the SpeechContinuousRecognitionSession.ResultGenerated event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechContinuousRecognitionResultGeneratedEventArgs : 
    ISpeechContinuousRecognitionResultGeneratedEventArgs
  {
    /// <summary>Gets the complete recognition result returned by the speech recognizer at the end of a continuous recognition session where SpeechRecognitionResultStatus is set to Success.</summary>
    /// <returns>The complete recognition result returned by the speech recognizer at the end of a dictation session.</returns>
    public extern SpeechRecognitionResult Result { [MethodImpl] get; }
  }
}
