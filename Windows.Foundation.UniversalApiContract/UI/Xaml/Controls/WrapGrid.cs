// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WrapGrid
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Positions child elements sequentially from left to right or top to bottom. When elements extend beyond the container edge, elements are positioned in the next row or column. Can only be used to display items in an ItemsControl. See Remarks.</summary>
  [Static(typeof (IWrapGridStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class WrapGrid : OrientedVirtualizingPanel, IWrapGrid
  {
    /// <summary>Initializes a new instance of the WrapGrid class.</summary>
    [MethodImpl]
    public extern WrapGrid();

    /// <summary>Gets or sets the width of the layout area for each item that is contained in a WrapGrid.</summary>
    /// <returns>The width of the layout area for each item that is contained in a WrapGrid. The default is Double.NaN, which results in the "Auto" layout behavior.</returns>
    public extern double ItemWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the height of the layout area for each item that is contained in a WrapGrid.</summary>
    /// <returns>The height of the layout area for each item that is contained in a WrapGrid. The default is Double.NaN, which results in the "Auto" layout behavior.</returns>
    public extern double ItemHeight { [MethodImpl] get; [MethodImpl] set; }

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
    /// <returns>The maximum rows or columns that this WrapGrid should present before it introduces wrapping to the layout. The default is -1, which is a special value that indicates no maximum.</returns>
    public extern int MaximumRowsOrColumns { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ItemWidth dependency property.</summary>
    /// <returns>The identifier for the ItemWidth dependency property.</returns>
    public static extern DependencyProperty ItemWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemHeight dependency property.</summary>
    /// <returns>The identifier for the ItemHeight dependency property.</returns>
    public static extern DependencyProperty ItemHeightProperty { [MethodImpl] get; }

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
  }
}
