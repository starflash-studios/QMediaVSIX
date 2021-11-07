// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.PathKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Represents a time-based animation with one or more key frames where each key frame value is represented by a</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772165)]
  public sealed class PathKeyFrameAnimation : KeyFrameAnimation, IPathKeyFrameAnimation
  {
    /// <summary>Inserts a key frame.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="path">The path used to define the value of the key frame.</param>
    [Overload("InsertKeyFrame")]
    [MethodImpl]
    public extern void InsertKeyFrame(float normalizedProgressKey, CompositionPath path);

    /// <summary>Inserts a key frame with the specified easing.</summary>
    /// <param name="normalizedProgressKey">The time the key frame should occur at, expressed as a percentage of the animation Duration. Allowed value is from 0.0 to 1.0.</param>
    /// <param name="path">The path used to define the value of the key frame.</param>
    /// <param name="easingFunction">The easing function to use when interpolating between frames.</param>
    [Overload("InsertKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertKeyFrame(
      float normalizedProgressKey,
      CompositionPath path,
      CompositionEasingFunction easingFunction);
  }
}
