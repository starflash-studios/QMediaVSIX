// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that can be used to display and edit plain text (single or multi-line).</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ITextBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITextBoxStatics6), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBoxStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBoxStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBoxStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBoxStatics8), 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (ITextBoxStatics7), 393216, "Windows.Foundation.UniversalApiContract")]
  public class TextBox : 
    Control,
    ITextBox,
    ITextBox2,
    ITextBox3,
    ITextBox4,
    ITextBox5,
    ITextBox6,
    ITextBox7,
    ITextBox8
  {
    /// <summary>Initializes a new instance of the TextBox class.</summary>
    [MethodImpl]
    public extern TextBox();

    /// <summary>Gets or sets the text contents of the text box.</summary>
    /// <returns>A string containing the text contents of the text box. The default is an empty string ("").</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content of the current selection in the text box.</summary>
    /// <returns>The currently selected text in the text box. If no text is selected, the value is String.Empty.</returns>
    public extern string SelectedText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of characters in the current selection in the text box.</summary>
    /// <returns>The number of characters in the current selection in the text box, or 0 if there is no selection.</returns>
    public extern int SelectionLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the starting position of the text selected in the text box. When the SelectionLength is 0 (there is no selected text), the SelectionStart property corresponds to the cursor position.</summary>
    /// <returns>The starting position of the current selection or the current cursor position.</returns>
    public extern int SelectionStart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that specifies the maximum number of characters allowed for user input.</summary>
    /// <returns>The maximum number of characters allowed for user input. The default is 0 (no limit).</returns>
    public extern int MaxLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that determines if the user can change the text in the text box.</summary>
    /// <returns>**true** if the text box is read-only; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that determines whether the text box allows and displays the newline or return characters.</summary>
    /// <returns>**true** if the text box allows newline characters; otherwise, **false**. The default is **false**.</returns>
    public extern bool AcceptsReturn { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how the text should be horizontally aligned in the text box.</summary>
    /// <returns>One of the TextAlignment enumeration values. The default is **Left**.</returns>
    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how line breaking occurs if a line of text extends beyond the available width of the text box.</summary>
    /// <returns>One of the TextWrapping values. The default is **NoWrap**.</returns>
    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the TextBox input interacts with a spell check engine.</summary>
    /// <returns>**true** if the TextBox input interacts with a spell check engine; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsSpellCheckEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether text prediction features ("autocomplete") should be enabled for this TextBox. </summary>
    /// <returns>**true** to enable text prediction features, otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTextPredictionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the context for input used by this TextBox.</summary>
    /// <returns>The input scope, which provides a hint at the type of text input expected by the control.</returns>
    public extern InputScope InputScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when content changes in the text box.</summary>
    public extern event TextChangedEventHandler TextChanged;

    /// <summary>Occurs when the text selection has changed.</summary>
    public extern event RoutedEventHandler SelectionChanged;

    /// <summary>Occurs when the system processes an interaction that displays a context menu.</summary>
    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    /// <summary>Selects a range of text in the text box.</summary>
    /// <param name="start">The zero-based index of the first character in the selection.</param>
    /// <param name="length">The length of the selection, in characters.</param>
    [MethodImpl]
    public extern void Select(int start, int length);

    /// <summary>Selects the entire contents of the text box.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Returns a rectangular region for the leading or trailing edge of a character at a specific character index.</summary>
    /// <param name="charIndex">A zero-based index of the character for which to retrieve the rectangle.</param>
    /// <param name="trailingEdge">**true** to get the trailing edge; **false** to get the leading edge of the character.</param>
    /// <returns>A rectangle for the edge of the character at the specified index.</returns>
    [MethodImpl]
    public extern Rect GetRectFromCharacterIndex(int charIndex, bool trailingEdge);

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
    /// <returns>The brush used to highlight the selected text. The practical default is a brush using the theme resource **TextSelectionHighlightThemeColor**.</returns>
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
    public extern event TypedEventHandler<TextBox, TextCompositionStartedEventArgs> TextCompositionStarted;

    /// <summary>Occurs when text being composed through an Input Method Editor (IME) changes.</summary>
    public extern event TypedEventHandler<TextBox, TextCompositionChangedEventArgs> TextCompositionChanged;

    /// <summary>Occurs when a user stops composing text through an Input Method Editor (IME).</summary>
    public extern event TypedEventHandler<TextBox, TextCompositionEndedEventArgs> TextCompositionEnded;

    /// <summary>Gets or sets a value that indicates how the reading order is determined for the TextBox.</summary>
    /// <returns>A value that indicates how the reading order is determined for the TextBox. The default is **DetectFromContent**.</returns>
    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the preferred alignment of the Input Method Editor (IME).</summary>
    /// <returns>A value of the enumeration that indicates the preferred alignment of the Input Method Editor (IME). The default is **Default**.</returns>
    public extern CandidateWindowAlignment DesiredCandidateWindowAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Input Method Editor (IME) window open, updates, or closes.</summary>
    public extern event TypedEventHandler<TextBox, CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged;

    /// <summary>Occurs synchronously when the text in the text box starts to change, but before it is rendered.</summary>
    public extern event TypedEventHandler<TextBox, TextBoxTextChangingEventArgs> TextChanging;

    /// <summary>Asynchronously gets a list of candidate words based on the provided phonetic characters in an Input Method Editor (IME).</summary>
    /// <returns>A list of candidate words based on the provided phonetic characters in an Input Method Editor (IME).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();

    /// <summary>Gets or sets the brush used to highlight the selected text when the TextBox does not have focus.</summary>
    /// <returns>The brush used to highlight the selected text when TextBox loses focus. The default is a null brush from a pure code perspective, but the default control template for TextBox applies a Transparent brush for this in a runtime instance of a TextBox control. To disable the SelectionHighlightColorWhenNotFocused, set the brush to Transparent once again.</returns>
    public extern SolidColorBrush SelectionHighlightColorWhenNotFocused { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how text is aligned in the TextBox.</summary>
    /// <returns>One of the TextAlignment enumeration values that specifies how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment HorizontalTextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the control modifies the case of characters as they are typed.</summary>
    /// <returns>A value of the enumeration that indicates how the control modifies the case of characters as they are typed. The default is **Normal**, which indicates that the charcters are not changed.</returns>
    public extern CharacterCasing CharacterCasing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that describes the color of placeholder text.</summary>
    /// <returns>The brush that describes the color of placeholder text.</returns>
    public extern Brush PlaceholderForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs before copied text is moved to the clipboard.</summary>
    public extern event TypedEventHandler<TextBox, TextControlCopyingToClipboardEventArgs> CopyingToClipboard;

    /// <summary>Occurs before cut text is moved to the clipboard.</summary>
    public extern event TypedEventHandler<TextBox, TextControlCuttingToClipboardEventArgs> CuttingToClipboard;

    /// <summary>Occurs synchronously when the text in the text box starts to change, but before the **Text** property is updated.</summary>
    public extern event TypedEventHandler<TextBox, TextBoxBeforeTextChangingEventArgs> BeforeTextChanging;

    /// <summary>Gets or sets the HandwritingView associated with this text control.</summary>
    /// <returns>The HandwritingView associated with this text control.</returns>
    public extern HandwritingView HandwritingView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a user can enter text in the handwriting view.</summary>
    /// <returns>**true** to allow the user to enter text in the handwriting view; otherwise, **false**.</returns>
    public extern bool IsHandwritingViewEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether clipboard content can be pasted into the control.</summary>
    /// <returns>**true** if clipboard content can be pasted into the control; otherwise, **false**.</returns>
    public extern bool CanPasteClipboardContent { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the undo buffer contains an action that can be undone.</summary>
    /// <returns>**true** if the undo buffer contains an action that can be undone; otherwise, **false**.</returns>
    public extern bool CanUndo { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the redo buffer contains an action that can be redone.</summary>
    /// <returns>**true** if the redo buffer contains an action that can be redone; otherwise, **false**.</returns>
    public extern bool CanRedo { [MethodImpl] get; }

    /// <summary>Gets or sets the flyout that is shown when text is selected using touch or pen, or **null** if no flyout is shown.</summary>
    /// <returns>The flyout that is shown when text is selected using touch or pen, or **null** if no flyout is shown. The default is an instance of TextCommandBarFlyout.</returns>
    public extern FlyoutBase SelectionFlyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the flyout that shows proofing commands.</summary>
    /// <returns>The flyout that shows proofing commands.</returns>
    public extern FlyoutBase ProofingMenuFlyout { [MethodImpl] get; }

    /// <summary>Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.</summary>
    /// <returns>The content to be displayed below the control. The default is **null**.</returns>
    public extern object Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the text selection starts to change.</summary>
    public extern event TypedEventHandler<TextBox, TextBoxSelectionChangingEventArgs> SelectionChanging;

    /// <summary>Undoes the first action in the undo buffer.</summary>
    [MethodImpl]
    public extern void Undo();

    /// <summary>Reapplies the first action in the redo buffer.</summary>
    [MethodImpl]
    public extern void Redo();

    /// <summary>Copies content from the Windows clipboard into the text control.</summary>
    [MethodImpl]
    public extern void PasteFromClipboard();

    /// <summary>Copies the selected content to the Windows clipboard.</summary>
    [MethodImpl]
    public extern void CopySelectionToClipboard();

    /// <summary>Moves the selected content to the Windows clipboard and removes it from the text control.</summary>
    [MethodImpl]
    public extern void CutSelectionToClipboard();

    /// <summary>Empties the undo and redo buffers.</summary>
    [MethodImpl]
    public extern void ClearUndoRedoHistory();

    /// <summary>Identifies the CanPasteClipboardContent dependency property.</summary>
    /// <returns>The identifier for the CanPasteClipboardContent dependency property.</returns>
    public static extern DependencyProperty CanPasteClipboardContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanUndo dependency property.</summary>
    /// <returns>The identifier for the CanUndo dependency property.</returns>
    public static extern DependencyProperty CanUndoProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanRedo dependency property.</summary>
    /// <returns>The identifier for the CanRedo dependency property.</returns>
    public static extern DependencyProperty CanRedoProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionFlyout dependency property.</summary>
    /// <returns>The identifier for the SelectionFlyout dependency property.</returns>
    public static extern DependencyProperty SelectionFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the ProofingMenuFlyout dependency property.</summary>
    /// <returns>The identifier for the ProofingMenuFlyout dependency property.</returns>
    public static extern DependencyProperty ProofingMenuFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the PlaceholderForeground dependency property.</summary>
    /// <returns>The identifier for the PlaceholderForeground dependency property.</returns>
    public static extern DependencyProperty PlaceholderForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the **SelectionHighlightColorWhenNotFocused** dependency property.</summary>
    /// <returns>The identifier for the **SelectionHighlightColorWhenNotFocused** dependency property.</returns>
    public static extern DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the Text dependency property.</summary>
    /// <returns>The identifier for the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxLength dependency property.</summary>
    /// <returns>The identifier for the MaxLength dependency property.</returns>
    public static extern DependencyProperty MaxLengthProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsReadOnly dependency property.</summary>
    /// <returns>The identifier for the IsReadOnly dependency property.</returns>
    public static extern DependencyProperty IsReadOnlyProperty { [MethodImpl] get; }

    /// <summary>Identifies the AcceptsReturn dependency property.</summary>
    /// <returns>The identifier for the AcceptsReturn dependency property.</returns>
    public static extern DependencyProperty AcceptsReturnProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextAlignment dependency property.</summary>
    /// <returns>The identifier for the TextAlignment dependency property.</returns>
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
