// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichTextBlockOverflow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a rich text display overflow container. This element cannot have direct content. The only purpose of RichTextBlockOverflow is to display text content that does not fit in the bounds of a RichTextBlock or another RichTextBlockOverflow element.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRichTextBlockOverflowStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockOverflowStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRichTextBlockOverflowStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RichTextBlockOverflow : 
    FrameworkElement,
    IRichTextBlockOverflow,
    IRichTextBlockOverflow2,
    IRichTextBlockOverflow3
  {
    /// <summary>Initializes a new instance of the RichTextBlockOverflow class.</summary>
    [MethodImpl]
    public extern RichTextBlockOverflow();

    /// <summary>Gets or sets a reference to another RichTextBlockOverflow that is the linked target for any text overflow from this RichTextBlockOverflow.</summary>
    /// <returns>The target for overflow.</returns>
    public extern RichTextBlockOverflow OverflowContentTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the thickness of padding space between the boundaries of the content area and the content displayed by a RichTextBlockOverflow.</summary>
    /// <returns>A Thickness structure that specifies the amount of padding to apply.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the RichTextBlock content source of this RichTextBlockOverflow.</summary>
    /// <returns>The content source for this RichTextBlockOverflow.</returns>
    public extern RichTextBlock ContentSource { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the RichTextBlockOverflow has content that extends beyond its bounds, that can provide content to an OverflowContentTarget element.</summary>
    /// <returns>**True** if the RichTextBlockOverflow has content that extends beyond its bounds; otherwise, **false**.</returns>
    public extern bool HasOverflowContent { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that indicates the start of content in the RichTextBlockOverflow.</summary>
    /// <returns>A TextPointer that indicates the start of content in the RichTextBlockOverflow.</returns>
    public extern TextPointer ContentStart { [MethodImpl] get; }

    /// <summary>Gets a TextPointer that indicates the end of content in the RichTextBlockOverflow.</summary>
    /// <returns>A TextPointer that indicates the end of content in the RichTextBlockOverflow.</returns>
    public extern TextPointer ContentEnd { [MethodImpl] get; }

    /// <summary>Gets a value that represents the offset in pixels from the top of the content to the baseline of the first paragraph. The baseline of the paragraph is the baseline of the first line in it.</summary>
    /// <returns>The computed baseline for the first paragraph, or 0 if the RichTextBlockOverflow is empty.</returns>
    public extern double BaselineOffset { [MethodImpl] get; }

    /// <summary>Returns a TextPointer text reference from a RichTextBlockOverflow by hit-testing a specific Point within the text display area.</summary>
    /// <param name="point">The point to test.</param>
    /// <returns>The determined text reference.</returns>
    [MethodImpl]
    public extern TextPointer GetPositionFromPoint(Point point);

    /// <summary>Focuses the RichTextBlockOverflow, as if it were a conventionally focusable control.</summary>
    /// <param name="value">Specifies the desired target for focus state, as a value of the enumeration.</param>
    /// <returns>**true** if focus was set to the RichTextBlockOverflow, or focus was already there. **false** if the RichTextBlockOverflow is not focusable.</returns>
    [MethodImpl]
    public extern bool Focus(FocusState value);

    /// <summary>Gets or sets the maximum lines of text shown in the RichTextBlockOverflow.</summary>
    /// <returns>The maximum lines of text shown in the RichTextBlockOverflow. The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.</returns>
    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the control has trimmed text that overflows the content area.</summary>
    /// <returns>**true** if text is trimmed; otherwise, **false**.</returns>
    public extern bool IsTextTrimmed { [MethodImpl] get; }

    /// <summary>Occurs when the IsTextTrimmed property value has changed.</summary>
    public extern event TypedEventHandler<RichTextBlockOverflow, IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged;

    /// <summary>Identifies the IsTextTrimmed dependency property.</summary>
    /// <returns>The identifier for the IsTextTrimmed dependency property.</returns>
    public static extern DependencyProperty IsTextTrimmedProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxLines dependency property.</summary>
    /// <returns>The identifier for the MaxLines dependency property.</returns>
    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    /// <summary>Identifies the OverflowContentTarget dependency property.</summary>
    /// <returns>The identifier for the OverflowContentTarget dependency property.</returns>
    public static extern DependencyProperty OverflowContentTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the HasOverflowContent dependency property.</summary>
    /// <returns>The identifier for the HasOverflowContent dependency property.</returns>
    public static extern DependencyProperty HasOverflowContentProperty { [MethodImpl] get; }
  }
}
