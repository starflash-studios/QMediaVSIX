// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbControlRecipient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Defines constants that indicate the recipient of a USB control transfer. The recipient is defined in the setup packet of the control request. See Table 9.2 of section 9.3 of the Universal Serial Bus (USB) specification (www.usb.org).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UsbControlRecipient
  {
    /// <summary>The recipient of the control transfer is the device.</summary>
    Device,
    /// <summary>The recipient of the control transfer is the USB interface that is specified in the request.</summary>
    SpecifiedInterface,
    /// <summary>The recipient of the control transfer is an endpoint.</summary>
    Endpoint,
    /// <summary>The recipient of the control transfer is other.</summary>
    Other,
    /// <summary>The recipient of the control transfer is the default (or the first) USB interface in the selected configuration of the device.If the recipient is the first interface of the active configuration (DefaultInterface ), SendControlInTransferAsync and SendControlOutTransferAsync methods overwrite the low byte of UsbSetupPacket.Index with the interface number of the default interface.</summary>
    DefaultInterface,
  }
}
