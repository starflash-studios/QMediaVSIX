// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDevicePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents a picker flyout that contains a list of remote devices for the user to choose from.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class DialDevicePicker : IDialDevicePicker
  {
    /// <summary>Creates a new DialDevicePicker object.</summary>
    [MethodImpl]
    public extern DialDevicePicker();

    /// <summary>Gets the filter used to choose what devices to show in the picker.</summary>
    /// <returns>The dial device picker filter.</returns>
    public extern DialDevicePickerFilter Filter { [MethodImpl] get; }

    /// <summary>Used to change the colors of the picker.</summary>
    /// <returns>The color of the picker.</returns>
    public extern DevicePickerAppearance Appearance { [MethodImpl] get; }

    /// <summary>Indicates that the user selected a device from the picker.</summary>
    public extern event TypedEventHandler<DialDevicePicker, DialDeviceSelectedEventArgs> DialDeviceSelected;

    /// <summary>Indicates that the user clicked on the disconnect button in the picker.</summary>
    public extern event TypedEventHandler<DialDevicePicker, DialDisconnectButtonClickedEventArgs> DisconnectButtonClicked;

    /// <summary>Indicates that the device picker was light dismissed, which means that the user clicked or touched anywhere other than the picker UI, and so the picker will be closed.</summary>
    public extern event TypedEventHandler<DialDevicePicker, object> DialDevicePickerDismissed;

    /// <summary>Displays the picker to the user. When called, the picker flies out from an edge of the provided rectangle.</summary>
    /// <param name="selection">The rectangle from which you want the picker to show.</param>
    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    /// <summary>Displays the picker to the user. When called, the picker flies out from the specified edge of the provided rectangle.</summary>
    /// <param name="selection">The rectangle from which you want the picker to show.</param>
    /// <param name="preferredPlacement">The edge from which you want the picker to show.</param>
    [Overload("ShowWithPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement preferredPlacement);

    /// <summary>Shows the picker. Call this method directly to show to show the picker, instead of showing it in response to an event.</summary>
    /// <param name="selection">The rectangle from which to show the picker.</param>
    /// <returns>The device the user selected from the picker.</returns>
    [Overload("PickSingleDialDeviceAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(
      Rect selection);

    /// <summary>Shows the picker. Call this method directly to show to show the picker, instead of showing it in response to an event.</summary>
    /// <param name="selection">The rectangle from which to show the picker.</param>
    /// <param name="preferredPlacement">The edge of the rectangle from which to show the picker.</param>
    /// <returns>The DialDevice object selected.</returns>
    [Overload("PickSingleDialDeviceAsyncWithPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<DialDevice> PickSingleDialDeviceAsync(
      Rect selection,
      Placement preferredPlacement);

    /// <summary>Hides the picker.</summary>
    [MethodImpl]
    public extern void Hide();

    /// <summary>Updates the picker UI to reflect the status fo a given remote device.</summary>
    /// <param name="device">The remote device whose status you want to display.</param>
    /// <param name="status">The status you want displayed.</param>
    [MethodImpl]
    public extern void SetDisplayStatus(DialDevice device, DialDeviceDisplayStatus status);
  }
}
