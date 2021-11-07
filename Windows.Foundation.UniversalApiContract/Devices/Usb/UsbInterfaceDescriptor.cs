// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterfaceDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Describes a USB alternate setting (of an interface) in an interface descriptor. For an explanation of an interface descriptor, see Section 9.6.5 in the Universal Serial Bus Specification:</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUsbInterfaceDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbInterfaceDescriptor : IUsbInterfaceDescriptor
  {
    /// <summary>Gets the **bInterfaceClass** field of the USB interface descriptor. The value indicates the USB-defined class to which the interface conforms.</summary>
    /// <returns>The USB-defined class to which the interface conforms.</returns>
    public extern byte ClassCode { [MethodImpl] get; }

    /// <summary>Gets the **bInterfaceSubClass** field of the USB interface descriptor. The value is a USB-assigned identifier that specifies a USB-defined subclass to which the interface.</summary>
    /// <returns>A USB-assigned identifier that specifies a USB-defined subclass to which the interface.</returns>
    public extern byte SubclassCode { [MethodImpl] get; }

    /// <summary>Gets the **bInterfaceProtocol** field of the interface descriptor. The value is a USB-assigned identifier that specifies a USB-defined protocol to which the interface conforms.</summary>
    /// <returns>A USB-assigned identifier that specifies a USB-defined protocol to which the interface conforms.</returns>
    public extern byte ProtocolCode { [MethodImpl] get; }

    /// <summary>Gets the **bAlternateSetting** field of the USB interface descriptor. The value is a number that identifies the alternate setting defined by the interface.</summary>
    /// <returns>A number that identifies the alternate setting defined by the interface.</returns>
    public extern byte AlternateSettingNumber { [MethodImpl] get; }

    /// <summary>Gets the **bInterfaceNumber** field of the USB interface descriptor. The value is the index that identifies the interface.</summary>
    /// <returns>The index that identifies the interface.</returns>
    public extern byte InterfaceNumber { [MethodImpl] get; }

    /// <summary>Retrieves information about the alternate setting in a UsbInterfaceDescriptor object that is contained in a UsbDescriptor object.</summary>
    /// <param name="descriptor">The UsbDescriptor object to parse.</param>
    /// <param name="parsed">Receives a UsbInterfaceDescriptor object.</param>
    /// <returns>True, if the specified UsbDescriptor object is USB interface descriptor. Otherwise, false.</returns>
    [MethodImpl]
    public static extern bool TryParse(UsbDescriptor descriptor, out UsbInterfaceDescriptor parsed);

    /// <summary>Parses the specified USB descriptor and returns alternate setting information in a UsbInterfaceDescriptor object.</summary>
    /// <param name="descriptor">A UsbDescriptor object that contains the USB interface descriptor.</param>
    /// <returns>A UsbInterfaceDescriptor object describes the alternate setting.</returns>
    [MethodImpl]
    public static extern UsbInterfaceDescriptor Parse(UsbDescriptor descriptor);
  }
}
