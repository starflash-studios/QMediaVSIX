// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.AnimationController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Provides playback controls for a KeyFrameAnimation.</summary>
  [WebHostHidden]
  [DualApiPartition(version = 167772165)]
  [Static(typeof (IAnimationControllerStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class AnimationController : CompositionObject, IAnimationController
  {
    /// <summary>Gets or sets the rate at which the animation plays.</summary>
    /// <returns>The rate at which the animation plays. The default is 1.0.</returns>
    public extern float PlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the current playback position of the animation.</summary>
    /// <returns>The current playback position of the animation.</returns>
    public extern float Progress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how progress is determined.</summary>
    /// <returns>A value of the enumeration that indicates how progress is determined. The default is **Default**.</returns>
    public extern AnimationControllerProgressBehavior ProgressBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Pauses playback of the animation.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Starts playback of an animation that was previously paused.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>Gets the maximum allowed playback rate.</summary>
    /// <returns>The maximum allowed playback rate.</returns>
    public static extern float MaxPlaybackRate { [MethodImpl] get; }

    /// <summary>Gets the minimum allowed playback rate.</summary>
    /// <returns>The minimum allowed playback rate.</returns>
    public static extern float MinPlaybackRate { [MethodImpl] get; }
  }
}
