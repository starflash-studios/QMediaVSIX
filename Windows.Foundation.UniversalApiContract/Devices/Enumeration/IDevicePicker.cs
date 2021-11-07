// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Devices.Enumeration
{
  [Guid(2224650914, 842, 17472, 136, 19, 125, 11, 212, 121, 191, 90)]
  [ExclusiveTo(typeof (DevicePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDevicePicker
  {
    DevicePickerFilter Filter { get; }

    DevicePickerAppearance Appearance { get; }

    IVector<string> RequestedProperties { get; }

    event TypedEventHandler<DevicePicker, DeviceSelectedEventArgs> DeviceSelected;

    event TypedEventHandler<DevicePicker, DeviceDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    event TypedEventHandler<DevicePicker, object> DevicePickerDismissed;

    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    void Show(Rect selection, Placement placement);

    [Overload("PickSingleDeviceAsync")]
    IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection);

    [Overload("PickSingleDeviceAsyncWithPlacement")]
    IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection,
      Placement placement);

    void Hide();

    void SetDisplayStatus(
      DeviceInformation device,
      string status,
      DevicePickerDisplayStatusOptions options);
  }
}
