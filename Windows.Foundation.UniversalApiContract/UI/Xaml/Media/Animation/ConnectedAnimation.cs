// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ConnectedAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents an animation that simultaneously animates the exit of one element and the entrance of another element.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConnectedAnimation : 
    IConnectedAnimation,
    IConnectedAnimation2,
    IConnectedAnimation3
  {
    /// <summary>Occurs when the animation is finished.</summary>
    public extern event TypedEventHandler<ConnectedAnimation, object> Completed;

    /// <summary>Attempts to start the animation.</summary>
    /// <param name="destination">The element that is animated into view.</param>
    /// <returns>**true** if the animation started; **false** if the animation has already been started, if it is no longer active, or if the destination element is the same as the source element.</returns>
    [Overload("TryStart")]
    [MethodImpl]
    public extern bool TryStart(UIElement destination);

    /// <summary>Stops the connected animation.</summary>
    [MethodImpl]
    public extern void Cancel();

    /// <summary>Gets or sets a value that indicates whether the scale component of the connected animation should be used.</summary>
    /// <returns>**true** if the scale component of the connected animation should be used. otherwise, **false**. The default is **true**.</returns>
    public extern bool IsScaleAnimationEnabled { [MethodImpl] get; [MethodImpl] set; }

    [Overload("TryStartWithCoordinatedElements")]
    [MethodImpl]
    public extern bool TryStart(UIElement destination, IIterable<UIElement> coordinatedElements);

    /// <summary>Sets a custom CompositionAnimation to change the motion of a particular part of the connected animation.</summary>
    /// <param name="component">The part of the connected animation to change.</param>
    /// <param name="animation">The animation to use in place of the default one.</param>
    [MethodImpl]
    public extern void SetAnimationComponent(
      ConnectedAnimationComponent component,
      ICompositionAnimationBase animation);

    /// <summary>Gets or sets the configuration that describes the type of connected animation to play.</summary>
    /// <returns>A configuration that describes the type of connected animation to play.</returns>
    public extern ConnectedAnimationConfiguration Configuration { [MethodImpl] get; [MethodImpl] set; }
  }
}
