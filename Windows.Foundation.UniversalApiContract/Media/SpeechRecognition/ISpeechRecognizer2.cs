// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(1674164977, 37347, 20132, 134, 161, 124, 56, 103, 208, 132, 166)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognizer2
  {
    SpeechContinuousRecognitionSession ContinuousRecognitionSession { get; }

    SpeechRecognizerState State { get; }

    [RemoteAsync]
    IAsyncAction StopRecognitionAsync();

    event TypedEventHandler<SpeechRecognizer, SpeechRecognitionHypothesisGeneratedEventArgs> HypothesisGenerated;
  }
}
