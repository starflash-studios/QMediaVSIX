// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [Guid(197380555, 49770, 16626, 174, 181, 128, 150, 178, 228, 128, 115)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  internal interface ISpeechRecognizer : IClosable
  {
    Language CurrentLanguage { get; }

    IVector<ISpeechRecognitionConstraint> Constraints { get; }

    SpeechRecognizerTimeouts Timeouts { get; }

    SpeechRecognizerUIOptions UIOptions { get; }

    [RemoteAsync]
    IAsyncOperation<SpeechRecognitionCompilationResult> CompileConstraintsAsync();

    [RemoteAsync]
    IAsyncOperation<SpeechRecognitionResult> RecognizeAsync();

    [RemoteAsync]
    IAsyncOperation<SpeechRecognitionResult> RecognizeWithUIAsync();

    event TypedEventHandler<SpeechRecognizer, SpeechRecognitionQualityDegradingEventArgs> RecognitionQualityDegrading;

    event TypedEventHandler<SpeechRecognizer, SpeechRecognizerStateChangedEventArgs> StateChanged;
  }
}
