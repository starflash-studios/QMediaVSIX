// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbSetupPacket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Describes the setup packet for a USB control transfer. For an explanation of the setup packet, see Table 9.2 in the Universal Serial Bus (USB) specification.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IUsbSetupPacketFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbSetupPacket : IUsbSetupPacket
  {
    /// <summary>Creates a UsbSetupPacket object from a formatted buffer (eight bytes) that contains the setup packet.</summary>
    /// <param name="eightByteBuffer">A caller-supplied buffer that contains the setup packet formatted as per the standard USB specification. The length of the buffer must be eight bytes because that is the size of a setup packet on the bus.</param>
    [MethodImpl]
    public extern UsbSetupPacket(IBuffer eightByteBuffer);

    /// <summary>Creates a UsbSetupPacket object.</summary>
    [MethodImpl]
    public extern UsbSetupPacket();

    /// <summary>Gets or sets the **bmRequestType** field in the setup packet of the USB control transfer. That field is represented by a UsbControlRequestType object.</summary>
    /// <returns>The **bmRequestType** field in the setup packet. The values that are assigned to this field are described in Table 9.2 and section 9.3.1 of the Universal Serial Bus (USB) specification.</returns>
    public extern UsbControlRequestType RequestType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the **bRequest** field in the setup packet of the USB control transfer.</summary>
    /// <returns>The **bRequest** field in the setup packet. For an explanation of this field, see section 9.3.2 of the Universal Serial Bus (USB) specification.</returns>
    public extern byte Request { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the **wValue** field in the setup packet of the USB control transfer.</summary>
    /// <returns>The **wValue** field in the setup packet and the value varies according to the request. For an explanation of this field, see section 9.3.3 of the Universal Serial Bus (USB) specification.</returns>
    public extern uint Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the **wIndex** field in the setup packet of the USB control transfer.</summary>
    /// <returns>The **wIndex** field in the setup packet. For an explanation of this field, see section 9.3.4 of the Universal Serial Bus (USB) specification.</returns>
    public extern uint Index { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the length, in bytes, of the setup packet.</summary>
    /// <returns>The length, in bytes, of the setup packet.</returns>
    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }
  }
}
