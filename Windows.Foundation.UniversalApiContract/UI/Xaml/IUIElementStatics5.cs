// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(1505590673, 36771, 19557, 186, 27, 64, 223, 56, 85, 108, 187)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UIElement))]
  internal interface IUIElementStatics5
  {
    DependencyProperty LightsProperty { get; }

    DependencyProperty KeyTipPlacementModeProperty { get; }

    DependencyProperty KeyTipHorizontalOffsetProperty { get; }

    DependencyProperty KeyTipVerticalOffsetProperty { get; }

    DependencyProperty XYFocusKeyboardNavigationProperty { get; }

    DependencyProperty XYFocusUpNavigationStrategyProperty { get; }

    DependencyProperty XYFocusDownNavigationStrategyProperty { get; }

    DependencyProperty XYFocusLeftNavigationStrategyProperty { get; }

    DependencyProperty XYFocusRightNavigationStrategyProperty { get; }

    DependencyProperty HighContrastAdjustmentProperty { get; }

    DependencyProperty TabFocusNavigationProperty { get; }
  }
}
