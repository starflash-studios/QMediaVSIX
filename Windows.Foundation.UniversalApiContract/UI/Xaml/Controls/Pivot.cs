// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Pivot
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that provides quick navigation of views within an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPivotStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IPivotStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPivotStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IPivotFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class Pivot : ItemsControl, IPivot, IPivot2, IPivot3
  {
    /// <summary>Initializes a new instance of the Pivot type.</summary>
    [MethodImpl]
    public extern Pivot();

    /// <summary>Gets or sets the title to be optionally set above the headers.</summary>
    /// <returns>Returns String.</returns>
    public extern object Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the title template used for displaying the title above the headers area.</summary>
    /// <returns>The template that specifies the visualization of the title object.</returns>
    public extern DataTemplate TitleTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the template for the Header property of PivotItem children.</summary>
    /// <returns>The template for the Header property of PivotItem children.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the zero-based index of the currently selected item in the Pivot.</summary>
    /// <returns>The zero-based index of the currently selected item.</returns>
    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the currently selected item in the Pivot.</summary>
    /// <returns>The currently selected PivotItem or, if the Pivot is bound to data, the data item set as the Content of the currently selected PivotItem.</returns>
    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the Pivot is locked to show only the current PivotItem. While the Pivot is locked, all other PivotItems are removed, and the user cannot navigate to them. An example of locking is when the email list is put into a multi-select mode.</summary>
    /// <returns>**true** if the Pivot is locked; **false** if it is unlocked. The default is **false**.</returns>
    public extern bool IsLocked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the currently selected item changes.</summary>
    public extern event SelectionChangedEventHandler SelectionChanged;

    /// <summary>Event for offering an opportunity to dynamically load or change the content of a pivot item before it is displayed.</summary>
    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoading;

    /// <summary>Event for indicating that an item has fully loaded.</summary>
    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemLoaded;

    /// <summary>Event for offering an opportunity to dynamically load, change, or remove the content of a pivot item as it is removed.</summary>
    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloading;

    /// <summary>Event for notifying that the pivot item has been completely unloaded from the visual pivot.</summary>
    public extern event TypedEventHandler<Pivot, PivotItemEventArgs> PivotItemUnloaded;

    /// <summary>Gets or sets the content for the header on the control's left side.</summary>
    /// <returns>The content of the header on the control's left side. The default is **null**.</returns>
    public extern object LeftHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the template for the header on the control's left side.</summary>
    /// <returns>The template for the header on the control's left side.</returns>
    public extern DataTemplate LeftHeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content for the header on the control's right side.</summary>
    /// <returns>The content of the header on the control's right side. The default is **null**.</returns>
    public extern object RightHeader { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the template for the header on the control's right side.</summary>
    /// <returns>The template for the header on the control's right side.</returns>
    public extern DataTemplate RightHeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the style of focus visual used for pivot header items.</summary>
    /// <returns>A value of the enumeration that specifies the style of focus visual used for pivot header items. The default is **SelectedItemHeader**.</returns>
    public extern PivotHeaderFocusVisualPlacement HeaderFocusVisualPlacement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the selected header moves to the first position.</summary>
    /// <returns>**true** if the selected header moves to the first position; **false** if headers always keep the same position. The default is **true**.</returns>
    public extern bool IsHeaderItemsCarouselEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the HeaderFocusVisualPlacement dependency property.</summary>
    /// <returns>The identifier for the HeaderFocusVisualPlacement dependency property.</returns>
    public static extern DependencyProperty HeaderFocusVisualPlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHeaderItemsCarouselEnabled dependency property.</summary>
    /// <returns>The identifier for the IsHeaderItemsCarouselEnabled dependency property.</returns>
    public static extern DependencyProperty IsHeaderItemsCarouselEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the LeftHeader dependency property.</summary>
    /// <returns>The identifier for the LeftHeader dependency property.</returns>
    public static extern DependencyProperty LeftHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the LeftHeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the LeftHeaderTemplate dependency property.</returns>
    public static extern DependencyProperty LeftHeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the RightHeader dependency property.</summary>
    /// <returns>The identifier for the RightHeader dependency property.</returns>
    public static extern DependencyProperty RightHeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the RightHeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the RightHeaderTemplate dependency property.</returns>
    public static extern DependencyProperty RightHeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the Title dependency property.</summary>
    /// <returns>The identifier for the Title dependency property.</returns>
    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    /// <summary>Identifies the TitleTemplate dependency property.</summary>
    /// <returns>The identifier for the TitleTemplate dependency property.</returns>
    public static extern DependencyProperty TitleTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedIndex dependency property.</summary>
    /// <returns>The identifier for the SelectedIndex dependency property.</returns>
    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedItem dependency property.</summary>
    /// <returns>The identifier for the SelectedItem dependency property.</returns>
    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsLocked dependency property.</summary>
    /// <returns>The identifier for the IsLocked dependency property.</returns>
    public static extern DependencyProperty IsLockedProperty { [MethodImpl] get; }

    /// <summary>Identifies the SlideInAnimationGroup XAML attached property.</summary>
    /// <returns>The identifier for the SlideInAnimationGroup XAML attached property.</returns>
    public static extern DependencyProperty SlideInAnimationGroupProperty { [MethodImpl] get; }

    /// <summary>Retrieves the animation group that a FrameworkElement belongs to.</summary>
    /// <param name="element">The FrameworkElement within the Pivot (such as a TextBlock ) that is to be animated.</param>
    /// <returns>The slide-in animation group that this FrameworkElement belongs to.</returns>
    [MethodImpl]
    public static extern PivotSlideInAnimationGroup GetSlideInAnimationGroup(
      FrameworkElement element);

    /// <summary>Assigns a FrameworkElement to a slide-in animation group so that element is animated at the same time as the other members of that group.</summary>
    /// <param name="element">The FrameworkElement within the Pivot (such as a TextBlock ) that is to be animated.</param>
    /// <param name="value">The slide-in animation group that this FrameworkElement belongs to. This element will be animated with all other elements that share the same group number.</param>
    [MethodImpl]
    public static extern void SetSlideInAnimationGroup(
      FrameworkElement element,
      PivotSlideInAnimationGroup value);
  }
}
