// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IScalarKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (ScalarKeyFrameAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2921893801, 9516, 19349, 167, 37, 191, 133, 227, 128, 0, 161)]
  internal interface IScalarKeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, float value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      float value,
      CompositionEasingFunction easingFunction);
  }
}
