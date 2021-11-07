// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Grid
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines a flexible grid area that consists of columns and rows. Child elements of the Grid are measured and arranged according to their row/column assignments (set by using Grid.Row and Grid.Column attached properties) and other logic.</summary>
  [Static(typeof (IGridStatics4), 458752, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IGridFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IGridStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGridStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGridStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Grid : Panel, IGrid, IGrid2, IGrid3, IGrid4
  {
    /// <summary>Initializes a new instance of the Grid class.</summary>
    [MethodImpl]
    public extern Grid();

    /// <summary>Gets a list of RowDefinition objects defined on this instance of Grid.</summary>
    /// <returns>A list of RowDefinition objects defined on this instance of Grid.</returns>
    public extern RowDefinitionCollection RowDefinitions { [MethodImpl] get; }

    /// <summary>Gets a list of ColumnDefinition objects defined on this instance of Grid.</summary>
    /// <returns>A list of ColumnDefinition objects defined on this instance of Grid.</returns>
    public extern ColumnDefinitionCollection ColumnDefinitions { [MethodImpl] get; }

    /// <summary>Gets or sets a brush that describes the border fill of the panel.</summary>
    /// <returns>The brush that is used to fill the panel's border. The default is **null**, (a null brush) which is evaluated as Transparent for rendering.</returns>
    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the border thickness of the panel.</summary>
    /// <returns>The border thickness of the panel, as a Thickness value.</returns>
    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius for the corners of the panel's border.</summary>
    /// <returns>The degree to which the corners are rounded, expressed as values of the CornerRadius structure.</returns>
    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the border and its child object.</summary>
    /// <returns>The dimensions of the space between the border and its child as a Thickness value. Thickness is a structure that stores dimension values using pixel measures.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform distance (in pixels) between grid rows.</summary>
    /// <returns>The uniform distance (in pixels) between grid rows.</returns>
    public extern double RowSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the uniform distance (in pixels) between grid columns.</summary>
    /// <returns>The uniform distance (in pixels) between grid columns.</returns>
    public extern double ColumnSpacing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how far the background extends in relation to this element's border.</summary>
    /// <returns>A value of the enumeration that indicates how far the background extends. The default is **InnerBorderEdge**.</returns>
    public extern BackgroundSizing BackgroundSizing { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the BackgroundSizing dependency property.</summary>
    /// <returns>The identifier for the BackgroundSizing dependency property.</returns>
    public static extern DependencyProperty BackgroundSizingProperty { [MethodImpl] get; }

    /// <summary>Identifies the RowSpacing dependency property.</summary>
    /// <returns>The identifier for the RowSpacing dependency property.</returns>
    public static extern DependencyProperty RowSpacingProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColumnSpacing dependency property.</summary>
    /// <returns>The identifier for the ColumnSpacing dependency property.</returns>
    public static extern DependencyProperty ColumnSpacingProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the Grid.Row XAML attached property.</summary>
    /// <returns>The identifier for the Grid.Row XAML attached property.</returns>
    public static extern DependencyProperty RowProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Grid.Row XAML attached property from the specified FrameworkElement.</summary>
    /// <param name="element">The element from which to read the property value.</param>
    /// <returns>The value of the Grid.Row XAML attached property on the target element.</returns>
    [MethodImpl]
    public static extern int GetRow(FrameworkElement element);

    /// <summary>Sets the value of the Grid.Row XAML attached property on the specified FrameworkElement.</summary>
    /// <param name="element">The target element on which to set the Grid.Row XAML attached property.</param>
    /// <param name="value">The property value to set.</param>
    [MethodImpl]
    public static extern void SetRow(FrameworkElement element, int value);

    /// <summary>Identifies the Grid.Column XAML attached property.</summary>
    /// <returns>The identifier for the Grid.Column XAML attached property.</returns>
    public static extern DependencyProperty ColumnProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Grid.Column XAML attached property from the specified FrameworkElement.</summary>
    /// <param name="element">The element from which to read the property value.</param>
    /// <returns>The value of the Grid.Column XAML attached property on the target element. This is a zero-based index.</returns>
    [MethodImpl]
    public static extern int GetColumn(FrameworkElement element);

    /// <summary>Sets the value of the Grid.Column XAML attached property on the specified FrameworkElement.</summary>
    /// <param name="element">The target element on which to set the Grid.Column XAML attached property.</param>
    /// <param name="value">The property value to set.</param>
    [MethodImpl]
    public static extern void SetColumn(FrameworkElement element, int value);

    /// <summary>Identifies the Grid.RowSpan XAML attached property.</summary>
    /// <returns>The identifier for the Grid.RowSpan XAML attached property.</returns>
    public static extern DependencyProperty RowSpanProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Grid.RowSpan XAML attached property from the specified FrameworkElement.</summary>
    /// <param name="element">The element from which to read the property value.</param>
    /// <returns>The value of the Grid.RowSpan XAML attached property on the target element.</returns>
    [MethodImpl]
    public static extern int GetRowSpan(FrameworkElement element);

    /// <summary>Sets the value of the Grid.RowSpan XAML attached property on the specified FrameworkElement.</summary>
    /// <param name="element">The target element on which to set the Grid.RowSpan XAML attached property.</param>
    /// <param name="value">The property value to set.</param>
    [MethodImpl]
    public static extern void SetRowSpan(FrameworkElement element, int value);

    /// <summary>Identifies the Grid.ColumnSpan XAML attached property.</summary>
    /// <returns>The identifier for the Grid.ColumnSpan XAML attached property.</returns>
    public static extern DependencyProperty ColumnSpanProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Grid.ColumnSpan XAML attached property from the specified FrameworkElement.</summary>
    /// <param name="element">The element from which to read the property value.</param>
    /// <returns>The value of the Grid.ColumnSpan XAML attached property on the target element.</returns>
    [MethodImpl]
    public static extern int GetColumnSpan(FrameworkElement element);

    /// <summary>Sets the value of the Grid.ColumnSpan XAML attached property on the specified FrameworkElement.</summary>
    /// <param name="element">The element on which to set the Grid.ColumnSpan XAML attached property.</param>
    /// <param name="value">The property value to set.</param>
    [MethodImpl]
    public static extern void SetColumnSpan(FrameworkElement element, int value);
  }
}
