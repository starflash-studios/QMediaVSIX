// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.RangeBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents an element that has a value within a specific range, such as the ProgressBar, ScrollBar, and Slider controls.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IRangeBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IRangeBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class RangeBase : Control, IRangeBase, IRangeBaseOverrides
  {
    /// <summary>Provides base class initialization behavior for RangeBase -derived classes.</summary>
    [MethodImpl]
    protected extern RangeBase();

    /// <summary>Gets or sets the Minimum possible Value of the range element.</summary>
    /// <returns>Minimum possible Value of the range element. The default is 0.</returns>
    public extern double Minimum { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the highest possible Value of the range element.</summary>
    /// <returns>The highest possible Value of the range element. The default is 1.</returns>
    public extern double Maximum { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Value to be added to or subtracted from the Value of a RangeBase control.</summary>
    /// <returns>Value to add to or subtract from the Value of the RangeBase element. The default is 0.1.</returns>
    public extern double SmallChange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value to be added to or subtracted from the Value of a RangeBase control.</summary>
    /// <returns>Value to add to or subtract from the Value of the RangeBase element. The default is 1.</returns>
    public extern double LargeChange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current setting of the range control, which may be coerced.</summary>
    /// <returns>The current setting of the range control, which may be coerced. The default is 0.</returns>
    public extern double Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the range value changes.</summary>
    public extern event RangeBaseValueChangedEventHandler ValueChanged;

    [MethodImpl]
    extern void IRangeBaseOverrides.OnMinimumChanged(
      double oldMinimum,
      double newMinimum);

    [MethodImpl]
    extern void IRangeBaseOverrides.OnMaximumChanged(
      double oldMaximum,
      double newMaximum);

    [MethodImpl]
    extern void IRangeBaseOverrides.OnValueChanged(
      double oldValue,
      double newValue);

    /// <summary>Identifies the Minimum dependency property.</summary>
    /// <returns>The identifier for the Minimum dependency property.</returns>
    public static extern DependencyProperty MinimumProperty { [MethodImpl] get; }

    /// <summary>Identifies the Maximum dependency property.</summary>
    /// <returns>The identifier for the Maximum dependency property.</returns>
    public static extern DependencyProperty MaximumProperty { [MethodImpl] get; }

    /// <summary>Identifies the SmallChange dependency property.</summary>
    /// <returns>The identifier for the SmallChange dependency property.</returns>
    public static extern DependencyProperty SmallChangeProperty { [MethodImpl] get; }

    /// <summary>Identifies the LargeChange dependency property.</summary>
    /// <returns>The identifier for the LargeChange dependency property.</returns>
    public static extern DependencyProperty LargeChangeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Value dependency property.</summary>
    /// <returns>The identifier for the Value dependency property.</returns>
    public static extern DependencyProperty ValueProperty { [MethodImpl] get; }
  }
}
