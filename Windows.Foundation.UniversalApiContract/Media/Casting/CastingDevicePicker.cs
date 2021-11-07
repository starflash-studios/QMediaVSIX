// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDevicePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Media.Casting
{
  /// <summary>Represents a device picker that contains a list of casting devices for the user to choose from.</summary>
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CastingDevicePicker : ICastingDevicePicker
  {
    /// <summary>Creates a CastingDevicePicker object.</summary>
    [MethodImpl]
    public extern CastingDevicePicker();

    /// <summary>Gets the filter information for which devices to show in the picker.</summary>
    /// <returns>The filter information.</returns>
    public extern CastingDevicePickerFilter Filter { [MethodImpl] get; }

    /// <summary>Gets the colors of the picker UI.</summary>
    /// <returns>The appearance details of the picker UI.</returns>
    public extern DevicePickerAppearance Appearance { [MethodImpl] get; }

    /// <summary>Indicates that the user has selected a device from the picker.</summary>
    public extern event TypedEventHandler<CastingDevicePicker, CastingDeviceSelectedEventArgs> CastingDeviceSelected;

    /// <summary>Indicates that the user has dismissed the picker UI.</summary>
    public extern event TypedEventHandler<CastingDevicePicker, object> CastingDevicePickerDismissed;

    /// <summary>Shows the casting device picker UI, which flies out from an edge of the provided rectangle.</summary>
    /// <param name="selection">The rectangle from which the picker UI should fly out.</param>
    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    /// <summary>Shows the casting device picker UI, which flies out from the specified edge of the provided rectangle.</summary>
    /// <param name="selection">The rectangle from which the picker should fly out.</param>
    /// <param name="preferredPlacement">The edge of the rectangle from which the picker should fly out.</param>
    [Overload("ShowWithPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement preferredPlacement);

    /// <summary>Hides the device picker UI.</summary>
    [MethodImpl]
    public extern void Hide();
  }
}
