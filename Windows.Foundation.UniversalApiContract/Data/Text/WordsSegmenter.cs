// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.WordsSegmenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>A segmenter class that is able to segment provided text into words or word stems (depending on the particular language).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWordsSegmenterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class WordsSegmenter : IWordsSegmenter
  {
    /// <summary>Creates a WordsSegmenter object. See the introduction in WordsSegmenter for a description of how the language supplied to this constructor is used.</summary>
    /// <param name="language">A BCP-47 language tag.</param>
    [MethodImpl]
    public extern WordsSegmenter(string language);

    /// <summary>Gets the language of the rules used by this WordsSegmenter object.</summary>
    /// <returns>The BCP-47 language tag of the rules employed.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Determines and returns the word or word stem which contains or follows a specified index into the provided text.</summary>
    /// <param name="text">Provided text from which the word or word stem is to be returned.</param>
    /// <param name="startIndex">A zero-based index into *text*. It must be less than the length of *text*.</param>
    /// <returns>A WordSegment that represents the word or word stem.</returns>
    [MethodImpl]
    public extern WordSegment GetTokenAt(string text, uint startIndex);

    /// <summary>Determines and returns all of the words or word stems in the provided text.</summary>
    /// <param name="text">Provided text containing words or word stems to be returned.</param>
    /// <returns>A collection of WordSegment objects that represent the words or word stems.</returns>
    [MethodImpl]
    public extern IVectorView<WordSegment> GetTokens(string text);

    /// <summary>Calls the provided handler with two iterators that iterate through the words prior to and following a given index into the provided text.</summary>
    /// <param name="text">Provided text containing words to be returned.</param>
    /// <param name="startIndex">A zero-based index into *text*. It must be less than the length of *text*.</param>
    /// <param name="handler">The function that receives the iterators.</param>
    [MethodImpl]
    public extern void Tokenize(
      string text,
      uint startIndex,
      WordSegmentsTokenizingHandler handler);
  }
}
