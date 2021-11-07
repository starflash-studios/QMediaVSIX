// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISearchBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4171156570, 39354, 19412, 150, 108, 241, 31, 164, 67, 209, 60)]
  [ExclusiveTo(typeof (SearchBox))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISearchBox
  {
    bool SearchHistoryEnabled { get; set; }

    string SearchHistoryContext { get; set; }

    string PlaceholderText { get; set; }

    string QueryText { get; set; }

    bool FocusOnKeyboardInput { get; set; }

    bool ChooseSuggestionOnEnter { get; set; }

    event TypedEventHandler<SearchBox, SearchBoxQueryChangedEventArgs> QueryChanged;

    event TypedEventHandler<SearchBox, SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested;

    event TypedEventHandler<SearchBox, SearchBoxQuerySubmittedEventArgs> QuerySubmitted;

    event TypedEventHandler<SearchBox, SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen;

    event TypedEventHandler<SearchBox, RoutedEventArgs> PrepareForFocusOnKeyboardInput;

    void SetLocalContentSuggestionSettings(LocalContentSuggestionSettings settings);
  }
}
