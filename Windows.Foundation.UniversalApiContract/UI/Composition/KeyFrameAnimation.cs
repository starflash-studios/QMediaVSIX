// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.KeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A time-based animation with one or more key frames. These frames are markers, allowing developers to specify values at specific times for the animating property. KeyFrame animations can be further customized by specifying how the animation interpolates between keyframes.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Composable(typeof (IKeyFrameAnimationFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class KeyFrameAnimation : 
    CompositionAnimation,
    IKeyFrameAnimation,
    IKeyFrameAnimation2,
    IKeyFrameAnimation3
  {
    /// <summary>Delay before the animation starts after CompositionObject.StartAnimation is called.</summary>
    /// <returns>Delay before the animation starts after CompositionObject.StartAnimation is called.</returns>
    public extern TimeSpan DelayTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The duration of the animation.</summary>
    /// <returns>The duration of the animation. Minimum allowed value is 1ms and maximum allowed value is 24 days.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The iteration behavior for the key frame animation.</summary>
    /// <returns>The iteration behavior for the key frame animation.</returns>
    public extern AnimationIterationBehavior IterationBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The number of times to repeat the key frame animation.</summary>
    /// <returns>The number of times to repeat the key frame animation.</returns>
    public extern int IterationCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The number of key frames in the KeyFrameAnimation.</summary>
    /// <returns>The number of key frames in the KeyFrameAnimation.</returns>
    public extern int KeyFrameCount { [MethodImpl] get; }

    /// <summary>Specifies how to set the property value when StopAnimation is called.</summary>
    /// <returns>Specifies how to set the property value when StopAnimation is called.</returns>
    public extern AnimationStopBehavior StopBehavior { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Inserts an expression key frame.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="value">The expression used to calculate the value of the key frame.</param>
    [Overload("InsertExpressionKeyFrame")]
    [MethodImpl]
    public extern void InsertExpressionKeyFrame(float normalizedProgressKey, string value);

    /// <summary>Inserts an expression keyframe.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="value">The expression used to calculate the value of the key frame.</param>
    /// <param name="easingFunction">The easing function to use when interpolating between frames.</param>
    [Overload("InsertExpressionKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertExpressionKeyFrame(
      float normalizedProgressKey,
      string value,
      CompositionEasingFunction easingFunction);

    /// <summary>The direction the animation is playing.</summary>
    /// <returns>The direction the animation is playing.</returns>
    public extern AnimationDirection Direction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The delay behavior of the key frame animation.</summary>
    /// <returns>The delay behavior of the key frame animation.</returns>
    public extern AnimationDelayBehavior DelayBehavior { [MethodImpl] get; [MethodImpl] set; }
  }
}
