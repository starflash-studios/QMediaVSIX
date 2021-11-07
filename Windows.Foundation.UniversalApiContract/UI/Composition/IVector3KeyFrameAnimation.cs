// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector3KeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Vector3KeyFrameAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3355680170, 41601, 17346, 167, 61, 182, 142, 60, 83, 60, 64)]
  [WebHostHidden]
  internal interface IVector3KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Vector3 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Vector3 value,
      CompositionEasingFunction easingFunction);
  }
}
