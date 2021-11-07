// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VariableSizedWrapGrid
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a grid-style layout panel where each tile/cell can be variable size based on content.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IVariableSizedWrapGridStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VariableSizedWrapGrid : Panel, IVariableSizedWrapGrid
  {
    /// <summary>Initializes a new instance of the VariableSizedWrapGrid class.</summary>
    [MethodImpl]
    public extern VariableSizedWrapGrid();

    /// <summary>Gets or sets the height of the layout area for each item that is contained in a VariableSizedWrapGrid.</summary>
    /// <returns>The height of the layout area for each item that is contained in a VariableSizedWrapGrid. The default is Double.NaN, which results in the "Auto" layout behavior.</returns>
    public extern double ItemHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the layout area for each item that is contained in a VariableSizedWrapGrid.</summary>
    /// <returns>The width of the layout area for each item that is contained in a VariableSizedWrapGrid. The default is Double.NaN, which results in the "Auto" layout behavior.</returns>
    public extern double ItemWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the direction in which child elements are arranged.</summary>
    /// <returns>A value of the enumeration. The default is **Vertical**.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the alignment rules by which child elements are arranged for the horizontal dimension.</summary>
    /// <returns>A value of the enumeration. The default is **Left**.</returns>
    public extern HorizontalAlignment HorizontalChildrenAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the alignment rules by which child elements are arranged for the vertical dimension.</summary>
    /// <returns>A value of the enumeration. The default is **Top**.</returns>
    public extern VerticalAlignment VerticalChildrenAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that influences the wrap point, also accounting for Orientation.</summary>
    /// <returns>The maximum rows or columns that this VariableSizedWrapGrid should present before it introduces wrapping to the layout. The default is -1, which is a special value that indicates no maximum.</returns>
    public extern int MaximumRowsOrColumns { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ItemHeight dependency property.</summary>
    /// <returns>The identifier for the ItemHeight dependency property.</returns>
    public static extern DependencyProperty ItemHeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemWidth dependency property.</summary>
    /// <returns>The identifier for the ItemWidth dependency property.</returns>
    public static extern DependencyProperty ItemWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalChildrenAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalChildrenAlignment dependency property.</returns>
    public static extern DependencyProperty HorizontalChildrenAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalChildrenAlignment dependency property.</summary>
    /// <returns>The identifier for the VerticalChildrenAlignment dependency property.</returns>
    public static extern DependencyProperty VerticalChildrenAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaximumRowsOrColumns dependency property.</summary>
    /// <returns>The identifier for the MaximumRowsOrColumns dependency property.</returns>
    public static extern DependencyProperty MaximumRowsOrColumnsProperty { [MethodImpl] get; }

    /// <summary>Identifies the VariableSizedWrapGrid.RowSpan XAML attached property.</summary>
    /// <returns>The identifier for the VariableSizedWrapGrid.RowSpan XAML attached property.</returns>
    public static extern DependencyProperty RowSpanProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the VariableSizedWrapGrid.RowSpan XAML attached property from a target element.</summary>
    /// <param name="element">The target element.</param>
    /// <returns>The obtained value.</returns>
    [MethodImpl]
    public static extern int GetRowSpan(UIElement element);

    /// <summary>Sets the value of the VariableSizedWrapGrid.RowSpan XAML attached property on a target element.</summary>
    /// <param name="element">The target element.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetRowSpan(UIElement element, int value);

    /// <summary>Identifies the VariableSizedWrapGrid.ColumnSpan XAML attached property.</summary>
    /// <returns>The identifier for the VariableSizedWrapGrid.ColumnSpan XAML attached property.</returns>
    public static extern DependencyProperty ColumnSpanProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the VariableSizedWrapGrid.ColumnSpan XAML attached property from a target element.</summary>
    /// <param name="element">The target element.</param>
    /// <returns>The obtained value.</returns>
    [MethodImpl]
    public static extern int GetColumnSpan(UIElement element);

    /// <summary>Sets the value of the VariableSizedWrapGrid.ColumnSpan XAML attached property on a target element.</summary>
    /// <param name="element">The target element.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetColumnSpan(UIElement element, int value);
  }
}
