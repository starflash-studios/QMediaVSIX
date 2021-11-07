// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector4KeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(609719387, 44509, 17285, 150, 6, 182, 163, 213, 228, 225, 185)]
  [ExclusiveTo(typeof (Vector4KeyFrameAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  internal interface IVector4KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Vector4 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Vector4 value,
      CompositionEasingFunction easingFunction);
  }
}
