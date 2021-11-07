// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchSuggestionsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [ExclusiveTo(typeof (SearchSuggestionsRequest))]
  [Guid(1313744551, 17637, 16441, 144, 153, 96, 0, 234, 209, 240, 198)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchSuggestionsRequest
  {
    bool IsCanceled { get; }

    SearchSuggestionCollection SearchSuggestionCollection { get; }

    SearchSuggestionsRequestDeferral GetDeferral();
  }
}
