// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionObjectStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(3253536047, 7074, 17594, 169, 4, 106, 136, 42, 10, 90, 219)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionObject))]
  internal interface ICompositionObjectStatics
  {
    void StartAnimationWithIAnimationObject(
      IAnimationObject target,
      string propertyName,
      CompositionAnimation animation);

    void StartAnimationGroupWithIAnimationObject(
      IAnimationObject target,
      ICompositionAnimationBase animation);
  }
}
