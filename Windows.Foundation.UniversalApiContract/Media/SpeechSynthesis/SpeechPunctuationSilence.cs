// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.SpeechPunctuationSilence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  /// <summary>Specifies the amount of silence added after punctuation in the speech synthesis utterance (before another utterance begins).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum SpeechPunctuationSilence
  {
    /// <summary>The default amount of silence defined by the speech synthesis voice.</summary>
    Default,
    /// <summary>The minimum amount of silence defined by the speech synthesis voice.</summary>
    Min,
  }
}
