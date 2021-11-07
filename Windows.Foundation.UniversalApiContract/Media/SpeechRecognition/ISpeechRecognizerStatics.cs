// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2275630764, 42972, 19211, 188, 201, 36, 244, 124, 11, 126, 191)]
  internal interface ISpeechRecognizerStatics
  {
    Language SystemSpeechLanguage { get; }

    IVectorView<Language> SupportedTopicLanguages { get; }

    IVectorView<Language> SupportedGrammarLanguages { get; }
  }
}
