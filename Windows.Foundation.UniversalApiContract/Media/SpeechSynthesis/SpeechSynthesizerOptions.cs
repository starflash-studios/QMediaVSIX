// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  /// <summary>Provides access to various speech synthesizer options.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772160)]
  public sealed class SpeechSynthesizerOptions : 
    ISpeechSynthesizerOptions,
    ISpeechSynthesizerOptions2,
    ISpeechSynthesizerOptions3
  {
    /// <summary>Gets or sets whether word boundary metadata is added to a SpeechSynthesisStream object.</summary>
    /// <returns>**true** if word boundaries are marked. Otherwise, **false**.</returns>
    public extern bool IncludeWordBoundaryMetadata { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether sentence boundary metadata is added to a SpeechSynthesisStream object.</summary>
    /// <returns>**true** if sentence boundaries are marked. Otherwise, **false**.</returns>
    public extern bool IncludeSentenceBoundaryMetadata { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the loudness of the speech synthesis utterance.</summary>
    /// <returns>The loudness of the selected speech synthesis engine (voice).</returns>
    public extern double AudioVolume { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the tempo (including pauses and hesitations) of the speech synthesis utterance.</summary>
    /// <returns>The tempo, relative to the default rate of the selected speech synthesis engine (voice).</returns>
    public extern double SpeakingRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the tone (relative highness or lowness) of the speech synthesis utterance.</summary>
    /// <returns>The tone of the selected speech synthesis engine (voice).</returns>
    public extern double AudioPitch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount of silence added to the end of the speech synthesis utterance (before another utterance begins).</summary>
    /// <returns>The SpeechAppendedSilence duration.</returns>
    public extern SpeechAppendedSilence AppendedSilence { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount of silence added after punctuation in the speech synthesis utterance (before another utterance begins).</summary>
    /// <returns>The SpeechPunctuationSilence duration.</returns>
    public extern SpeechPunctuationSilence PunctuationSilence { [MethodImpl] get; [MethodImpl] set; }
  }
}
