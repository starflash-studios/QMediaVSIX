// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (FocusManager))]
  [WebHostHidden]
  [Guid(672062561, 8314, 19835, 185, 143, 206, 22, 94, 27, 32, 21)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IFocusManagerStatics5
  {
    [RemoteAsync]
    IAsyncOperation<FocusMovementResult> TryFocusAsync(
      DependencyObject element,
      FocusState value);

    [Overload("TryMoveFocusAsync")]
    [RemoteAsync]
    IAsyncOperation<FocusMovementResult> TryMoveFocusAsync(
      FocusNavigationDirection focusNavigationDirection);

    [RemoteAsync]
    [Overload("TryMoveFocusWithOptionsAsync")]
    IAsyncOperation<FocusMovementResult> TryMoveFocusAsync(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);
  }
}
