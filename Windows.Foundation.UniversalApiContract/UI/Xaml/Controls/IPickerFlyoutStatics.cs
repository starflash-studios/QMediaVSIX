// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPickerFlyoutStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (PickerFlyout))]
  [Guid(2937627702, 62346, 19133, 185, 51, 98, 134, 193, 21, 176, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPickerFlyoutStatics
  {
    DependencyProperty ContentProperty { get; }

    DependencyProperty ConfirmationButtonsVisibleProperty { get; }
  }
}
