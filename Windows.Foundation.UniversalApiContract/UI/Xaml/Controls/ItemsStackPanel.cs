// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsStackPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Arranges child elements of an ItemsControl into a single line that can be oriented horizontally or vertically. Supports pixel-based UI virtualization and grouped layouts.</summary>
  [Static(typeof (IItemsStackPanelStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IItemsStackPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ItemsStackPanel : Panel, IItemsStackPanel, IItemsStackPanel2
  {
    /// <summary>Initializes a new instance of the ItemsStackPanel class.</summary>
    [MethodImpl]
    public extern ItemsStackPanel();

    /// <summary>Gets or sets the amount of space around a group.</summary>
    /// <returns>The amount of space around a group as a Thickness value. Thickness is a structure that stores dimension values using pixel measures. The default is a uniform Thickness of 0.</returns>
    public extern Thickness GroupPadding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the dimension by which child elements are stacked.</summary>
    /// <returns>One of the enumeration values that specifies the orientation of child elements. The default is **Vertical**.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the index in the data collection of the first item in the cache.</summary>
    /// <returns>The index in the data collection of the first item in the cache. The default is -1.</returns>
    public extern int FirstCacheIndex { [MethodImpl] get; }

    /// <summary>Gets the index in the data collection of the first item on the screen. Partially visible items are considered to be on screen.</summary>
    /// <returns>The index in the data collection of the first item on the screen. The default is -1.</returns>
    public extern int FirstVisibleIndex { [MethodImpl] get; }

    /// <summary>Gets the index in the data collection of the last item on the screen. Partially visible items are considered to be on screen.</summary>
    /// <returns>The index in the data collection of the last item on the screen. The default is -1.</returns>
    public extern int LastVisibleIndex { [MethodImpl] get; }

    /// <summary>Gets the index in the data collection of the last item in the cache.</summary>
    /// <returns>The index in the data collection of the last item in the cache. The default is -1.</returns>
    public extern int LastCacheIndex { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether items are panning forward or backward, or aren't panning.</summary>
    /// <returns>An enumeration value that indicates whether the items are panning **Forward** or **Backward**, or **None** if the items are not panning.</returns>
    public extern PanelScrollingDirection ScrollingDirection { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies where group headers are positioned in relation to the group.</summary>
    /// <returns>An enumeration value that specifies where group headers are positioned in relation to the group. The default is **Top**.</returns>
    public extern GroupHeaderPlacement GroupHeaderPlacement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies scrolling behavior when the ItemsSource is updated.</summary>
    /// <returns>A value of the enumeration. The default is **KeepItemsInView**.</returns>
    public extern ItemsUpdatingScrollMode ItemsUpdatingScrollMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size of the buffers for items outside the viewport, in multiples of the viewport size.</summary>
    /// <returns>The size of the buffers for items outside the viewport, in multiples of the viewport size. The default is 4.0.</returns>
    public extern double CacheLength { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether a group header moves with the group when the group is panned vertically.</summary>
    /// <returns>**true** if the group header moves with the group when the group is panned vertically; otherwise, **false**. The default is **true**.</returns>
    public extern bool AreStickyGroupHeadersEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the AreStickyGroupHeadersEnabled dependency property.</summary>
    /// <returns>The identifier for the AreStickyGroupHeadersEnabled dependency property.</returns>
    public static extern DependencyProperty AreStickyGroupHeadersEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the GroupPadding dependency property.</summary>
    /// <returns>The identifier for the GroupPadding dependency property.</returns>
    public static extern DependencyProperty GroupPaddingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the GroupHeaderPlacement dependency property.</summary>
    /// <returns>The identifier for the GroupHeaderPlacement dependency property.</returns>
    public static extern DependencyProperty GroupHeaderPlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the CacheLength dependency property.</summary>
    /// <returns>The identifier for the CacheLength dependency property.</returns>
    public static extern DependencyProperty CacheLengthProperty { [MethodImpl] get; }
  }
}
