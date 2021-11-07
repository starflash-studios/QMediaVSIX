// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextPhoneme
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Represents the result of calling the TextReverseConversionGenerator.GetPhonemesAsync method, encapsulating both the original display text and the phonemes that match the original display text.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class TextPhoneme : ITextPhoneme
  {
    /// <summary>Gets the display text for a Japanese phoneme.</summary>
    /// <returns>The display text as originally passed to TextReverseConversionGenerator.GetPhonemesAsync. In the typical use case of passing a Japanese sentence to that method, the display text is one phonetic part of the sentence in Kanji or a mix of Kanji and phonetic characters.</returns>
    public extern string DisplayText { [MethodImpl] get; }

    /// <summary>Gets the phonetic reading of the DisplayText, with Japanese characters in Hiragana.</summary>
    /// <returns>The reading of the DisplayText, with Japanese characters in Hiragana.</returns>
    public extern string ReadingText { [MethodImpl] get; }
  }
}
