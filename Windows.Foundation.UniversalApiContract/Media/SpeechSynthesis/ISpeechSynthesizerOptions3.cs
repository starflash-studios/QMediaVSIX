// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.ISpeechSynthesizerOptions3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [Guid(1075763319, 36908, 18452, 165, 130, 165, 208, 192, 118, 159, 168)]
  [ExclusiveTo(typeof (SpeechSynthesizerOptions))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ISpeechSynthesizerOptions3
  {
    SpeechAppendedSilence AppendedSilence { get; set; }

    SpeechPunctuationSilence PunctuationSilence { get; set; }
  }
}
