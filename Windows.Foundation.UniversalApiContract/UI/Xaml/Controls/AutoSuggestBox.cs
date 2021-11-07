// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.AutoSuggestBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a text control that makes suggestions to users as they enter text using a keyboard or pen (using ink and handwriting recognition). The app is notified when text has been changed by the user and is responsible for providing relevant suggestions for this control to display.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAutoSuggestBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutoSuggestBoxStatics4), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutoSuggestBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAutoSuggestBoxStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class AutoSuggestBox : 
    ItemsControl,
    IAutoSuggestBox,
    IAutoSuggestBox2,
    IAutoSuggestBox3,
    IAutoSuggestBox4
  {
    /// <summary>Initializes a new instance of the AutoSuggestBox class.</summary>
    [MethodImpl]
    public extern AutoSuggestBox();

    /// <summary>Gets or set the maximum height for the drop-down portion of the AutoSuggestBox control.</summary>
    /// <returns>The maximum height for the drop-down portion of the AutoSuggestBox control.</returns>
    public extern double MaxSuggestionListHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating whether the drop-down portion of the AutoSuggestBox is open.</summary>
    /// <returns>A Boolean value indicating whether the drop-down portion of the AutoSuggestBox is open.</returns>
    public extern bool IsSuggestionListOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the property path that is used to get the value for display in the text box portion of the AutoSuggestBox control, when an item is selected.</summary>
    /// <returns>The property path that is used to get the value for display in the text box portion of the AutoSuggestBox control, when an item is selected.</returns>
    public extern string TextMemberPath { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text that is shown in the control.</summary>
    /// <returns>The text that is shown in the control.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Used in conjunction with TextMemberPath, gets or sets a value indicating whether items in the view will trigger an update of the editable text part of the AutoSuggestBox when clicked.</summary>
    /// <returns>A value indicating whether items in the view will trigger an update of the editable text part of the AutoSuggestBox when clicked.</returns>
    public extern bool UpdateTextOnSelect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the placeholder text to be displayed in the control.</summary>
    /// <returns>The placeholder text to be displayed in the control. The default is an empty string.</returns>
    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the header object for the text box portion of this control.</summary>
    /// <returns>The header object for the text box portion of this control.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates if the suggestion area should be automatically maximized.</summary>
    /// <returns>A Boolean value that indicates if the suggestion area should be automatically maximized.</returns>
    public extern bool AutoMaximizeSuggestionArea { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style of the auto-suggest text box.</summary>
    /// <returns>The style of the auto-suggest text box.</returns>
    public extern Style TextBoxStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Raised before the text content of the editable control component is updated.</summary>
    public extern event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxSuggestionChosenEventArgs> SuggestionChosen;

    /// <summary>Raised after the text content of the editable control component is updated.</summary>
    public extern event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxTextChangedEventArgs> TextChanged;

    /// <summary>Gets or sets the graphic content of the button that is clicked to initiate a query.</summary>
    /// <returns>The graphic content of the button that is clicked to initiate a query, if present; otherwise, **null**. The default is **null**.</returns>
    public extern IconElement QueryIcon { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user submits a search query.</summary>
    public extern event TypedEventHandler<AutoSuggestBox, AutoSuggestBoxQuerySubmittedEventArgs> QuerySubmitted;

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.</summary>
    /// <returns>The content to be displayed below the control. The default is **null**.</returns>
    public extern object Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the QueryIcon dependency property.</summary>
    /// <returns>The identifier for the QueryIcon dependency property.</returns>
    public static extern DependencyProperty QueryIconProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxSuggestionListHeight dependency property.</summary>
    /// <returns>Identifier for the MaxSuggestionListHeight dependency property.</returns>
    public static extern DependencyProperty MaxSuggestionListHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSuggestionListOpen dependency property.</summary>
    /// <returns>Identifier for the IsSuggestionListOpen dependency property.</returns>
    public static extern DependencyProperty IsSuggestionListOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextMemberPath dependency property.</summary>
    /// <returns>Identifier for the TextMemberPath dependency property.</returns>
    public static extern DependencyProperty TextMemberPathProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    /// <summary>Identifies the UpdateTextOnSelect dependency property.</summary>
    /// <returns>Identifier for the UpdateTextOnSelect dependency property.</returns>
    public static extern DependencyProperty UpdateTextOnSelectProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutoMaximizeSuggestionArea dependency property.</summary>
    /// <returns>The identifier for the AutoMaximizeSuggestionArea dependency property.</returns>
    public static extern DependencyProperty AutoMaximizeSuggestionAreaProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextBoxStyle dependency property.</summary>
    /// <returns>Identifier for the TextBoxStyle dependency property.</returns>
    public static extern DependencyProperty TextBoxStyleProperty { [MethodImpl] get; }
  }
}
