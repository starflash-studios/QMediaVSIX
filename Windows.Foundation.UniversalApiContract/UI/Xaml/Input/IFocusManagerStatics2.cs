// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FocusManager))]
  [Guid(2837501793, 56711, 20273, 190, 218, 239, 65, 127, 231, 192, 74)]
  internal interface IFocusManagerStatics2
  {
    [Overload("TryMoveFocus")]
    bool TryMoveFocus(FocusNavigationDirection focusNavigationDirection);
  }
}
