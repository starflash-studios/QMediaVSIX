// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.WordSegmentsTokenizingHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Defines the signature of a function that is provided to WordsSegmenter.Tokenize.</summary>
  /// <param name="precedingWords">Contains the selectable words, in reverse order, that precede the parameter *startIndex* that is provided to WordsSegmenter.Tokenize.</param>
  /// <param name="words">Contains the selectable words that contain or follow the parameter *startIndex* that is provided to WordsSegmenter.Tokenize.</param>
  [Guid(2782749527, 48938, 19535, 163, 31, 41, 231, 28, 111, 139, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void WordSegmentsTokenizingHandler(
    IIterable<WordSegment> precedingWords,
    IIterable<WordSegment> words);
}
