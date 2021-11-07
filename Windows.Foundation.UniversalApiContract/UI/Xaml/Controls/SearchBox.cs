// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SearchBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that can be used to enter search query text. (Not recommended for Universal Windows Platform (UWP) apps. See AutoSuggestBox.)</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (ISearchBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISearchBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class SearchBox : Control, ISearchBox
  {
    /// <summary>Initializes a new instance of the SearchBox class.</summary>
    [MethodImpl]
    public extern SearchBox();

    /// <summary>Gets or sets a value that determines whether search suggestions are made from the search history.</summary>
    /// <returns>**true** if search suggestions are made from the search history; otherwise, **false**. The default is **true**.</returns>
    public extern bool SearchHistoryEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string that identifies the context of the search and is used to store the user's search history with the app.</summary>
    /// <returns>A string that identifies the context of the search. The default is an empty string ("").</returns>
    public extern string SearchHistoryContext { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</summary>
    /// <returns>The text that is displayed in the control when no value is entered. The default is an empty string (""). The maximum placeholder text length is 128 characters.</returns>
    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text contents of the search box.</summary>
    /// <returns>A string containing the text contents of the search box. The default is an empty string (""). The maximum query text length is 2048 characters.</returns>
    public extern string QueryText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether a user can search by typing anywhere in the app.</summary>
    /// <returns>**true** if the user can search by typing anywhere in the app; otherwise, **false**. The default is **false**.</returns>
    public extern bool FocusOnKeyboardInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the suggested search query is activated when the user presses Enter.</summary>
    /// <returns>**true** if the suggested search query is activated when the user presses Enter; otherwise, **false**. The default is **false**.</returns>
    public extern bool ChooseSuggestionOnEnter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the query text changes.</summary>
    public extern event TypedEventHandler<SearchBox, SearchBoxQueryChangedEventArgs> QueryChanged;

    /// <summary>Occurs when the user's query text changes and the app needs to provide new suggestions to display in the search pane.</summary>
    public extern event TypedEventHandler<SearchBox, SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested;

    /// <summary>Occurs when the user submits a search query.</summary>
    public extern event TypedEventHandler<SearchBox, SearchBoxQuerySubmittedEventArgs> QuerySubmitted;

    /// <summary>Occurs when the user picks a suggested search result.</summary>
    public extern event TypedEventHandler<SearchBox, SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen;

    /// <summary>Occurs when the FocusOnKeyboardInput property is **true** and the app receives textual keyboard input.</summary>
    public extern event TypedEventHandler<SearchBox, RoutedEventArgs> PrepareForFocusOnKeyboardInput;

    /// <summary>Specifies whether suggestions based on local files are automatically displayed in the search box suggestions, and defines the criteria that Windows uses to locate and filter these suggestions.</summary>
    /// <param name="settings">The new settings for local content suggestions.</param>
    [MethodImpl]
    public extern void SetLocalContentSuggestionSettings(LocalContentSuggestionSettings settings);

    /// <summary>Identifies the SearchHistoryEnabled dependency property.</summary>
    /// <returns>The identifier for the SearchHistoryEnabled dependency property.</returns>
    public static extern DependencyProperty SearchHistoryEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the SearchHistoryContext dependency property.</summary>
    /// <returns>The identifier for the SearchHistoryContext dependency property.</returns>
    public static extern DependencyProperty SearchHistoryContextProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the QueryText dependency property.</summary>
    /// <returns>The identifier for the QueryText dependency property.</returns>
    public static extern DependencyProperty QueryTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusOnKeyboardInput dependency property.</summary>
    /// <returns>The identifier for the FocusOnKeyboardInput dependency property.</returns>
    public static extern DependencyProperty FocusOnKeyboardInputProperty { [MethodImpl] get; }

    /// <summary>Identifies the ChooseSuggestionOnEnter dependency property.</summary>
    /// <returns>The identifier for the ChooseSuggestionOnEnter dependency property.</returns>
    public static extern DependencyProperty ChooseSuggestionOnEnterProperty { [MethodImpl] get; }
  }
}
