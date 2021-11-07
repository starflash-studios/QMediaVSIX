// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [Guid(2397936578, 42380, 17491, 175, 15, 169, 46, 224, 109, 3, 23)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUIElement5
  {
    IVector<XamlLight> Lights { get; }

    KeyTipPlacementMode KeyTipPlacementMode { get; set; }

    double KeyTipHorizontalOffset { get; set; }

    double KeyTipVerticalOffset { get; set; }

    XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation { get; set; }

    XYFocusNavigationStrategy XYFocusUpNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusDownNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get; set; }

    ElementHighContrastAdjustment HighContrastAdjustment { get; set; }

    KeyboardNavigationMode TabFocusNavigation { get; set; }

    event TypedEventHandler<UIElement, GettingFocusEventArgs> GettingFocus;

    event TypedEventHandler<UIElement, LosingFocusEventArgs> LosingFocus;

    event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> NoFocusCandidateFound;

    [Overload("StartBringIntoView")]
    void StartBringIntoView();

    [Overload("StartBringIntoViewWithOptions")]
    void StartBringIntoView(BringIntoViewOptions options);
  }
}
