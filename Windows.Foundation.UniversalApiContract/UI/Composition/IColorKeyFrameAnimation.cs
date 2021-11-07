// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IColorKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ColorKeyFrameAnimation))]
  [Guid(2477635049, 36357, 17811, 132, 163, 220, 161, 82, 120, 30, 86)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IColorKeyFrameAnimation
  {
    CompositionColorSpace InterpolationColorSpace { get; set; }

    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Color value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Color value,
      CompositionEasingFunction easingFunction);
  }
}
