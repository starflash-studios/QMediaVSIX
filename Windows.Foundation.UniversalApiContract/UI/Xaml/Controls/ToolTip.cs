// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToolTip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that creates a pop-up window that displays information for an element in the UI.</summary>
  [Composable(typeof (IToolTipFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IToolTipStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IToolTipStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public class ToolTip : ContentControl, IToolTip, IToolTip2
  {
    /// <summary>Initializes a new instance of the ToolTip class.</summary>
    [MethodImpl]
    public extern ToolTip();

    /// <summary>Gets or sets the horizontal distance between the target origin and the pop-up alignment point.</summary>
    /// <returns>The horizontal distance between the target origin and the pop-up alignment point. The default is 0.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the ToolTip is visible.</summary>
    /// <returns>**true** if the ToolTip is visible; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how a ToolTip is positioned in relation to the placement target element.</summary>
    /// <returns>One of the PlacementMode values.</returns>
    public extern PlacementMode Placement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the visual element or control that the tool tip should be positioned in relation to when opened by the ToolTipService.</summary>
    /// <returns>The visual element or control that the tool tip is positioned in relation to when opened by the ToolTipService. The default is **null**.</returns>
    public extern UIElement PlacementTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical distance between the target origin and the pop-up alignment point.</summary>
    /// <returns>The vertical distance between the target origin and the pop-up alignment point. The default is 0.</returns>
    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as **TemplateBinding** sources when defining templates for a ToolTip.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern ToolTipTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Occurs when a ToolTip is closed and is no longer visible.</summary>
    public extern event RoutedEventHandler Closed;

    /// <summary>Occurs when a ToolTip becomes visible.</summary>
    public extern event RoutedEventHandler Opened;

    /// <summary>Gets or sets the rectangular area that the tooltip should be positioned in relation to when opened by the ToolTipService. If space allows, the open tooltip will not occlude the area defined by its PlacementRect.</summary>
    /// <returns>The rectangular area that the tooltip is positioned in relation to when opened by the ToolTipService. The default is **null**.</returns>
    public extern IReference<Rect> PlacementRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the PlacementRect dependency property.</summary>
    /// <returns>The identifier for the PlacementRect dependency property.</returns>
    public static extern DependencyProperty PlacementRectProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalOffset  dependency property.</summary>
    /// <returns>The identifier for the HorizontalOffset  dependency property.</returns>
    public static extern DependencyProperty HorizontalOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsOpen  dependency property.</summary>
    /// <returns>The identifier for the IsOpen  dependency property.</returns>
    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the Placement dependency property.</summary>
    /// <returns>The identifier for the Placement dependency property.</returns>
    public static extern DependencyProperty PlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlacementTarget dependency property.</summary>
    /// <returns>The identifier for the PlacementTarget dependency property.</returns>
    public static extern DependencyProperty PlacementTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalOffset  dependency property.</summary>
    /// <returns>The identifier for the VerticalOffset  dependency property.</returns>
    public static extern DependencyProperty VerticalOffsetProperty { [MethodImpl] get; }
  }
}
