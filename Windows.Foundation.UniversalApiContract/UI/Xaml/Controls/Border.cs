// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Border
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Draws a border, background, or both, around another object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBorderStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBorderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Child")]
  public sealed class Border : FrameworkElement, IBorder, IBorder2
  {
    /// <summary>Initializes a new instance of the Border class.</summary>
    [MethodImpl]
    public extern Border();

    /// <summary>Gets or sets the Brush that is applied to the edge area of the Border.</summary>
    /// <returns>The brush that fills the border. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the border.</summary>
    /// <returns>The thickness of the border, in pixels. The default is 0 on all four sides.</returns>
    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush that fills the background (inner area) of the border.</summary>
    /// <returns>The brush that fills the background. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush Background { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius for the corners of the border.</summary>
    /// <returns>The degree to which the corners are rounded, expressed as values of the CornerRadius structure.</returns>
    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the border and its child object.</summary>
    /// <returns>The dimensions of the space between the border and its child as a Thickness value. Thickness is a structure that stores dimension values using pixel measures.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the child element to draw the border around.</summary>
    /// <returns>The UIElement to apply the border to.</returns>
    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to child content of a Border.</summary>
    /// <returns>The strongly typed collection of Transition style elements.</returns>
    public extern TransitionCollection ChildTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far the background extends in relation to this element's border.</summary>
    /// <returns>A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.</returns>
    public extern BackgroundSizing BackgroundSizing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an instance of BrushTransition to automatically animate changes to the Background property.</summary>
    /// <returns>An instance of BrushTransition to automatically animate changes to the Background; otherwise, **null**. The default is **null**.</returns>
    public extern BrushTransition BackgroundTransition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the BackgroundSizing dependency property.</summary>
    /// <returns>The identifier for the BackgroundSizing dependency property.</returns>
    public static extern DependencyProperty BackgroundSizingProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderBrush dependency property.</summary>
    /// <returns>The identifier for the BorderBrush dependency property.</returns>
    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the BorderThickness dependency property.</summary>
    /// <returns>The identifier for the BorderThickness dependency property.</returns>
    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the Background dependency property.</summary>
    /// <returns>The identifier for the Background dependency property.</returns>
    public static extern DependencyProperty BackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the CornerRadius dependency property.</summary>
    /// <returns>The identifier for the CornerRadius dependency property.</returns>
    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the ChildTransitions dependency property.</summary>
    /// <returns>The identifier for the ChildTransitions dependency property.</returns>
    public static extern DependencyProperty ChildTransitionsProperty { [MethodImpl] get; }
  }
}
