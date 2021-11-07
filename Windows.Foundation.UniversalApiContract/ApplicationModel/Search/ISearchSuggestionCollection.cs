// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchSuggestionCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Search
{
  [Guid(842697291, 64490, 17478, 171, 188, 61, 167, 145, 95, 221, 58)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SearchSuggestionCollection))]
  internal interface ISearchSuggestionCollection
  {
    uint Size { get; }

    void AppendQuerySuggestion(string text);

    void AppendQuerySuggestions(IIterable<string> suggestions);

    void AppendResultSuggestion(
      string text,
      string detailText,
      string tag,
      IRandomAccessStreamReference image,
      string imageAlternateText);

    void AppendSearchSeparator(string label);
  }
}
