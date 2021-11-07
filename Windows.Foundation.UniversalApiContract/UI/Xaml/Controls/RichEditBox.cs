// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichEditBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a rich text editing control that supports formatted text, hyperlinks, and other rich content.</summary>
  [Static(typeof (IRichEditBoxStatics4), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IRichEditBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics7), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics8), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics6), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichEditBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class RichEditBox : 
    Control,
    IRichEditBox,
    IRichEditBox2,
    IRichEditBox3,
    IRichEditBox4,
    IRichEditBox5,
    IRichEditBox6,
    IRichEditBox7,
    IRichEditBox8
  {
    /// <summary>Initializes a new instance of the RichEditBox class.</summary>
    [MethodImpl]
    public extern RichEditBox();

    /// <summary>Gets or sets a value that indicates whether the user can change the text in the RichEditBox.</summary>
    /// <returns>**True** if the RichEditBox is read-only; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the RichEditBox allows and displays the newline or return characters when the ENTER or RETURN keys are pressed.</summary>
    /// <returns>**True** if the RichEditBox allows newline characters; otherwise, **false**. The default is **true**.</returns>
    public extern bool AcceptsReturn { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how text is aligned in the RichEditBox.</summary>
    /// <returns>One of the TextAlignment enumeration values that specifies how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how text wrapping occurs if a line of text extends beyond the available width of the RichEditBox.</summary>
    /// <returns>One of the TextWrapping enumeration values that specifies whether text is wrapped. The default is **Wrap**.</returns>
    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the text input should interact with a spell check engine.</summary>
    /// <returns>**True** if the text input should interact with a spell check engine; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsSpellCheckEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether text prediction features ("autocomplete") are enabled for this RichEditBox.</summary>
    /// <returns>**True** to enable text prediction features; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTextPredictionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that enables access to the text object model for the text contained in a RichEditBox.</summary>
    /// <returns>An object that enables access to the text object model.</returns>
    public extern ITextDocument Document { [MethodImpl] get; }

    /// <summary>Gets or sets the context for input used by this RichEditBox.</summary>
    /// <returns>The input scope, which provides a hint at the type of text input expected by the control.</returns>
    public extern InputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when content changes in the RichEditBox.</summary>
    public extern event RoutedEventHandler TextChanged;

    /// <summary>Occurs when the text selection has changed.</summary>
    public extern event RoutedEventHandler SelectionChanged;

    /// <summary>Occurs when the system processes an interaction that displays a context menu.</summary>
    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    /// <summary>Gets or sets the content for the control's header.</summary>
    /// <returns>The content of the control's header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the control's header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</summary>
    /// <returns>The text that is displayed in the control when no value is entered. The default is an empty string ("").</returns>
    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to highlight the selected text.</summary>
    /// <returns>The brush used to highlight the selected text. The default is a null brush from a pure code perspective, but the default control template for RichEditBox applies a theme resource brush for this in a runtime instance of a RichEditBox control.</returns>
    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the on-screen keyboard is shown when the control receives focus programmatically.</summary>
    /// <returns>**true** if the on-screen keyboard is not shown when the control receives focus programmatically; otherwise, **false**. The default is **false**.</returns>
    public extern bool PreventKeyboardDisplayOnProgrammaticFocus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether font glyphs that contain color layers, such as Segoe UI Emoji, are rendered in color.</summary>
    /// <returns>**true** if color glyphs show in color; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when text is pasted into the control.</summary>
    public extern event TextControlPasteEventHandler Paste;

    /// <summary>Occurs when a user starts composing text through an Input Method Editor (IME).</summary>
    public extern event TypedEventHandler<RichEditBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    /// <summary>Occurs when text being composed through an Input Method Editor (IME) changes.</summary>
    public extern event TypedEventHandler<RichEditBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    /// <summary>Occurs when a user stops composing text through an Input Method Editor (IME).</summary>
    public extern event TypedEventHandler<RichEditBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    /// <summary>Gets or sets a value that indicates how the reading order is determined for the RichEditBox.</summary>
    /// <returns>A value that indicates how the reading order is determined for the RichEditBox. The default is **DetectFromContent**.</returns>
    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the preferred alignment of the Input Method Editor (IME).</summary>
    /// <returns>A value of the enumeration that indicates the preferred alignment of the Input Method Editor (IME). The default is **Default**.</returns>
    public extern CandidateWindowAlignment DesiredCandidateWindowAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Input Method Editor (IME) window open, updates, or closes.</summary>
    public extern event TypedEventHandler<RichEditBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    /// <summary>Occurs synchronously when the text in the edit box starts to change, but before it is rendered.</summary>
    public extern event TypedEventHandler<RichEditBox, RichEditBoxTextChangingEventArgs> TextChanging;

    /// <summary>Asynchronously gets a list of candidate words based on the provided phonetic characters in an Input Method Editor (IME).</summary>
    /// <returns>A list of candidate words based on the provided phonetic characters in an Input Method Editor (IME).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();

    /// <summary>Gets or sets a value that specifies whether text is copied with all formats, or as plain text only.</summary>
    /// <returns>An enumeration value that specifies whether text is copied with all formats, or as plain text only. The default is **AllFormats**.</returns>
    public extern RichEditClipboardFormat ClipboardCopyFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to highlight the selected text when the RichEditBox does not have focus.</summary>
    /// <returns>The brush used to highlight the selected text when RichEditBox loses focus. The default is a null brush from a pure code perspective, but the default control template for RichEditBox applies a Transparent brush for this in a runtime instance of a RichEditBox control. To disable the SelectionHighlightColorWhenNotFocused, set the brush to Transparent once again.</returns>
    public extern SolidColorBrush SelectionHighlightColorWhenNotFocused { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that specifies the maximum number of characters allowed for user input.</summary>
    /// <returns>The maximum number of characters allowed for user input. The default is 0 (no limit).</returns>
    public extern int MaxLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how text is aligned in the RichEditBox.</summary>
    /// <returns>One of the TextAlignment enumeration values that specifies how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment HorizontalTextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the control modifies the case of characters as they are typed.</summary>
    /// <returns>A value of the enumeration that indicates how the control modifies the case of characters as they are typed. The default is **Normal**, which indicates that the charcters are not changed.</returns>
    public extern CharacterCasing CharacterCasing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates which keyboard shortcuts for formatting are disabled.</summary>
    /// <returns>A value that indicates which keyboard shortcuts for formatting are disabled. The default is **None**.</returns>
    public extern DisabledFormattingAccelerators DisabledFormattingAccelerators { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs before copied text is moved to the clipboard.</summary>
    public extern event TypedEventHandler<RichEditBox, TextControlCopyingToClipboardEventArgs> CopyingToClipboard;

    /// <summary>Occurs before cut text is moved to the clipboard.</summary>
    public extern event TypedEventHandler<RichEditBox, TextControlCuttingToClipboardEventArgs> CuttingToClipboard;

    /// <summary>Get or sets the brush used to color the link text.</summary>
    /// <returns>The brush used to color the link text.</returns>
    public extern SolidColorBrush ContentLinkForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets the brush used to color the link background.</summary>
    /// <returns>The brush used to color the link background.</returns>
    public extern SolidColorBrush ContentLinkBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets the collection of ContentLinkProvider s that define the types of ContentLink s used in this RichEditBox.</summary>
    /// <returns>The collection of ContentLinkProvider s that define the types of ContentLink s used in this RichEditBox.</returns>
    public extern ContentLinkProviderCollection ContentLinkProviders { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HandwritingView associated with this text control.</summary>
    /// <returns>The HandwritingView associated with this text control.</returns>
    public extern HandwritingView HandwritingView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can enter text in the handwriting view.</summary>
    /// <returns>**true** to allow the user to enter text in the handwriting view; otherwise, **false**.</returns>
    public extern bool IsHandwritingViewEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a content link is added, removed, or edited.</summary>
    public extern event TypedEventHandler<RichEditBox, ContentLinkChangedEventArgs> ContentLinkChanged;

    /// <summary>Occurs when the link is activated by user interaction.</summary>
    public extern event TypedEventHandler<RichEditBox, ContentLinkInvokedEventArgs> ContentLinkInvoked;

    /// <summary>Gets an object that enables access to the text object model for the text contained in a RichEditBox.</summary>
    /// <returns>An object that enables access to the text object model.</returns>
    public extern RichEditTextDocument TextDocument { [MethodImpl] get; }

    /// <summary>Gets or sets the flyout that is shown when text is selected using mouse, touch, or pen; or **null** if no flyout is shown.</summary>
    /// <returns>The flyout that is shown when text is selected using mouse, touch, or pen; or **null** if no flyout is shown. The default is an instance of TextCommandBarFlyout.</returns>
    public extern FlyoutBase SelectionFlyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the flyout that shows proofing commands.</summary>
    /// <returns>The flyout that shows proofing commands.</returns>
    public extern FlyoutBase ProofingMenuFlyout { [MethodImpl] get; }

    /// <summary>Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.</summary>
    /// <returns>The content to be displayed below the control. The default is **null**.</returns>
    public extern object Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the text selection starts to change.</summary>
    public extern event TypedEventHandler<RichEditBox, RichEditBoxSelectionChangingEventArgs> SelectionChanging;

    /// <summary>Identifies the SelectionFlyout dependency property.</summary>
    /// <returns>The identifier for the SelectionFlyout dependency property.</returns>
    public static extern DependencyProperty SelectionFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the ProofingMenuFlyout dependency property.</summary>
    /// <returns>The identifier for the ProofingMenuFlyout dependency property.</returns>
    public static extern DependencyProperty ProofingMenuFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentLinkForegroundColor dependency property.</summary>
    /// <returns>The identifier for the ContentLinkForegroundColor dependency property.</returns>
    public static extern DependencyProperty ContentLinkForegroundColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentLinkBackgroundColor dependency property.</summary>
    /// <returns>The identifier for the ContentLinkBackgroundColor dependency property.</returns>
    public static extern DependencyProperty ContentLinkBackgroundColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentLinkProviders dependency property.</summary>
    /// <returns>The identifier for the ContentLinkProviders dependency property.</returns>
    public static extern DependencyProperty ContentLinkProvidersProperty { [MethodImpl] get; }

    /// <summary>Identifies the HandwritingView dependency property.</summary>
    /// <returns>The identifier for the HandwritingView dependency property.</returns>
    public static extern DependencyProperty HandwritingViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHandwritingViewEnabled dependency property.</summary>
    /// <returns>The identifier for the IsHandwritingViewEnabled dependency property.</returns>
    public static extern DependencyProperty IsHandwritingViewEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalTextAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalTextAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalTextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the CharacterCasing dependency property.</summary>
    /// <returns>The identifier for the CharacterCasing dependency property.</returns>
    public static extern DependencyProperty CharacterCasingProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisabledFormattingAccelerators dependency property.</summary>
    /// <returns>The identifier for the DisabledFormattingAccelerators dependency property.</returns>
    public static extern DependencyProperty DisabledFormattingAcceleratorsProperty { [MethodImpl] get; }

    /// <summary>Identifies the **SelectionHighlightColorWhenNotFocused** dependency property.</summary>
    /// <returns>The identifier for the **SelectionHighlightColorWhenNotFocused** dependency property.</returns>
    public static extern DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { [MethodImpl] get; }

    /// <summary>Identifies the **MaxLength** dependency property.</summary>
    /// <returns>The identifier for the **MaxLength** dependency property.</returns>
    public static extern DependencyProperty MaxLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ClipboardCopyFormat dependency property.</summary>
    /// <returns>The identifier for the ClipboardCopyFormat dependency property.</returns>
    public static extern DependencyProperty ClipboardCopyFormatProperty { [MethodImpl] get; }

    /// <summary>Identifies the DesiredCandidateWindowAlignment dependency property.</summary>
    /// <returns>The identifier for the DesiredCandidateWindowAlignment dependency property.</returns>
    public static extern DependencyProperty DesiredCandidateWindowAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextReadingOrder dependency property.</summary>
    /// <returns>The identifier for the TextReadingOrder dependency property.</returns>
    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionHighlightColor dependency property.</summary>
    /// <returns>The identifier for the SelectionHighlightColor dependency property.</returns>
    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the PreventKeyboardDisplayOnProgrammaticFocus dependency property.</summary>
    /// <returns>The identifier for the PreventKeyboardDisplayOnProgrammaticFocus dependency property.</returns>
    public static extern DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsColorFontEnabled dependency property.</summary>
    /// <returns>The identifier for the IsColorFontEnabled dependency property.</returns>
    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsReadOnly dependency property.</summary>
    /// <returns>The identifier for the IsReadOnly dependency property.</returns>
    public static extern DependencyProperty IsReadOnlyProperty { [MethodImpl] get; }

    /// <summary>Identifies the AcceptsReturn dependency property.</summary>
    /// <returns>The identifier for the AcceptsReturn dependency property.</returns>
    public static extern DependencyProperty AcceptsReturnProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextAlignment dependency property.</summary>
    /// <returns>Identifier for the TextAlignment dependency property.</returns>
    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextWrapping dependency property.</summary>
    /// <returns>The identifier for the TextWrapping dependency property.</returns>
    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSpellCheckEnabled dependency property.</summary>
    /// <returns>The identifier for the IsSpellCheckEnabled dependency property.</returns>
    public static extern DependencyProperty IsSpellCheckEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextPredictionEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTextPredictionEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextPredictionEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the InputScope dependency property.</summary>
    /// <returns>The identifier for the InputScope dependency property.</returns>
    public static extern DependencyProperty InputScopeProperty { [MethodImpl] get; }
  }
}
