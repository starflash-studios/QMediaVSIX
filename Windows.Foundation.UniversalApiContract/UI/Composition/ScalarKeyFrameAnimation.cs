// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ScalarKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A time-based animation that targets any Scalar-based property with one or more key frames.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  public sealed class ScalarKeyFrameAnimation : KeyFrameAnimation, IScalarKeyFrameAnimation
  {
    /// <summary>Inserts a key frame.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="value">The value of the key frame.</param>
    [Overload("InsertKeyFrame")]
    [MethodImpl]
    public extern void InsertKeyFrame(float normalizedProgressKey, float value);

    /// <summary>Inserts a keyframe.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="value">The value of the key frame.</param>
    /// <param name="easingFunction">The easing function to use to interpolate between key frames.</param>
    [Overload("InsertKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertKeyFrame(
      float normalizedProgressKey,
      float value,
      CompositionEasingFunction easingFunction);
  }
}
