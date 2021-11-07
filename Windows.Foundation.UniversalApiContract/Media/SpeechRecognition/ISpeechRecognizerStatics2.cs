// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SpeechRecognizer))]
  [Guid(488312213, 30053, 20217, 162, 243, 186, 21, 22, 42, 150, 207)]
  internal interface ISpeechRecognizerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<bool> TrySetSystemSpeechLanguageAsync(Language speechLanguage);
  }
}
