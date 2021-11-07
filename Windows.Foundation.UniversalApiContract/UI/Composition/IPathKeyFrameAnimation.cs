// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IPathKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (PathKeyFrameAnimation))]
  [Guid(2634881225, 5494, 19263, 190, 96, 29, 80, 49, 245, 231, 27)]
  [WebHostHidden]
  internal interface IPathKeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, CompositionPath path);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      CompositionPath path,
      CompositionEasingFunction easingFunction);
  }
}
