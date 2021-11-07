// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextBlock
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a lightweight control for displaying small amounts of text.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ITextBlockStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics7), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics6), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITextBlockStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Inlines")]
  [WebHostHidden]
  public sealed class TextBlock : 
    FrameworkElement,
    ITextBlock,
    ITextBlock2,
    ITextBlock3,
    ITextBlock4,
    ITextBlock5,
    ITextBlock6,
    ITextBlock7
  {
    /// <summary>Initializes a new instance of the TextBlock class.</summary>
    [MethodImpl]
    public extern TextBlock();

    /// <summary>Gets or sets the font size for the text content in this element.</summary>
    /// <returns>A non-negative value that specifies the font size, measured in pixels. The default is 11.</returns>
    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the preferred top-level font family for the text content in this element.</summary>
    /// <returns>A FontFamily object that specifies the preferred font family, or a primary preferred font family with one or more fallback font families. For information about defaults, see the FontFamily class topic.</returns>
    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the top-level font weight for the TextBlock.</summary>
    /// <returns>The requested font weight, which is a FontWeight that is obtained from one of the FontWeights property values. The default is Normal.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style for the content in this element.</summary>
    /// <returns>The requested font style, which is a FontStyle enumeration value. The default is Normal.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font stretch for the text content in this element.</summary>
    /// <returns>The requested font stretch, as a FontStretch constant. The default is Normal.</returns>
    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform spacing between characters, in units of 1/1000 of an em.</summary>
    /// <returns>The uniform spacing between characters, in units of 1/1000 of an em. The default is 0. Positive values increase tracking and loosen character spacing. Negative values decrease tracking and tighten the character spacing.</returns>
    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush to apply to the text contents of the TextBlock.</summary>
    /// <returns>The brush used to apply to the text content. The default is a null brush from a pure code perspective, but the default text styles set this to Black (for **Light** theme) or White (for **Dark** theme) for a TextBlock element in UI.</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how the TextBlock wraps text.</summary>
    /// <returns>A value that indicates how the TextBlock wraps text. The default is **NoWrap**.</returns>
    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text trimming behavior to employ when content overflows the content area.</summary>
    /// <returns>One of the TextTrimming values that specifies the text trimming behavior to employ. The default is **None**.</returns>
    public extern TextTrimming TextTrimming { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the horizontal alignment of text content.</summary>
    /// <returns>The text alignment. The default is **Left**.</returns>
    public extern TextAlignment TextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text contents of a TextBlock.</summary>
    /// <returns>A string that specifies the text contents of this TextBlock. The default is an empty string.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of inline text elements within a TextBlock.</summary>
    /// <returns>A collection that holds all inline text elements from the TextBlock. The default is an empty collection.</returns>
    public extern InlineCollection Inlines { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a TextBlock.</summary>
    /// <returns>A Thickness structure that specifies the amount of padding to apply.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height of each line of content.</summary>
    /// <returns>The height of each line in pixels. A value of 0 indicates that the line height is determined automatically from the current font characteristics. The default is 0.</returns>
    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how a line box is determined for each line of text in the TextBlock.</summary>
    /// <returns>A value that indicates how a line box is determined for each line of text in the TextBlock. The default is **MaxHeight**.</returns>
    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether text selection is enabled in the TextBlock, either through user action or calling selection-related API.</summary>
    /// <returns>**true** if text selection is enabled; otherwise, **false**.</returns>
    public extern bool IsTextSelectionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a text range of selected text.</summary>
    /// <returns>A text range of the selected text.</returns>
    public extern string SelectedText { [MethodImpl] get; }

    /// <summary>Gets a TextPointer object for the start of text content in the TextBlock.</summary>
    /// <returns>A TextPointer object for the start of text content in the TextBlock.</returns>
    public extern TextPointer ContentStart { [MethodImpl] get; }

    /// <summary>Gets a TextPointer object for the end of text content in the TextBlock.</summary>
    /// <returns>A TextPointer object for the end of text content in the TextBlock.</returns>
    public extern TextPointer ContentEnd { [MethodImpl] get; }

    /// <summary>Gets the starting position of the text selected in the TextBlock.</summary>
    /// <returns>An object that represents the selection start, or null if no selection exists.</returns>
    public extern TextPointer SelectionStart { [MethodImpl] get; }

    /// <summary>Gets the end position of the text selected in the TextBlock.</summary>
    /// <returns>An object that represents the selection end, or null if no selection exists.</returns>
    public extern TextPointer SelectionEnd { [MethodImpl] get; }

    /// <summary>Returns a value by which each line of text is offset from a baseline.</summary>
    /// <returns>The amount by which each line of text is offset from the baseline, in device independent pixels. System.Double.NaN indicates that an optimal baseline offset is automatically calculated from the current font characteristics. The default is System.Double.NaN.</returns>
    public extern double BaselineOffset { [MethodImpl] get; }

    /// <summary>Occurs when the text selection has changed.</summary>
    public extern event RoutedEventHandler SelectionChanged;

    /// <summary>Occurs when the system processes an interaction that displays a context menu.</summary>
    public extern event ContextMenuOpeningEventHandler ContextMenuOpening;

    /// <summary>Selects the entire contents in the TextBlock.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Selects a range of text in the TextBlock.</summary>
    /// <param name="start">An object that represents the start of the range to select.</param>
    /// <param name="end">An object that represents the end of the range to select.</param>
    [MethodImpl]
    public extern void Select(TextPointer start, TextPointer end);

    /// <summary>Focuses the TextBlock, as if it were a conventionally focusable control.</summary>
    /// <param name="value">Specifies the desired target for focus state, as a value of the enumeration.</param>
    /// <returns>**true** if focus was set to the TextBlock, or focus was already there. **false** if the TextBlock is not focusable.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Gets or sets the brush used to highlight the selected text.</summary>
    /// <returns>The brush used to highlight the selected text. The default is a null brush from a pure code perspective, but the system uses base text styles to supply a runtime value for apps (unless you specifically override that style). The practical default is a brush using the theme resource **TextSelectionHighlightThemeColor**.</returns>
    public extern SolidColorBrush SelectionHighlightColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of lines of text shown in the TextBlock.</summary>
    /// <returns>The maximum number of lines of text shown in the TextBlock. The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.</returns>
    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the line box height is determined for each line of text in the TextBlock.</summary>
    /// <returns>A value that indicates how the line box height is determined for each line of text in the TextBlock. The default is **Full**.</returns>
    public extern TextLineBounds TextLineBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets a value that indicates how the font is modified to align with fonts of different sizes.</summary>
    /// <returns>A value of the enumeration that indicates how the font is modified to align at different sizes. The default is **None**.</returns>
    public extern OpticalMarginAlignment OpticalMarginAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether font glyphs that contain color layers, such as Segoe UI Emoji, are rendered in color.</summary>
    /// <returns>**true** if color glyphs show in color; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the reading order is determined for the TextBlock.</summary>
    /// <returns>A value that indicates how the reading order is determined for the TextBlock. The default is **DetectFromContent**.</returns>
    public extern TextReadingOrder TextReadingOrder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether automatic text enlargement, to reflect the system text size setting, is enabled.</summary>
    /// <returns>**true** if automatic text enlargement is enabled; otherwise, **false**.</returns>
    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a mask that represents the alpha channel of the text as a CompositionBrush.</summary>
    /// <returns>A mask that represents the alpha channel of the text in a TextBlock.</returns>
    [MethodImpl]
    public extern CompositionBrush GetAlphaMask();

    /// <summary>Gets or sets a value that indicates what decorations are applied to the text.</summary>
    /// <returns>A value of the enumeration. The default is **None**.</returns>
    public extern TextDecorations TextDecorations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the control has trimmed text that overflows the content area.</summary>
    /// <returns>**true** if text is trimmed; otherwise, **false**.</returns>
    public extern bool IsTextTrimmed { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates how text is aligned in the TextBlock.</summary>
    /// <returns>One of the TextAlignment enumeration values that specifies how text is aligned. The default is **Left**.</returns>
    public extern TextAlignment HorizontalTextAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of text highlights.</summary>
    /// <returns>The collection of text highlights.</returns>
    public extern IVector<TextHighlighter> TextHighlighters { [MethodImpl] get; }

    /// <summary>Occurs when the IsTextTrimmed property value has changed.</summary>
    public extern event TypedEventHandler<TextBlock, IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged;

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

    /// <summary>Identifies the SelectionHighlightColor dependency property.</summary>
    /// <returns>The identifier for the SelectionHighlightColor dependency property.</returns>
    public static extern DependencyProperty SelectionHighlightColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxLines dependency property.</summary>
    /// <returns>The identifier for the MaxLines dependency property.</returns>
    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextLineBounds dependency property.</summary>
    /// <returns>The identifier for the TextLineBounds dependency property.</returns>
    public static extern DependencyProperty TextLineBoundsProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the CharacterSpacing dependency property.</summary>
    /// <returns>The identifier for the CharacterSpacing dependency property.</returns>
    public static extern DependencyProperty CharacterSpacingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Foreground  dependency property.</summary>
    /// <returns>The identifier for the Foreground dependency property.</returns>
    public static extern DependencyProperty ForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextWrapping  dependency property.</summary>
    /// <returns>The identifier of the TextWrapping dependency property.</returns>
    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextTrimming dependency property.</summary>
    /// <returns>The identifier of the TextTrimming dependency property.</returns>
    public static extern DependencyProperty TextTrimmingProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextAlignment  dependency property.</summary>
    /// <returns>The identifier for the TextAlignment dependency property.</returns>
    public static extern DependencyProperty TextAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the Text  dependency property.</summary>
    /// <returns>The identifier of the Text dependency property.</returns>
    public static extern DependencyProperty TextProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding  dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineHeight  dependency property.</summary>
    /// <returns>The identifier for the LineHeight dependency property.</returns>
    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineStackingStrategy  dependency property.</summary>
    /// <returns>The identifier for the LineStackingStrategy dependency property.</returns>
    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextSelectionEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTextSelectionEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextSelectionEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedText dependency property.</summary>
    /// <returns>The identifier for the SelectedText dependency property.</returns>
    public static extern DependencyProperty SelectedTextProperty { [MethodImpl] get; }
  }
}
