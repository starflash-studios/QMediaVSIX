// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(309231394, 15081, 17728, 154, 138, 222, 174, 138, 74, 74, 132)]
  [ExclusiveTo(typeof (KeyFrameAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IKeyFrameAnimation
  {
    TimeSpan DelayTime { get; set; }

    TimeSpan Duration { get; set; }

    AnimationIterationBehavior IterationBehavior { get; set; }

    int IterationCount { get; set; }

    int KeyFrameCount { get; }

    AnimationStopBehavior StopBehavior { get; set; }

    [Overload("InsertExpressionKeyFrame")]
    void InsertExpressionKeyFrame(float normalizedProgressKey, string value);

    [Overload("InsertExpressionKeyFrameWithEasingFunction")]
    void InsertExpressionKeyFrame(
      float normalizedProgressKey,
      string value,
      CompositionEasingFunction easingFunction);
  }
}
