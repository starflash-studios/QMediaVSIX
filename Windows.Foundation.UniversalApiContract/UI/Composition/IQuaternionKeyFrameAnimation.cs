// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IQuaternionKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (QuaternionKeyFrameAnimation))]
  [Guid(1078876213, 60662, 16960, 133, 32, 103, 18, 121, 207, 54, 188)]
  internal interface IQuaternionKeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Quaternion value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Quaternion value,
      CompositionEasingFunction easingFunction);
  }
}
