// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Vector3KeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>A time-based animation that targets any Vector3-based property with one or more keyframes.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Vector3KeyFrameAnimation : KeyFrameAnimation, IVector3KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    [MethodImpl]
    public extern void InsertKeyFrame(float normalizedProgressKey, Vector3 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertKeyFrame(
      float normalizedProgressKey,
      Vector3 value,
      CompositionEasingFunction easingFunction);
  }
}
