// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2738290651, 2265, 17382, 148, 78, 242, 229, 199, 206, 230, 48)]
  [ExclusiveTo(typeof (PickerFlyout))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPickerFlyout
  {
    UIElement Content { get; set; }

    bool ConfirmationButtonsVisible { get; set; }

    event TypedEventHandler<PickerFlyout, PickerConfirmedEventArgs> Confirmed;

    [RemoteAsync]
    IAsyncOperation<bool> ShowAtAsync(FrameworkElement target);
  }
}
