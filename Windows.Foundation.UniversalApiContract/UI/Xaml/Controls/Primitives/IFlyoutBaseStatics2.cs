// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBaseStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(2833847294, 11616, 17159, 170, 217, 86, 180, 80, 18, 27, 88)]
  [ExclusiveTo(typeof (FlyoutBase))]
  internal interface IFlyoutBaseStatics2
  {
    DependencyProperty AllowFocusOnInteractionProperty { get; }

    DependencyProperty LightDismissOverlayModeProperty { get; }

    DependencyProperty AllowFocusWhenDisabledProperty { get; }

    DependencyProperty ElementSoundModeProperty { get; }
  }
}
