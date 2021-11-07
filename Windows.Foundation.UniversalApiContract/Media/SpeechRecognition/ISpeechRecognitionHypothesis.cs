// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognitionHypothesis
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognitionHypothesis))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2054890928, 39365, 20349, 191, 132, 16, 170, 19, 2, 182, 52)]
  internal interface ISpeechRecognitionHypothesis
  {
    string Text { get; }
  }
}
