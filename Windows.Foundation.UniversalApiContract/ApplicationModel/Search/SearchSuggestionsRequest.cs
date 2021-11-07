// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.SearchSuggestionsRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  /// <summary>Stores suggestions and information about the request for suggestions.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SearchSuggestionsRequest : ISearchSuggestionsRequest
  {
    /// <summary>Indicates whether the request for suggestions to display is canceled.</summary>
    /// <returns>**True** if the request was canceled, otherwise **false**. The default value is **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>The suggestions to display in the search pane or in-app search box for the current query. Apps provide suggestions to display by appending them to this SearchSuggestionCollection object.</summary>
    /// <returns>The suggestions to display. Apps provide suggestions by appending them to this SearchSuggestionCollection object.</returns>
    public extern SearchSuggestionCollection SearchSuggestionCollection { [MethodImpl] get; }

    /// <summary>Gets an object that lets an app respond to a request for suggestions asynchronously.</summary>
    /// <returns>An object that lets an app signal when it has fulfilled the request for search suggestions.</returns>
    [MethodImpl]
    public extern SearchSuggestionsRequestDeferral GetDeferral();
  }
}
