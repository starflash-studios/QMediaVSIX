// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.SearchSuggestionCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Search
{
  /// <summary>Represents a collection of search suggestions to be displayed in the search pane in response to a suggestionsrequested event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  public sealed class SearchSuggestionCollection : ISearchSuggestionCollection
  {
    /// <summary>The number of suggestions in the collection.</summary>
    /// <returns>The number of suggestions.</returns>
    public extern uint Size { [MethodImpl] get; }

    /// <summary>Appends a query suggestion to the list of search suggestions for the search pane.</summary>
    /// <param name="text">The text of the query suggestion.</param>
    [MethodImpl]
    public extern void AppendQuerySuggestion(string text);

    [MethodImpl]
    public extern void AppendQuerySuggestions(IIterable<string> suggestions);

    /// <summary>Appends a suggested search result to the list of suggestions to display in the search pane.</summary>
    /// <param name="text">The text of the suggested result.</param>
    /// <param name="detailText">The detail text for the suggested result.</param>
    /// <param name="tag">The unique tag that identifies this suggested result.</param>
    /// <param name="image">The image to accompany the results suggestion. The image should be 40 x 40. Windows will scale or crop smaller or larger images.</param>
    /// <param name="imageAlternateText">The alternate text for the image.</param>
    [MethodImpl]
    public extern void AppendResultSuggestion(
      string text,
      string detailText,
      string tag,
      IRandomAccessStreamReference image,
      string imageAlternateText);

    /// <summary>Appends a text label that is used to separate groups of suggestions in the search pane.</summary>
    /// <param name="label">The text to use as a separator. This text should be descriptive of any suggestions that are appended after it.</param>
    [MethodImpl]
    public extern void AppendSearchSeparator(string label);
  }
}
