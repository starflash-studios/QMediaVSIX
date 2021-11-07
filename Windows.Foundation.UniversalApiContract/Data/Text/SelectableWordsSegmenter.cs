// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.SelectableWordsSegmenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>A segmenter class that is able to segment provided text into units appropriate for selecting text by words.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISelectableWordsSegmenterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SelectableWordsSegmenter : ISelectableWordsSegmenter
  {
    /// <summary>Creates a SelectableWordsSegmenter object. See the introduction in SelectableWordsSegmenter for a description of how the language supplied to this constructor is used.</summary>
    /// <param name="language">A BCP-47 language tag.</param>
    [MethodImpl]
    public extern SelectableWordsSegmenter(string language);

    /// <summary>Gets the language of the rules used by this SelectableWordsSegmenter object.</summary>
    /// <returns>The BCP-47 language tag of the rules employed.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Determines and returns the selectable word or word stem which contains or follows a specified index into the provided text.</summary>
    /// <param name="text">Provided text in which a word or word stem is to be selected.</param>
    /// <param name="startIndex">A zero-based index into *text*. It must be less than the length of *text*.</param>
    /// <returns>A SelectableWordSegment that represents the selected word or word stem.</returns>
    [MethodImpl]
    public extern SelectableWordSegment GetTokenAt(
      string text,
      uint startIndex);

    /// <summary>Determines and returns all of the selectable words or word stems in the provided text.</summary>
    /// <param name="text">Provided text containing words or word stems to be selected.</param>
    /// <returns>A collection of SelectableWordSegment objects that represent the selectable words or word stems.</returns>
    [MethodImpl]
    public extern IVectorView<SelectableWordSegment> GetTokens(
      string text);

    /// <summary>Calls the provided handler with two iterators that iterate through the selectable words prior to and following a given index into the provided text.</summary>
    /// <param name="text">Provided text containing words to be selected.</param>
    /// <param name="startIndex">A zero-based index into *text*. It must be less than the length of *text*.</param>
    /// <param name="handler">The function that receives the iterators.</param>
    [MethodImpl]
    public extern void Tokenize(
      string text,
      uint startIndex,
      SelectableWordSegmentsTokenizingHandler handler);
  }
}
