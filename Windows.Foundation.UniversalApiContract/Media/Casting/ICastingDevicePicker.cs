// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDevicePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CastingDevicePicker))]
  [Guid(3704854820, 1425, 18878, 170, 203, 75, 130, 238, 117, 106, 149)]
  internal interface ICastingDevicePicker
  {
    CastingDevicePickerFilter Filter { get; }

    DevicePickerAppearance Appearance { get; }

    event TypedEventHandler<CastingDevicePicker, CastingDeviceSelectedEventArgs> CastingDeviceSelected;

    event TypedEventHandler<CastingDevicePicker, object> CastingDevicePickerDismissed;

    [Overload("Show")]
    void Show(Rect selection);

    [Overload("ShowWithPlacement")]
    void Show(Rect selection, Placement preferredPlacement);

    void Hide();
  }
}
