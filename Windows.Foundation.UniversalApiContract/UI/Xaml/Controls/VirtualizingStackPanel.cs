// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VirtualizingStackPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Arranges and virtualizes content on a single line that is oriented either horizontally or vertically. Can only be used to display items in an ItemsControl.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IVirtualizingStackPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VirtualizingStackPanel : 
    OrientedVirtualizingPanel,
    IVirtualizingStackPanel,
    IVirtualizingStackPanelOverrides
  {
    /// <summary>Initializes a new instance of the VirtualizingStackPanel class.</summary>
    [MethodImpl]
    public extern VirtualizingStackPanel();

    /// <summary>Gets or sets a value that indicates whether the generated snap points used for panning in the VirtualizingStackPanel are equidistant from each other.</summary>
    /// <returns>**true** if the snap points in the VirtualizingStackPanel are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreScrollSnapPointsRegular { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that describes the horizontal or vertical orientation of stacked content.</summary>
    /// <returns>The Orientation of child content, as a value of the enumeration. The default is **Vertical**.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when an item that is hosted by the VirtualizingStackPanel is re-virtualized.</summary>
    public extern event CleanUpVirtualizedItemEventHandler CleanUpVirtualizedItemEvent;

    [MethodImpl]
    extern void IVirtualizingStackPanelOverrides.OnCleanUpVirtualizedItem(
      CleanUpVirtualizedItemEventArgs e);

    /// <summary>Identifies the AreScrollSnapPointsRegular dependency property.</summary>
    /// <returns>The identifier for the AreScrollSnapPointsRegular dependency property.</returns>
    public static extern DependencyProperty AreScrollSnapPointsRegularProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the VirtualizingStackPanel.VirtualizationMode XAML attached property.</summary>
    /// <returns>The identifier for the VirtualizingStackPanel.VirtualizationMode XAML attached property.</returns>
    public static extern DependencyProperty VirtualizationModeProperty { [MethodImpl] get; }

    /// <summary>Gets the VirtualizingStackPanel.VirtualizationMode XAML attached property value for the specified target element.</summary>
    /// <param name="element">The object from which the VirtualizationMode is read.</param>
    /// <returns>One of the enumeration values that specifies whether the object uses container recycling.</returns>
    [MethodImpl]
    public static extern VirtualizationMode GetVirtualizationMode(
      DependencyObject element);

    /// <summary>Sets the VirtualizingStackPanel.VirtualizationMode XAML attached property on the specified target element.</summary>
    /// <param name="element">The target element.</param>
    /// <param name="value">One of the enumeration values that specifies whether *element* uses container recycling.</param>
    [MethodImpl]
    public static extern void SetVirtualizationMode(
      DependencyObject element,
      VirtualizationMode value);

    /// <summary>Identifies the **VirtualizingStackPanel.IsVirtualizing** attached property.</summary>
    /// <returns>The identifier for the **VirtualizingStackPanel.IsVirtualizing** attached property.</returns>
    public static extern DependencyProperty IsVirtualizingProperty { [MethodImpl] get; }

    /// <summary>Gets a value that determines whether an item is currently being virtualized as part of an items set where the ItemsPanel is templated with a VirtualizingStackPanel.</summary>
    /// <param name="o">The object item where you want to determine the current virtualization state.</param>
    /// <returns>**true** if the item specified by *o* is currently virtualizing its content; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsVirtualizing(DependencyObject o);
  }
}
