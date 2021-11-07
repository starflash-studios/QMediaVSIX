// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContentPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Displays the content of a ContentControl. Can also provide content presentation for non-controls. Provides a base class for specialized presenters such as ScrollContentPresenter.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IContentPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPresenterStatics4), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPresenterStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [global::Windows.UI.Xaml.Markup.ContentProperty(Name = "Content")]
  [Static(typeof (IContentPresenterStatics5), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IContentPresenterStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ContentPresenter : 
    FrameworkElement,
    IContentPresenter,
    IContentPresenter2,
    IContentPresenter3,
    IContentPresenter4,
    IContentPresenter5,
    IContentPresenterOverrides
  {
    /// <summary>Initializes a new instance of the ContentPresenter class.</summary>
    [MethodImpl]
    public extern ContentPresenter();

    /// <summary>Gets or sets the data that is used to generate the child elements of a ContentPresenter.</summary>
    /// <returns>The data that is used to generate the child elements. The default is null.</returns>
    public extern object Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the template that is used to display the content of the control.</summary>
    /// <returns>A DataTemplate that defines the visualization of the content. The default is null.</returns>
    public extern DataTemplate ContentTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a selection object that changes the DataTemplate to apply for content presented in the ContentPresenter, based on processing information about the content item or its container at run time.</summary>
    /// <returns>A selection object that changes the DataTemplate to apply for content.</returns>
    public extern DataTemplateSelector ContentTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to content presented by the ContentPresenter.</summary>
    /// <returns>The strongly typed collection of Transition style elements.</returns>
    public extern TransitionCollection ContentTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font size for the text content presented by the ContentPresenter.</summary>
    /// <returns>A non-negative value that specifies the font size, measured in pixels.</returns>
    public extern double FontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the preferred top-level font family for the text content presented by the ContentPresenter.</summary>
    /// <returns>A FontFamily object that specifies the preferred font family, or a primary preferred font family with one or more fallback font families. For information about defaults, see the FontFamily class topic.</returns>
    public extern FontFamily FontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the top-level font weight for the text content presented by the ContentPresenter.</summary>
    /// <returns>The requested font weight, which is a FontWeight that is obtained from one of the FontWeights property values. The default is Normal.</returns>
    public extern FontWeight FontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style for the presented content.</summary>
    /// <returns>The requested font style, which is a FontStyle constant name. The default is Normal.</returns>
    public extern FontStyle FontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font stretch for the text content presented by the ContentPresenter.</summary>
    /// <returns>The requested font stretch, as a FontStretch constant. The default is Normal.</returns>
    public extern FontStretch FontStretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform spacing between characters, in units of 1/1000 of an em.</summary>
    /// <returns>The uniform spacing between characters, in units of 1/1000 of an em. The default is 0. Positive values increase tracking and loosen character spacing. Negative values decrease tracking and tighten the character spacing.</returns>
    public extern int CharacterSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush to apply to the text content handled by the ContentPresenter.</summary>
    /// <returns>The brush used as the foreground brush for the text contents. The default is a null brush from a pure code perspective, but system style defaults set this to Black (for **Light** theme) or White (for **Dark** theme).</returns>
    public extern Brush Foreground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or sets a value that indicates how the font is modified to align with fonts of different sizes.</summary>
    /// <returns>A value of the enumeration that indicates how the font is modified to align at different sizes. The default is **None**.</returns>
    public extern OpticalMarginAlignment OpticalMarginAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the line box height is determined for each line of text displayed in the ContentPresenter.</summary>
    /// <returns>A value that indicates how the line box height is determined for each line of text. The default is **Full**.</returns>
    public extern TextLineBounds TextLineBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether automatic text enlargement, to reflect the system text size setting, is enabled.</summary>
    /// <returns>**true** if automatic text enlargement is enabled; otherwise, **false**.</returns>
    public extern bool IsTextScaleFactorEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how the element wraps text.</summary>
    /// <returns>A value that indicates how the element wraps text. The default is **NoWrap**.</returns>
    public extern TextWrapping TextWrapping { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum lines of text shown.</summary>
    /// <returns>The maximum lines of text shown. The default is 0, which is a special value that represents "Auto" behavior. The value cannot be negative.</returns>
    public extern int MaxLines { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how a line box is determined for each line of text.</summary>
    /// <returns>A value that indicates how a line box is determined for each line of text. The default is **MaxHeight**.</returns>
    public extern LineStackingStrategy LineStackingStrategy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height of each line of text content presented by the ContentPresenter.</summary>
    /// <returns>The height in pixels of each line of text content. A value of 0 indicates that the line height is determined automatically from the current font characteristics. The default is 0.</returns>
    public extern double LineHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that describes the border fill of the content presenter.</summary>
    /// <returns>The brush that is used to fill the content presenter's border. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the border thickness of the content presenter.</summary>
    /// <returns>The border thickness of the content presenter, as a Thickness value.</returns>
    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius for the corners of the content presenter's border.</summary>
    /// <returns>The degree to which the corners are rounded, expressed as values of the CornerRadius structure.</returns>
    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the border and its child object.</summary>
    /// <returns>The dimensions of the space between the border and its child as a Thickness value. Thickness is a structure that stores dimension values using pixel measures.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush to apply to the background of content handled by the ContentPresenter.</summary>
    /// <returns>The brush used as the background brush for the contents. The default is a null brush from a pure code perspective, but system style defaults set this to White (for **Light** theme) or Black (for **Dark** theme).</returns>
    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment of the content.</summary>
    /// <returns>One of the HorizontalAlignment values.</returns>
    public extern HorizontalAlignment HorizontalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of the content.</summary>
    /// <returns>One of the VerticalAlignment values.</returns>
    public extern VerticalAlignment VerticalContentAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an instance of BrushTransition to automatically animate changes to the Background property.</summary>
    /// <returns>An instance of BrushTransition to automatically animate changes to the Background; otherwise, **null**. The default is **null**.</returns>
    public extern BrushTransition BackgroundTransition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far the background extends in relation to this element's border.</summary>
    /// <returns>A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.</returns>
    public extern BackgroundSizing BackgroundSizing { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IContentPresenterOverrides.OnContentTemplateChanged(
      DataTemplate oldContentTemplate,
      DataTemplate newContentTemplate);

    [MethodImpl]
    extern void IContentPresenterOverrides.OnContentTemplateSelectorChanged(
      DataTemplateSelector oldContentTemplateSelector,
      DataTemplateSelector newContentTemplateSelector);

    /// <summary>Identifies the BackgroundSizing dependency property.</summary>
    /// <returns>The identifier for the BackgroundSizing dependency property.</returns>
    public static extern DependencyProperty BackgroundSizingProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextWrapping dependency property.</summary>
    /// <returns>The identifier for the TextWrapping dependency property.</returns>
    public static extern DependencyProperty TextWrappingProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxLines dependency property.</summary>
    /// <returns>The identifier for the MaxLines dependency property.</returns>
    public static extern DependencyProperty MaxLinesProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineStackingStrategy dependency property.</summary>
    /// <returns>The identifier for the LineStackingStrategy dependency property.</returns>
    public static extern DependencyProperty LineStackingStrategyProperty { [MethodImpl] get; }

    /// <summary>Identifies the LineHeight  dependency property.</summary>
    /// <returns>The identifier for the LineHeight dependency property.</returns>
    public static extern DependencyProperty LineHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderBrush dependency property.</summary>
    /// <returns>The identifier for the BorderBrush dependency property.</returns>
    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderThickness dependency property.</summary>
    /// <returns>The identifier for the BorderThickness dependency property.</returns>
    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the CornerRadius dependency property.</summary>
    /// <returns>The identifier for the CornerRadius dependency property.</returns>
    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Background dependency property.</summary>
    /// <returns>The identifier for the Background dependency property.</returns>
    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalContentAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalContentAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the VerticalContentAlignment dependency property.</returns>
    public static extern DependencyProperty VerticalContentAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTextScaleFactorEnabled  dependency property.</summary>
    /// <returns>The identifier for the IsTextScaleFactorEnabled dependency property.</returns>
    public static extern DependencyProperty IsTextScaleFactorEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the OpticalMarginAlignment dependency property.</summary>
    /// <returns>The identifier for the OpticalMarginAlignment dependency property.</returns>
    public static extern DependencyProperty OpticalMarginAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the TextLineBounds dependency property.</summary>
    /// <returns>The identifier for the TextLineBounds dependency property.</returns>
    public static extern DependencyProperty TextLineBoundsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Content dependency property</summary>
    /// <returns>The identifier for the Content dependency property.</returns>
    public static extern DependencyProperty ContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTemplate dependency property.</summary>
    /// <returns>The identifier for the ContentTemplate dependency property.</returns>
    public static extern DependencyProperty ContentTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTemplateSelector dependency property.</summary>
    /// <returns>The identifier for the ContentTemplateSelector dependency property.</returns>
    public static extern DependencyProperty ContentTemplateSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentTransitions dependency property.</summary>
    /// <returns>The identifier for the ContentTransitions dependency property.</returns>
    public static extern DependencyProperty ContentTransitionsProperty { [MethodImpl] get; }

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
  }
}
