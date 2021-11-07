// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.RepeatButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a control that raises its Click event repeatedly when it is pressed and held.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRepeatButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class RepeatButton : ButtonBase, IRepeatButton
  {
    /// <summary>Initializes a new instance of the RepeatButton class.</summary>
    [MethodImpl]
    public extern RepeatButton();

    /// <summary>Gets or sets the time, in milliseconds, that the RepeatButton waits when it is pressed before it starts repeating the click action.</summary>
    /// <returns>The time, in milliseconds, that the RepeatButton waits when it is pressed before it starts repeating the click action. The default is 250.</returns>
    public extern int Delay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time, in milliseconds, between repetitions of the click action, as soon as repeating starts.</summary>
    /// <returns>The time, in milliseconds, between repetitions of the click action, as soon as repeating starts. The default is 250.</returns>
    public extern int Interval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Delay dependency property.</summary>
    /// <returns>The identifier for the Delay dependency property.</returns>
    public static extern DependencyProperty DelayProperty { [MethodImpl] get; }

    /// <summary>Identifies the Interval dependency property.</summary>
    /// <returns>The identifier for the Interval dependency property.</returns>
    public static extern DependencyProperty IntervalProperty { [MethodImpl] get; }
  }
}
