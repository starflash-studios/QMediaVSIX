// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Specifies where items are placed in a control, usually an ItemsControl.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IItemsPresenterStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IItemsPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ItemsPresenter : 
    FrameworkElement,
    IItemsPresenter,
    IItemsPresenter2,
    IScrollSnapPointsInfo
  {
    /// <summary>Initializes a new instance of the ItemsPresenter class.</summary>
    [MethodImpl]
    public extern ItemsPresenter();

    /// <summary>Gets or sets the content for the items header.</summary>
    /// <returns>The content of the items header. The default value is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the items header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the header of an ItemsPresenter.</summary>
    /// <returns>The collection of Transition style elements that apply to the header of an ItemsPresenter.</returns>
    public extern TransitionCollection HeaderTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance between the ItemsPresenter and its child objects.</summary>
    /// <returns>The dimensions of the space between the presenter and its children as a Thickness value. Thickness is a structure that stores dimension values using pixel measures.</returns>
    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content for the items footer.</summary>
    /// <returns>The content of the items footer. The default is **null**.</returns>
    public extern object Footer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the items header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate FooterTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the footer of an ItemsPresenter.</summary>
    /// <returns>The collection of Transition style elements that apply to the footer of an ItemsPresenter.</returns>
    public extern TransitionCollection FooterTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the horizontal snap points for the ItemsPresenter are equidistant from each other.</summary>
    /// <returns>**True** if the horizontal snap points for the ItemsPresenter are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreHorizontalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the vertical snap points for the ItemsPresenter are equidistant from each other.</summary>
    /// <returns>**True** if the vertical snap points for the ItemsPresenter are equidistant from each other; otherwise, **false**.</returns>
    public extern bool AreVerticalSnapPointsRegular { [MethodImpl] get; }

    /// <summary>Occurs when the horizontal snap points change.</summary>
    public extern event EventHandler<object> HorizontalSnapPointsChanged;

    /// <summary>Occurs when the vertical snap points change.</summary>
    public extern event EventHandler<object> VerticalSnapPointsChanged;

    /// <summary>Returns a read-only collection of numbers that represent the snap points for the specified orientation.</summary>
    /// <param name="orientation">The orientation of the requested snap points.</param>
    /// <param name="alignment">The alignment used by the caller when applying the requested snap points.</param>
    /// <returns>A read-only collection of numbers that represent the snap points for the specified orientation, or an empty collection when no snap points are present.</returns>
    [MethodImpl]
    public extern IVectorView<float> GetIrregularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment);

    /// <summary>Returns an original offset and interval for equidistant snap points for the specified orientation.</summary>
    /// <param name="orientation">The orientation of the requested snap points.</param>
    /// <param name="alignment">The alignment used by the caller when applying the requested snap points.</param>
    /// <param name="offset">The offset of the first snap point.</param>
    /// <returns>The interval between equidistant snap points for the specified orientation or 0 when no snap points are present.</returns>
    [MethodImpl]
    public extern float GetRegularSnapPoints(
      Orientation orientation,
      SnapPointsAlignment alignment,
      out float offset);

    /// <summary>Identifies the Footer dependency property.</summary>
    /// <returns>The identifier for the Footer dependency property.</returns>
    public static extern DependencyProperty FooterProperty { [MethodImpl] get; }

    /// <summary>Identifies the FooterTemplate dependency property.</summary>
    /// <returns>The identifier for the FooterTemplate dependency property.</returns>
    public static extern DependencyProperty FooterTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the FooterTransitions dependency property.</summary>
    /// <returns>The identifier for the FooterTransitions dependency property.</returns>
    public static extern DependencyProperty FooterTransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTransitions dependency property.</summary>
    /// <returns>The identifier for the HeaderTransitions dependency property.</returns>
    public static extern DependencyProperty HeaderTransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Padding dependency property.</summary>
    /// <returns>The identifier for the Padding dependency property.</returns>
    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }
  }
}
