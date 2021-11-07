// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a Universal Windows app control containing a customizable and extensible collection of buttons that activate ink-related features in an associated InkCanvas.</summary>
  [Static(typeof (IInkToolbarStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Children")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInkToolbarStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInkToolbarStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class InkToolbar : Control, IInkToolbar, IInkToolbar2, IInkToolbar3
  {
    /// <summary>Initializes a new instance of the InkToolbar class.</summary>
    [MethodImpl]
    public extern InkToolbar();

    /// <summary>Gets or sets the collection of built-in buttons added to the InkToolbar at initialization.</summary>
    /// <returns>The collection of built-in buttons to add to the InkToolbar.</returns>
    public extern InkToolbarInitialControls InitialControls { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of custom buttons displayed on the InkToolbar.</summary>
    /// <returns>A collection of InkToolbar custom buttons.</returns>
    public extern DependencyObjectCollection Children { [MethodImpl] get; }

    /// <summary>Gets or sets the currently selected feature in the "tools" group of the InkToolbar (see remarks).</summary>
    /// <returns>The currently selected feature. By default, this is the first button on the InkToolbar.</returns>
    public extern InkToolbarToolButton ActiveTool { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the InkStroke properties specified through the InkToolbar.</summary>
    /// <returns>The InkStroke properties.</returns>
    public extern InkDrawingAttributes InkDrawingAttributes { [MethodImpl] get; }

    /// <summary>Gets or sets the state of the InkToolbarRulerButton (and associated tool) to on or off.</summary>
    /// <returns>**true** if the ruler button is selected and the ruler is active; otherwise, **false**.</returns>
    public extern bool IsRulerButtonChecked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the InkCanvas control associated with the InkToolbar.</summary>
    /// <returns>The InkCanvas control associated with the InkToolbar.</returns>
    public extern InkCanvas TargetInkCanvas { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the currently selected feature in the RadioButton group of the InkToolbar is changed.</summary>
    public extern event TypedEventHandler<InkToolbar, object> ActiveToolChanged;

    /// <summary>Occurs when any InkDrawingAttributes are changed.</summary>
    public extern event TypedEventHandler<InkToolbar, object> InkDrawingAttributesChanged;

    /// <summary>Occurs when "Erase All  Ink" is selected from the flyout for the InkToolbarEraserButton on the InkToolbar.</summary>
    public extern event TypedEventHandler<InkToolbar, object> EraseAllClicked;

    /// <summary>Occurs when the toggled state of the InkToolbarRulerButton changes.</summary>
    public extern event TypedEventHandler<InkToolbar, object> IsRulerButtonCheckedChanged;

    /// <summary>Retrieves a reference to one of the following objects from the radio button group of the InkToolbar.</summary>
    /// <param name="tool">Indicates the type of InkToolbarToolButton to retrieve.</param>
    /// <returns>The InkToolbarToolButton specified, or **null** if the button has not been added to the InkToolbar.</returns>
    [MethodImpl]
    public extern InkToolbarToolButton GetToolButton(InkToolbarTool tool);

    /// <summary>Retrieves a reference to an InkToolbarToggleButton object from the toggle button group of the InkToolbar.</summary>
    /// <param name="tool">Indicates the type of InkToolbarToggleButton to retrieve.</param>
    /// <returns>The InkToolbarToggleButton specified.</returns>
    [MethodImpl]
    public extern InkToolbarToggleButton GetToggleButton(InkToolbarToggle tool);

    /// <summary>Gets or sets the state of the InkToolbarStencilButton (and associated tool) to on or off.</summary>
    /// <returns>**true** if the stencil button is selected and the stencil is active; otherwise, **false**.</returns>
    public extern bool IsStencilButtonChecked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the location of ink stroke configuration flyout relative to the InkToolbar.</summary>
    /// <returns>The location of the flyout relative to the ink toolbar.</returns>
    public extern InkToolbarButtonFlyoutPlacement ButtonFlyoutPlacement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the orientation of the InkToolbar.</summary>
    /// <returns>The different orientations that ink toolbar can have.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the toggled state of the InkToolbaStencilButton changes.</summary>
    public extern event TypedEventHandler<InkToolbar, InkToolbarIsStencilButtonCheckedChangedEventArgs> IsStencilButtonCheckedChanged;

    /// <summary>Retrieves a reference to an InkToolbarMenuButton object from the menu button group of the InkToolbar.</summary>
    /// <param name="menu">Indicates the type of InkToolbarMenuButton to retrieve.</param>
    /// <returns>The InkToolbarMenuButton specified.</returns>
    [MethodImpl]
    public extern InkToolbarMenuButton GetMenuButton(InkToolbarMenuKind menu);

    /// <summary>Gets or sets the InkPresenter object associated with the InkToolbar.</summary>
    /// <returns>The InkPresenter object associated with the InkToolbar.</returns>
    public extern InkPresenter TargetInkPresenter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TargetInkPresenter dependency property.</summary>
    /// <returns>The identifier for the TargetInkPresenter dependency property.</returns>
    public static extern DependencyProperty TargetInkPresenterProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsStencilButtonChecked dependency property.</summary>
    /// <returns>The identifier for the IsStencilButtonChecked dependency property.</returns>
    public static extern DependencyProperty IsStencilButtonCheckedProperty { [MethodImpl] get; }

    /// <summary>Identifies the ButtonFlyoutPlacement dependency property.</summary>
    /// <returns>
    /// </returns>
    public static extern DependencyProperty ButtonFlyoutPlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the InkToolbar.Orientation dependency property.</summary>
    /// <returns>The identifier for the InkToolbar.Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the InitialControls dependency property.</summary>
    /// <returns>The identifier for the InitialControls dependency property.</returns>
    public static extern DependencyProperty InitialControlsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Children dependency property.</summary>
    /// <returns>The identifier for the Children dependency property.</returns>
    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }

    /// <summary>Identifies the ActiveTool dependency property.</summary>
    /// <returns>The identifier for the ActiveTool dependency property.</returns>
    public static extern DependencyProperty ActiveToolProperty { [MethodImpl] get; }

    /// <summary>Identifies the InkDrawingAttributes dependency property.</summary>
    /// <returns>The identifier for the InkDrawingAttributes dependency property.</returns>
    public static extern DependencyProperty InkDrawingAttributesProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsRulerButtonChecked dependency property.</summary>
    /// <returns>The identifier for the IsRulerButtonChecked dependency property.</returns>
    public static extern DependencyProperty IsRulerButtonCheckedProperty { [MethodImpl] get; }

    /// <summary>Identifies the TargetInkCanvas dependency property.</summary>
    /// <returns>The identifier for the TargetInkCanvas dependency property.</returns>
    public static extern DependencyProperty TargetInkCanvasProperty { [MethodImpl] get; }
  }
}
