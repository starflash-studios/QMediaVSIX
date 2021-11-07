// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEntranceNavigationTransitionInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (EntranceNavigationTransitionInfo))]
  [Guid(4182295162, 16585, 18079, 143, 51, 191, 69, 200, 129, 31, 33)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEntranceNavigationTransitionInfoStatics
  {
    DependencyProperty IsTargetElementProperty { get; }

    bool GetIsTargetElement(UIElement element);

    void SetIsTargetElement(UIElement element, bool value);
  }
}
