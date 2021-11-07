// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerUIOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SpeechRecognizerUIOptions))]
  [Guid(2022233665, 47403, 17594, 162, 95, 209, 134, 70, 48, 100, 31)]
  internal interface ISpeechRecognizerUIOptions
  {
    string ExampleText { get; set; }

    string AudiblePrompt { get; set; }

    bool IsReadBackEnabled { get; set; }

    bool ShowConfirmation { get; set; }
  }
}
