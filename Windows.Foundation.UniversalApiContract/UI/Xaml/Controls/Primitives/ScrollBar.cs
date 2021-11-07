// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ScrollBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a control that provides a scroll bar that has a sliding Thumb whose position corresponds to a value.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IScrollBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class ScrollBar : RangeBase, IScrollBar
  {
    /// <summary>Initializes a new instance of the ScrollBar class.</summary>
    [MethodImpl]
    public extern ScrollBar();

    /// <summary>Gets or sets a value that indicates whether the ScrollBar is displayed horizontally or vertically.</summary>
    /// <returns>An Orientation enumeration value that defines whether the ScrollBar is displayed horizontally or vertically. The default is **Horizontal**. Specific control templates might change this value, which would cause the templated value to be the apparent runtime default.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount of the scrollable content that is currently visible.</summary>
    /// <returns>The amount of the scrollable content that is currently visible. The default is 0.</returns>
    public extern double ViewportSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that results in different input indicator modes for the ScrollBar.</summary>
    /// <returns>A value of the enumeration. The default is **None**.</returns>
    public extern ScrollingIndicatorMode IndicatorMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs one or more times as content scrolls in a ScrollBar when the user moves the Thumb by using the mouse.</summary>
    public extern event ScrollEventHandler Scroll;

    /// <summary>Identifies the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    /// <summary>Identifies the ViewportSize dependency property.</summary>
    /// <returns>The identifier for the ViewportSize dependency property.</returns>
    public static extern DependencyProperty ViewportSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IndicatorMode dependency property.</summary>
    /// <returns>The identifier for the IndicatorMode dependency property.</returns>
    public static extern DependencyProperty IndicatorModeProperty { [MethodImpl] get; }
  }
}
