// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ColorKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A time-based animation that targets the Color property with one or more color key frames.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ColorKeyFrameAnimation : KeyFrameAnimation, IColorKeyFrameAnimation
  {
    /// <summary>The color space the color interpolation should run through.</summary>
    /// <returns>The color space the color interpolation should run through.</returns>
    public extern CompositionColorSpace InterpolationColorSpace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Inserts a key frame.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="value">The value of the key frame.</param>
    [Overload("InsertKeyFrame")]
    [MethodImpl]
    public extern void InsertKeyFrame(float normalizedProgressKey, Color value);

    /// <summary>Inserts a key frame with the specified easing function.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="value">The value of the key frame.</param>
    /// <param name="easingFunction">The easing function to use to interpolate between key frames.</param>
    [Overload("InsertKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertKeyFrame(
      float normalizedProgressKey,
      Color value,
      CompositionEasingFunction easingFunction);
  }
}
