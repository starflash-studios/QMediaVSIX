// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.SearchSuggestionsRequestDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  /// <summary>Enables the app to signal when it has finished populating a SearchSuggestionCollection object while handling the SuggestionsRequested event. Use a deferral if and only if your app needs to respond to a request for suggestions asynchronously.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SearchSuggestionsRequestDeferral : ISearchSuggestionsRequestDeferral
  {
    /// <summary>Signals that the app has finished populating a SearchSuggestionCollection object while handling the SuggestionsRequested event.</summary>
    [MethodImpl]
    public extern void Complete();
  }
}
