// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.IElementCompositionPreviewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Hosting
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(605327291, 9174, 20279, 186, 12, 7, 51, 231, 153, 114, 45)]
  [ExclusiveTo(typeof (ElementCompositionPreview))]
  internal interface IElementCompositionPreviewStatics2
  {
    void SetImplicitShowAnimation(UIElement element, ICompositionAnimationBase animation);

    void SetImplicitHideAnimation(UIElement element, ICompositionAnimationBase animation);

    void SetIsTranslationEnabled(UIElement element, bool value);

    CompositionPropertySet GetPointerPositionPropertySet(
      UIElement targetElement);
  }
}
