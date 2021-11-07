// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ICommonNavigationTransitionInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (CommonNavigationTransitionInfo))]
  [Guid(507444787, 20670, 17475, 136, 60, 229, 98, 114, 1, 194, 229)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICommonNavigationTransitionInfoStatics
  {
    DependencyProperty IsStaggeringEnabledProperty { get; }

    DependencyProperty IsStaggerElementProperty { get; }

    bool GetIsStaggerElement(UIElement element);

    void SetIsStaggerElement(UIElement element, bool value);
  }
}
