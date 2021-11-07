// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Slider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that lets the user select from a range of values by moving a Thumb control along a track.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ISliderFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISliderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISliderStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Slider : RangeBase, ISlider, ISlider2
  {
    /// <summary>Initializes a new instance of the Slider class.</summary>
    [MethodImpl]
    public extern Slider();

    /// <summary>Gets or sets the value of the Slider while the user is interacting with it, before the value is snapped to either the tick or step value. The value the Slider snaps to is specified by the SnapsTo property.</summary>
    /// <returns>A temporary value.</returns>
    public extern double IntermediateValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value part of a value range that steps should be created for.</summary>
    /// <returns>The value part of a value range that steps should be created for.</returns>
    public extern double StepFrequency { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the Slider conforms the thumb position to its steps or tick marks.</summary>
    /// <returns>An enumeration value that specifies whether the Slider snaps to steps or tick marks. The default is **StepValues**.</returns>
    public extern SliderSnapsTo SnapsTo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the increment of the value range that ticks should be created for.</summary>
    /// <returns>The increment to create tick marks for. The default is 0.0.</returns>
    public extern double TickFrequency { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates where to draw tick marks in relation to the track.</summary>
    /// <returns>An enumeration value that specifies where to draw tick marks in relation to the track. The default is **Inline**.</returns>
    public extern TickPlacement TickPlacement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the orientation of a Slider.</summary>
    /// <returns>One of the Orientation values. The default is **Horizontal**.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the direction of increasing value.</summary>
    /// <returns>**true** if the direction of increasing value is to the left for a horizontal slider or down for a vertical slider; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsDirectionReversed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether the slider value is shown in a tool tip for the Thumb component of the Slider.</summary>
    /// <returns>**True** if a tool tip is shown for the Thumb component; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsThumbToolTipEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the converter logic that converts the range value of the Slider into tool tip content.</summary>
    /// <returns>A converter implementation.</returns>
    public extern IValueConverter ThumbToolTipValueConverter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content for the control's header.</summary>
    /// <returns>The content of the control's header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the control's header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the IntermediateValue dependency property.</summary>
    /// <returns>The identifier for the IntermediateValue dependency property.</returns>
    public static extern DependencyProperty IntermediateValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the StepFrequency dependency property.</summary>
    /// <returns>The identifier for the StepFrequency dependency property.</returns>
    public static extern DependencyProperty StepFrequencyProperty { [MethodImpl] get; }

    /// <summary>Identifies the SnapsTo dependency property.</summary>
    /// <returns>The identifier for the SnapsTo dependency property.</returns>
    public static extern DependencyProperty SnapsToProperty { [MethodImpl] get; }

    /// <summary>Identifies the TickFrequency dependency property.</summary>
    /// <returns>The identifier for the TickFrequency dependency property.</returns>
    public static extern DependencyProperty TickFrequencyProperty { [MethodImpl] get; }

    /// <summary>Identifies the TickPlacement dependency property.</summary>
    /// <returns>The identifier for the TickPlacement dependency property.</returns>
    public static extern DependencyProperty TickPlacementProperty { [MethodImpl] get; }

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsDirectionReversed dependency property.</summary>
    /// <returns>The identifier for the IsDirectionReversed dependency property.</returns>
    public static extern DependencyProperty IsDirectionReversedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsThumbToolTipEnabled dependency property.</summary>
    /// <returns>The identifier for the IsThumbToolTipEnabled dependency property.</returns>
    public static extern DependencyProperty IsThumbToolTipEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ThumbToolTipValueConverter dependency property.</summary>
    /// <returns>The identifier for the ThumbToolTipValueConverter dependency property.</returns>
    public static extern DependencyProperty ThumbToolTipValueConverterProperty { [MethodImpl] get; }
  }
}
