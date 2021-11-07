// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FocusManager))]
  [Guid(1619025599, 45385, 16765, 131, 241, 186, 235, 86, 14, 42, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFocusManagerStatics3
  {
    [Overload("FindNextFocusableElement")]
    UIElement FindNextFocusableElement(FocusNavigationDirection focusNavigationDirection);

    [Overload("FindNextFocusableElementWithHint")]
    UIElement FindNextFocusableElement(
      FocusNavigationDirection focusNavigationDirection,
      Rect hintRect);
  }
}
