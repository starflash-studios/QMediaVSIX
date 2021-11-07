// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevicePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.DialProtocol
{
  [Guid(3128840714, 65369, 20299, 189, 172, 216, 159, 73, 90, 214, 225)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DialDevicePicker))]
  internal interface IDialDevicePicker
  {
    DialDevicePickerFilter Filter { get; }

    DevicePickerAppearance Appearance { get; }

    event TypedEventHandler<DialDevicePicker, DialDeviceSelectedEventArgs> DialDeviceSelected;

    event TypedEventHandler<DialDevicePicker, DialDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    event TypedEventHandler<DialDevicePicker, object> DialDevicePickerDismissed;

    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    void Show(Rect selection, Placement preferredPlacement);

    [Overload("PickSingleDialDeviceAsync")]
    IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(Rect selection);

    [Overload("PickSingleDialDeviceAsyncWithPlacement")]
    IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(
      Rect selection,
      Placement preferredPlacement);

    void Hide();

    void SetDisplayStatus(DialDevice device, DialDeviceDisplayStatus status);
  }
}
