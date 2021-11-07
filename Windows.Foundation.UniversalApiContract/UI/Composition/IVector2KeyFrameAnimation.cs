// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector2KeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(3745596693, 20009, 20241, 181, 94, 191, 42, 110, 179, 98, 148)]
  [ExclusiveTo(typeof (Vector2KeyFrameAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IVector2KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Vector2 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Vector2 value,
      CompositionEasingFunction easingFunction);
  }
}
