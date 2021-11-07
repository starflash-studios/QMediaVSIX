// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.Timeline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Defines a duration and other behavior properties for a Windows Runtime animation. Timeline is the base class for Storyboard and all the Windows Runtime animation types, including those from the animation library and those used for custom animations in visual states or page-level XAML.</summary>
  [Composable(typeof (ITimelineFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITimelineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class Timeline : DependencyObject, ITimeline
  {
    /// <summary>Provides base class initialization behavior for Timeline -derived classes.</summary>
    [MethodImpl]
    protected extern Timeline();

    /// <summary>Gets or sets a value that indicates whether the timeline plays in reverse after it completes a forward iteration.</summary>
    /// <returns>**true** if the timeline plays in reverse at the end of each iteration; otherwise, **false**. The default value is **false**.</returns>
    public extern bool AutoReverse { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time at which this Timeline should begin.</summary>
    /// <returns>The start time of the time line. The default value is zero. </returns>
    public extern IReference<TimeSpan> BeginTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the length of time for which this timeline plays, not counting repetitions.</summary>
    /// <returns>The timeline's simple duration: the amount of time this timeline takes to complete a single forward iteration. The default value is a Duration that evaluates as Automatic.</returns>
    public extern Duration Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rate, relative to its parent, at which time progresses for this Timeline.</summary>
    /// <returns>A finite value greater than 0 that specifies the rate at which time progresses for this timeline, relative to the speed of the timeline's parent. If this timeline is a root timeline, specifies the default timeline speed. The value is expressed as a factor where 1 represents normal speed, 2 is double speed, 0.5 is half speed, and so on. The default value is 1.</returns>
    public extern double SpeedRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how the animation behaves after it reaches the end of its active period.</summary>
    /// <returns>A value that specifies how the timeline behaves after it reaches the end of its active period but its parent is inside its active or fill period. The default value is **HoldEnd**.</returns>
    public extern FillBehavior FillBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the repeating behavior of this timeline.</summary>
    /// <returns>An iteration **Count** that specifies the number of times the timeline should play, a **TimeSpan** value that specifies the total length of this timeline's active period, or the special value **Forever**, which specifies that the timeline should repeat indefinitely. The default value is a RepeatBehavior with a **Count** value of 1, which indicates that the timeline plays once.</returns>
    public extern RepeatBehavior RepeatBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Storyboard object has completed playing.</summary>
    public extern event EventHandler<object> Completed;

    /// <summary>Gets or sets a value that determines whether dependent animations should be permitted to run, throughout the app.</summary>
    /// <returns>**true** if animations can run in the app for dependent animation cases. Otherwise, **false**. The default is **true**.</returns>
    public static extern bool AllowDependentAnimations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the AutoReverse  dependency property.</summary>
    /// <returns>The identifier for the AutoReverse  dependency property.</returns>
    public static extern DependencyProperty AutoReverseProperty { [MethodImpl] get; }

    /// <summary>Identifies the BeginTime  dependency property.</summary>
    /// <returns>The identifier for the BeginTime  dependency property.</returns>
    public static extern DependencyProperty BeginTimeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Duration  dependency property.</summary>
    /// <returns>The identifier for the Duration  dependency property.</returns>
    public static extern DependencyProperty DurationProperty { [MethodImpl] get; }

    /// <summary>Identifies for the SpeedRatio  dependency property.</summary>
    /// <returns>The identifier for the SpeedRatio  dependency property.</returns>
    public static extern DependencyProperty SpeedRatioProperty { [MethodImpl] get; }

    /// <summary>Identifies the FillBehavior  dependency property.</summary>
    /// <returns>The identifier for the FillBehavior  dependency property.</returns>
    public static extern DependencyProperty FillBehaviorProperty { [MethodImpl] get; }

    /// <summary>Identifies the RepeatBehavior  dependency property.</summary>
    /// <returns>The identifier for the RepeatBehavior  dependency property.</returns>
    public static extern DependencyProperty RepeatBehaviorProperty { [MethodImpl] get; }
  }
}
