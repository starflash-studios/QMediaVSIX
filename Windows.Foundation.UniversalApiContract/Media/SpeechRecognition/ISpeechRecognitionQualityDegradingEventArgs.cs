// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionQualityDegradingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1340227845, 35898, 19582, 141, 10, 91, 212, 245, 177, 74, 216)]
  [ExclusiveTo(typeof (SpeechRecognitionQualityDegradingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognitionQualityDegradingEventArgs
  {
    SpeechRecognitionAudioProblem Problem { get; }
  }
}
