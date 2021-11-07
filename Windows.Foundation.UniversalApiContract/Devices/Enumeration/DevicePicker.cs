// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DevicePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Devices.Enumeration
{
  /// <summary>Represents a picker flyout that contains a list of devices for the user to choose from.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DevicePicker : IDevicePicker
  {
    /// <summary>Creates a DevicePicker object.</summary>
    [MethodImpl]
    public extern DevicePicker();

    /// <summary>Gets the filter used to choose what devices to show in the picker.</summary>
    /// <returns>The filter.</returns>
    public extern DevicePickerFilter Filter { [MethodImpl] get; }

    /// <summary>Gets the colors of the picker.</summary>
    /// <returns>The color of the picker.</returns>
    public extern DevicePickerAppearance Appearance { [MethodImpl] get; }

    /// <summary>Gets a collection of properties for the returned device information object.</summary>
    /// <returns>The properties you want returned.</returns>
    public extern IVector<string> RequestedProperties { [MethodImpl] get; }

    /// <summary>Indicates that the user selected a device in the picker.</summary>
    public extern event TypedEventHandler<DevicePicker, DeviceSelectedEventArgs> DeviceSelected;

    /// <summary>Indicates that the user clicked or tapped the disconnect button for a device in the picker.</summary>
    public extern event TypedEventHandler<DevicePicker, DeviceDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    /// <summary>Indicates that the device picker was light dismissed by the user. Light dismiss happens when the user clicks somewhere other than the picker UI and the picker UI disappears.</summary>
    public extern event TypedEventHandler<DevicePicker, object> DevicePickerDismissed;

    /// <summary>Shows the picker UI. The picker flies out from the edge of the specified rectangle.</summary>
    /// <param name="selection">The rectangle from which you want the picker to fly out.</param>
    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    /// <summary>Shows the picker UI. The picker flies out from the specified edge of the specified rectangle.</summary>
    /// <param name="selection">The rectangle from which you want the picker to fly out.</param>
    /// <param name="placement">The edge of the rectangle from which you want the picker to fly out.</param>
    [Overload("ShowWithPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement placement);

    /// <summary>Shows the picker UI and returns the selected device; does not require you to register for an event. The picker flies out from the edge of the specified rectangle.</summary>
    /// <param name="selection">The rectangle from which you want the picker to fly out.</param>
    /// <returns>The device selected by the user.</returns>
    [Overload("PickSingleDeviceAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection);

    /// <summary>Shows the picker UI and returns the selected device; does not require you to register for an event. The picker flies out from the specified edge of the specified rectangle.</summary>
    /// <param name="selection">The rectangle from which you want the picker to fly out.</param>
    /// <param name="placement">The edge of the rectangle from which you want the picker to fly out.</param>
    /// <returns>The device selected.</returns>
    [Overload("PickSingleDeviceAsyncWithPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceInformation> PickSingleDeviceAsync(
      Rect selection,
      Placement placement);

    /// <summary>Hides the picker.</summary>
    [MethodImpl]
    public extern void Hide();

    /// <summary>Updates the picker UI to reflect the provided status and display options for a specified device.</summary>
    /// <param name="device">The device information.</param>
    /// <param name="status">The status to display.</param>
    /// <param name="options">The display options for the device.</param>
    [MethodImpl]
    public extern void SetDisplayStatus(
      DeviceInformation device,
      string status,
      DevicePickerDisplayStatusOptions options);
  }
}
