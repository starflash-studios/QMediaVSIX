// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichTextBlock
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
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a rich text display container that supports formatted text, hyperlinks, inline images, and other rich content. RichTextBlock supports a built-in overflow model.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Blocks")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockStatics6), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockStatics5), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RichTextBlock : 
    FrameworkElement,
    IRichTextBlock,
    IRichTextBlock2,
    IRichTextBlock3,
    IRichTextBlock4,
    IRichTextBlock5,
    IRichTextBlock6
  {
    /// <summary>Initializes a new instance of the RichTextBlock class.</summary>
    [MethodImpl]
    public extern RichTextBlock();

    /// <summary>Gets or sets the font size for the text content in this element.</summary>
    /// <returns>A non-negative value that specifies the font size, measured in pixels. The default is 11.</returns>
    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the preferred top-level font family for the text content in this element.</summary>
    /// <returns>A FontFamily object that specifies the preferred font family, or a primary preferred font family with one or more fallback font families. For information about defaults, see the FontFamily class topic.</returns>
    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the top-level font weight for the RichTextBlock.</summary>
    /// <returns>The requested font weight, which is a FontWeight that is obtained from one of the FontWeights property values. The default is Normal.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style for the content in this element.</summary>
    /// <returns>The requested font style, which is a FontStyle enumeration named constant. The default is Normal.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font stretch for the text content in this element.</summary>
    /// <returns>The requested font stretch, as a FontStretch constant. The default is Normal.</returns>
    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush to apply to the text contents of the RichTextBlock.</summary>
    /// <returns>The brush used to apply to the text contents. The default is a null brush from a pure code perspective, but the default text styles set this to Black (for **Light** theme) or White (for **Dark** theme) for a TextBlock element in UI.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether text wrapping occurs if a line of text extends beyond the available width of the RichTextBlock.</summary>
    /// <returns>One of the TextWrapping enumeration values that specifies whether text is wrapped. The default is **Wrap**.</returns>
    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how text is trimmed when it overflows the content area.</summary>
    /// <returns>One of the TextTrimming enumeration values that specifies the text trimming behavior to use. The default is **None**.</returns>
    public extern TextTrimming TextTrimming { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the text is aligned in the RichTextBlock.</summary>
    /// <returns>One of the TextAlignment enumeration values that indicates how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the contents of the RichTextBlock.</summary>
    /// <returns>A BlockCollection that contains the contents of the RichTextBlock.</returns>
    public extern BlockCollection Blocks { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a RichTextBlock.</summary>
    /// <returns>A Thickness structure that specifies the amount of padding to apply.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height of each line of content.</summary>
    /// <returns>The height of each line in pixels. A value of 0 indicates that the line height is determined automatically from the current font characteristics. The default is 0.</returns>
    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how a line box is determined for each line of text in the RichTextBlock.</summary>
    /// <returns>A value that indicates how a line box is determined for each line of text in the RichTextBlock. The default is **MaxHeight**.</returns>
    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform spacing between characters, in units of 1/1000 of an em.</summary>
    /// <returns>The uniform spacing between characters, in units of 1/1000 of an em. The default is 0. Positive values increase tracking and loosen character spacing. Negative values decrease tracking and tighten the character spacing.</returns>
    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a RichTextBlockOverflow that is the linked target for any text overflow from this RichTextBlock.</summary>
    /// <returns>The target for overflow.</returns>
    public extern RichTextBlockOverflow OverflowContentTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether text content of the RichTextBlock can be selected for clipboard or drag purposes, or for UI styling changes that indicate selected text.</summary>
    /// <returns>**true** if text content of the RichTextBlock can be selected for clipboard or drag purposes. **false** if text cannot be selected. The default is **true**.</returns>
    public extern bool IsTextSelectionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the RichTextBlock has content that extends beyond its bounds, that can provide content to an OverflowContentTarget element.</summary>
    /// <returns>**True** if the RichTextBlock has content that extends beyond its bounds; otherwise, **false**.</returns>
    public extern bool HasOverflowContent { [MethodImpl] get; }

    /// <summary>Gets a text range of selected text.</summary>
    /// <returns>A text range of the selected text.</returns>
    public extern string SelectedText { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that indicates the start of content in the RichTextBlock.</summary>
    /// <returns>A TextPointer that indicates the start of content in the RichTextBlock.</returns>
    public extern TextPointer ContentStart { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that indicates the end of content in the RichTextBlock.</summary>
    /// <returns>A TextPointer that indicates the end of content in the RichTextBlock.</returns>
    public extern TextPointer ContentEnd { [MethodImpl] get; }

    /// <summary>Gets the starting position of the text selected in the RichTextBlock.</summary>
    /// <returns>An object that represents the selection start, or **null** if no selection exists.</returns>
    public extern TextPointer SelectionStart { [MethodImpl] get; }

    /// <summary>Gets the end position of the text selected in the RichTextBlock.</summary>
    /// <returns>An object that represents the selection end, or null if no selection exists.</returns>
    public extern TextPointer SelectionEnd { [MethodImpl] get; }

    /// <summary>Gets a value that represents the offset in pixels from the top of the content to the baseline of the first paragraph. The baseline of the paragraph is the baseline of the first line in it.</summary>
    /// <returns>The computed baseline for the first paragraph, or 0 if the RichTextBlock is empty.</returns>
    public extern double BaselineOffset { [MethodImpl] get; }

    /// <summary>Occurs when the text selection has changed.</summary>
    public extern event RoutedEventHandler SelectionChanged;

    /// <summary>Occurs when the system processes an interaction that displays a context menu.</summary>
    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    /// <summary>Selects the entire contents in the RichTextBlock.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Selects a range of text in the RichTextBlock.</summary>
    /// <param name="start">An object that represents the start of the range to select.</param>
    /// <param name="end">An object that represents the end of the range to select.</param>
    [MethodImpl]
    public extern void Select(TextPointer start, TextPointer end);

    /// <summary>Returns a TextPointer text reference from a RichTextBlock by hit-testing a specific Point within the text display area.</summary>
    /// <param name="point">The point to test.</param>
    /// <returns>The determined text reference.</returns>
    [MethodImpl]
    public extern TextPointer GetPositionFromPoint(Point point);

    /// <summary>Focuses the RichTextBlock, as if it were a conventionally focusable control.</summary>
    /// <param name="value">Specifies the desired target for focus state, as a value of the enumeration.</param>
    /// <returns>**true** if focus was set to the RichTextBlock, or focus was already there. **false** if the RichTextBlock is not focusable.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Gets or sets the indentation of the first line of text in each paragraph in the RichTextBlock.</summary>
    /// <returns>The offset amount of the first line of text in a paragraph.</returns>
    public extern double TextIndent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum lines of text shown in the RichTextBlock.</summary>
    /// <returns>The maximum lines of text shown in the RichTextBlock. The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.</returns>
    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the line box height is determined for each line of text in the RichTextBlock.</summary>
    /// <returns>A value that indicates how the line box height is determined for each line of text in the RichTextBlock. The default is **Full**.</returns>
    public extern TextLineBounds TextLineBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to highlight the selected text.</summary>
    /// <returns>The brush used to highlight the selected text. The default is a null brush from a pure code perspective, but the default text styles for RichTextBlock content apply a theme resource brush for this in a runtime instance of a RichTextBlock control.</returns>
    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets a value that indicates how the font is modified to align with fonts of different sizes.</summary>
    /// <returns>A value of the enumeration that indicates how the font is modified to align at different sizes. The default is **None**.</returns>
    public extern OpticalMarginAlignment OpticalMarginAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether font glyphs that contain color layers, such as Segoe UI Emoji, are rendered in color.</summary>
    /// <returns>**true** if color glyphs show in color; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the reading order is determined for the RichTextBlock.</summary>
    /// <returns>A value that indicates how the reading order is determined for the RichTextBlock. The default is **DetectFromContent**.</returns>
    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether automatic text enlargement, to reflect the system text size setting, is enabled.</summary>
    /// <returns>**true** if automatic text enlargement is enabled; otherwise, **false**.</returns>
    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates what decorations are applied to the text.</summary>
    /// <returns>A value of the enumeration. The default is **None**.</returns>
    public extern TextDecorations TextDecorations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the control has trimmed text that overflows the content area.</summary>
    /// <returns>**true** if text is trimmed; otherwise, **false**.</returns>
    public extern bool IsTextTrimmed { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates how text is aligned in the RichTextBlock.</summary>
    /// <returns>One of the TextAlignment enumeration values that specifies how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment HorizontalTextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of text highlights.</summary>
    /// <returns>The collection of text highlights.</returns>
    public extern IVector<TextHighlighter> TextHighlighters { [MethodImpl] get; }

    /// <summary>Occurs when the IsTextTrimmed property value has changed.</summary>
    public extern event TypedEventHandler<RichTextBlock, IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged;

    /// <summary>Gets or sets the flyout that is shown when text is selected using touch or pen, or **null** if no flyout is shown.</summary>
    /// <returns>The flyout that is shown when text is selected using touch or pen, or **null** if no flyout is shown. The default is an instance of TextCommandBarFlyout.</returns>
    public extern FlyoutBase SelectionFlyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Copies the selected content to the Windows clipboard.</summary>
    [MethodImpl]
    public extern void CopySelectionToClipboard();

    /// <summary>Identifies the SelectionFlyout dependency property.</summary>
    /// <returns>The identifier for the SelectionFlyout dependency property.</returns>
    public static extern DependencyProperty SelectionFlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextTrimmed dependency property.</summary>
    /// <returns>The identifier for the IsTextTrimmed dependency property.</returns>
    public static extern DependencyProperty IsTextTrimmedProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalTextAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalTextAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalTextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the **TextDecorations** dependency property.</summary>
    /// <returns>The identifier for the **TextDecorations** dependency property.</returns>
    public static extern DependencyProperty TextDecorationsProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextScaleFactorEnabled  dependency property.</summary>
    /// <returns>The identifier for the IsTextScaleFactorEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxLines dependency property.</summary>
    /// <returns>The identifier for the MaxLines dependency property.</returns>
    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextLineBounds dependency property.</summary>
    /// <returns>The identifier for the TextLineBounds dependency property.</returns>
    public static extern DependencyProperty TextLineBoundsProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionHighlightColor dependency property.</summary>
    /// <returns>The identifier for the SelectionHighlightColor dependency property.</returns>
    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the OpticalMarginAlignment dependency property.</summary>
    /// <returns>The identifier for the OpticalMarginAlignment dependency property.</returns>
    public static extern DependencyProperty OpticalMarginAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsColorFontEnabled dependency property.</summary>
    /// <returns>The identifier for the IsColorFontEnabled dependency property.</returns>
    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextReadingOrder dependency property.</summary>
    /// <returns>The identifier for the TextReadingOrder dependency property.</returns>
    public static extern DependencyProperty TextReadingOrderProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontSize  dependency property.</summary>
    /// <returns>The identifier for the FontSize dependency property.</returns>
    public static extern DependencyProperty FontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontFamily  dependency property.</summary>
    /// <returns>The identifier for the FontFamily dependency property.</returns>
    public static extern DependencyProperty FontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontWeight  dependency property.</summary>
    /// <returns>The identifier for the FontWeight dependency property.</returns>
    public static extern DependencyProperty FontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontStyle  dependency property.</summary>
    /// <returns>The identifier for the FontStyle dependency property.</returns>
    public static extern DependencyProperty FontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontStretch  dependency property.</summary>
    /// <returns>The identifier for the FontStretch dependency property.</returns>
    public static extern DependencyProperty FontStretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the Foreground  dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextWrapping dependency property.</summary>
    /// <returns>The identifier for the TextWrapping dependency property.</returns>
    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextTrimming dependency property.</summary>
    /// <returns>The identifier of the TextTrimming dependency property.</returns>
    public static extern DependencyProperty TextTrimmingProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextAlignment dependency property.</summary>
    /// <returns>Identifier for the TextAlignment dependency property.</returns>
    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding  dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineHeight  dependency property.</summary>
    /// <returns>The identifier for the LineHeight dependency property.</returns>
    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineStackingStrategy  dependency property.</summary>
    /// <returns>The identifier for the LineStackingStrategy dependency property.</returns>
    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the CharacterSpacing dependency property.</summary>
    /// <returns>The identifier for the CharacterSpacing dependency property.</returns>
    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    /// <summary>Identifies the OverflowContentTarget dependency property.</summary>
    /// <returns>The identifier for the OverflowContentTarget dependency property.</returns>
    public static extern DependencyProperty OverflowContentTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextSelectionEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTextSelectionEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextSelectionEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the HasOverflowContent dependency property.</summary>
    /// <returns>The identifier for the HasOverflowContent dependency property.</returns>
    public static extern DependencyProperty HasOverflowContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedText dependency property.</summary>
    /// <returns>The identifier for the SelectedText dependency property.</returns>
    public static extern DependencyProperty SelectedTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextIndent dependency property.</summary>
    /// <returns>The identifier of the TextIndent dependency property.</returns>
    public static extern DependencyProperty TextIndentProperty { [MethodImpl] get; }
  }
}
