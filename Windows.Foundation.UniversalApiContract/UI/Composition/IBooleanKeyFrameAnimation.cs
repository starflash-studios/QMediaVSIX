// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IBooleanKeyFrameAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BooleanKeyFrameAnimation))]
  [Guid(2514631176, 53748, 18802, 151, 112, 62, 254, 104, 216, 46, 20)]
  internal interface IBooleanKeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, bool value);
  }
}
