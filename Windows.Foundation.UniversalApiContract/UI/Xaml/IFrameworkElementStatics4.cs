// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(2621550933, 50648, 18019, 191, 242, 216, 213, 79, 181, 219, 179)]
  [ExclusiveTo(typeof (FrameworkElement))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IFrameworkElementStatics4
  {
    DependencyProperty AllowFocusOnInteractionProperty { get; }

    DependencyProperty FocusVisualMarginProperty { get; }

    DependencyProperty FocusVisualSecondaryThicknessProperty { get; }

    DependencyProperty FocusVisualPrimaryThicknessProperty { get; }

    DependencyProperty FocusVisualSecondaryBrushProperty { get; }

    DependencyProperty FocusVisualPrimaryBrushProperty { get; }

    DependencyProperty AllowFocusWhenDisabledProperty { get; }
  }
}
