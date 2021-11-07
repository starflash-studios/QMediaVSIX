// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ConnectedAnimationService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Represents a service that provides properties and methods to display a ConnectedAnimation.</summary>
  [Static(typeof (IConnectedAnimationServiceStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ConnectedAnimationService : IConnectedAnimationService
  {
    /// <summary>Gets or sets the default time that the animation runs.</summary>
    /// <returns>The default time that the animation runs.</returns>
    public extern TimeSpan DefaultDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the default CompositionEasingFunction used by the animation.</summary>
    /// <returns>The default CompositionEasingFunction used by the animation.</returns>
    public extern CompositionEasingFunction DefaultEasingFunction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a connected animation that's associated with the specified key and source element.</summary>
    /// <param name="key">The key for the animation.</param>
    /// <param name="source">The element that is animated out of view.</param>
    /// <returns>The animation with the specified key.</returns>
    [MethodImpl]
    public extern ConnectedAnimation PrepareToAnimate(
      string key,
      UIElement source);

    /// <summary>Returns the animation with the specified key.</summary>
    /// <param name="key">The key for the animation.</param>
    /// <returns>The animation with the specified key; or **null** if no animation has been prepared for that key, or if the animation is no longer active.</returns>
    [MethodImpl]
    public extern ConnectedAnimation GetAnimation(string key);

    /// <summary>Returns an instance of ConnectedAnimationService for the current view.</summary>
    /// <returns>An instance of ConnectedAnimationService for the current view.</returns>
    [MethodImpl]
    public static extern ConnectedAnimationService GetForCurrentView();
  }
}
