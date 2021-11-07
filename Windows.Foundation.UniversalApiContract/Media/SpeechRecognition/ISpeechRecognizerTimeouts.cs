// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechRecognition.ISpeechRecognizerTimeouts
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechRecognition
{
  [Guid(787967946, 27196, 19914, 161, 83, 223, 27, 200, 138, 121, 175)]
  [ExclusiveTo(typeof (SpeechRecognizerTimeouts))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISpeechRecognizerTimeouts
  {
    TimeSpan InitialSilenceTimeout { get; set; }

    TimeSpan EndSilenceTimeout { get; set; }

    TimeSpan BabbleTimeout { get; set; }
  }
}
