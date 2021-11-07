// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [Guid(690450076, 7276, 16714, 186, 28, 150, 239, 213, 150, 43, 205)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (FocusManager))]
  internal interface IFocusManagerStatics4
  {
    [Overload("TryMoveFocusWithOptions")]
    bool TryMoveFocus(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    [Overload("FindNextElement")]
    DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection);

    DependencyObject FindFirstFocusableElement(DependencyObject searchScope);

    DependencyObject FindLastFocusableElement(DependencyObject searchScope);

    [Overload("FindNextElementWithOptions")]
    DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);
  }
}
