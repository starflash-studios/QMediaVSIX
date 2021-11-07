// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.Storyboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Controls animations with a timeline, and provides object and property targeting information for its child animations.</summary>
  [ContentProperty(Name = "Children")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IStoryboardStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Storyboard : Timeline, IStoryboard
  {
    /// <summary>Initializes a new instance of the Storyboard class.</summary>
    [MethodImpl]
    public extern Storyboard();

    /// <summary>Gets the collection of child Timeline objects.</summary>
    /// <returns>The collection of child Timeline objects. The default is an empty collection.</returns>
    public extern TimelineCollection Children { [MethodImpl] get; }

    [MethodImpl]
    public extern void Seek(TimeSpan offset);

    /// <summary>Stops the storyboard.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Initiates the set of animations associated with the storyboard.</summary>
    [MethodImpl]
    public extern void Begin();

    /// <summary>Pauses the animation clock associated with the storyboard.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Resumes the animation clock, or run-time state, associated with the storyboard.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>Gets the clock state of the Storyboard.</summary>
    /// <returns>One of the enumeration values. Can be: **Active**, **Filling**, or **Stopped**.</returns>
    [MethodImpl]
    public extern ClockState GetCurrentState();

    /// <summary>Gets the current animation clock time of the Storyboard.</summary>
    /// <returns>The current animation time of the Storyboard per the running animation clock, or **null** if the animation clock is **Stopped**.</returns>
    [MethodImpl]
    public extern TimeSpan GetCurrentTime();

    [MethodImpl]
    public extern void SeekAlignedToLastTick(TimeSpan offset);

    /// <summary>Advances the current time of the storyboard's clock to the end of its active period.</summary>
    [MethodImpl]
    public extern void SkipToFill();

    /// <summary>Identifies the Storyboard.TargetProperty XAML attached property.</summary>
    /// <returns>The identifier for the Storyboard.TargetProperty XAML attached property.</returns>
    public static extern DependencyProperty TargetPropertyProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Storyboard.TargetProperty XAML attached property from a target element.</summary>
    /// <param name="element">The target element from which to get the value.</param>
    /// <returns>The Storyboard.TargetProperty value of the target element.</returns>
    [MethodImpl]
    public static extern string GetTargetProperty(Timeline element);

    /// <summary>Sets the value of the Storyboard.TargetProperty XAML attached property for a target element.</summary>
    /// <param name="element">The target element for which to set the value.</param>
    /// <param name="path">The Storyboard.TargetProperty value of the target element to set. This specifies a qualification path that targets the dependency property where the animation applies. See Remarks.</param>
    [MethodImpl]
    public static extern void SetTargetProperty(Timeline element, string path);

    /// <summary>Identifies the Storyboard.TargetName XAML attached property.</summary>
    /// <returns>The identifier for the Storyboard.TargetName XAML attached property.</returns>
    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Storyboard.TargetName XAML attached property from a target element.</summary>
    /// <param name="element">The target element from which to get the value.</param>
    /// <returns>The Storyboard.TargetName value of the target element.</returns>
    [MethodImpl]
    public static extern string GetTargetName(Timeline element);

    /// <summary>Sets the value of the Storyboard.TargetName XAML attached property for a target element.</summary>
    /// <param name="element">The target element to set the value for.</param>
    /// <param name="name">The Storyboard.TargetName value of the target element to set. This should correspond to an existing Name or **x:Name** value on the UI element that the animation targets.</param>
    [MethodImpl]
    public static extern void SetTargetName(Timeline element, string name);

    /// <summary>Causes the specified Timeline to target the specified object.</summary>
    /// <param name="timeline">The timeline that targets the specified dependency object.</param>
    /// <param name="target">The actual instance of the object to target.</param>
    [MethodImpl]
    public static extern void SetTarget(Timeline timeline, DependencyObject target);
  }
}
