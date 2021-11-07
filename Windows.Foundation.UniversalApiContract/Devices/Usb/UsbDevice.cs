// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Represents a USB device. The object provides methods and properties that an app can use to find the device (in the system) with which the app wants to communicate, and sends IN and OUT control transfers to the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IUsbDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbDevice : IUsbDevice, IClosable
  {
    /// <summary>Starts a USB control transfer to send data to the default control endpoint of the device.</summary>
    /// <param name="setupPacket">A UsbSetupPacket object that contains the setup packet for the control transfer.</param>
    /// <param name="buffer">A caller-supplied buffer that contains the transfer data.</param>
    /// <returns>Returns an IAsyncOperation(UInt32) object that returns the results of the operation.</returns>
    [Overload("SendControlOutTransferAsync")]
    [MethodImpl]
    public extern IAsyncOperation<uint> SendControlOutTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    /// <summary>Starts a zero-length USB control transfer that writes to the default control endpoint of the device.</summary>
    /// <param name="setupPacket">A UsbSetupPacket object that contains the setup packet for the control transfer.</param>
    /// <returns>Returns an IAsyncOperation(UInt32) object that returns the results of the operation.</returns>
    [Overload("SendControlOutTransferAsyncNoBuffer")]
    [MethodImpl]
    public extern IAsyncOperation<uint> SendControlOutTransferAsync(
      UsbSetupPacket setupPacket);

    /// <summary>Starts a USB control transfer to receive data from the default control endpoint of the device.</summary>
    /// <param name="setupPacket">A UsbSetupPacket object that contains the setup packet for the control transfer.</param>
    /// <param name="buffer">A caller-supplied buffer that contains transfer data.</param>
    /// <returns>Returns an IAsyncOperation(IBuffer) object that returns the results of the operation.</returns>
    [Overload("SendControlInTransferAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    /// <summary>Starts a zero-length USB control transfer that reads from the default control endpoint of the device.</summary>
    /// <param name="setupPacket">A UsbSetupPacket object that contains the setup packet for the control transfer.</param>
    /// <returns>Returns an IAsyncOperation(IBuffer) object that returns the results of the operation.</returns>
    [Overload("SendControlInTransferAsyncNoBuffer")]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket);

    /// <summary>Gets the object that represents the default or the first interface in a USB configuration.</summary>
    /// <returns>A UsbInterface object that represents the default or the first interface in a USB configuration.</returns>
    public extern UsbInterface DefaultInterface { [MethodImpl] get; }

    /// <summary>Gets the object that represents the USB device descriptor.</summary>
    /// <returns>A UsbDeviceDescriptor that represents the USB device descriptor.</returns>
    public extern UsbDeviceDescriptor DeviceDescriptor { [MethodImpl] get; }

    /// <summary>Gets an object that represents a USB configuration including all interfaces and their endpoints.</summary>
    /// <returns>A UsbConfiguration object that contains information about a USB configuration including the configuration descriptor and array of all USB interfaces in that configuration.</returns>
    public extern UsbConfiguration Configuration { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string, based on vendor, product, and device interface GUID identifiers, specified by the app. The app passes the string to DeviceInformation.FindAllAsync in order to find a specific type of USB device.</summary>
    /// <param name="vendorId">Specifies the vendor identifier for the device as assigned by the USB specification committee. Possible values are 0 through 0xffff.</param>
    /// <param name="productId">Specifies the product identifier. This value is assigned by the manufacturer and is device-specific. Possible values are 0 through 0xffff.</param>
    /// <param name="winUsbInterfaceClass">The device interface GUID exposed by the Winusb.sys driver. See the remarks section.</param>
    /// <returns>String formatted as an AQS query.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(
      uint vendorId,
      uint productId,
      Guid winUsbInterfaceClass);

    /// <summary>Gets an Advanced Query Syntax (AQS) string, based on the device interface GUID identifier, specified by the app. The app passes the string to DeviceInformation.FindAllAsync in order to find a specific type of USB device.</summary>
    /// <param name="winUsbInterfaceClass">The device interface GUID exposed by the Winusb.sys driver. See the remarks section.</param>
    /// <returns>String formatted as an AQS query.</returns>
    [Overload("GetDeviceSelectorGuidOnly")]
    [MethodImpl]
    public static extern string GetDeviceSelector(Guid winUsbInterfaceClass);

    /// <summary>Gets an Advanced Query Syntax (AQS) string, based on vendor and product identifiers, specified by the app. The app passes the string to DeviceInformation.FindAllAsync in order to find a specific type of USB device.</summary>
    /// <param name="vendorId">Specifies the vendor identifier for the device as assigned by the USB specification committee. Possible values are 0 through 0xffff.</param>
    /// <param name="productId">Specifies the product identifier. This value is assigned by the manufacturer and is device-specific. Possible values are 0 through 0xffff.</param>
    /// <returns>String formatted as an AQS query.</returns>
    [Overload("GetDeviceSelectorVidPidOnly")]
    [MethodImpl]
    public static extern string GetDeviceSelector(uint vendorId, uint productId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that the app can pass to DeviceInformation.FindAllAsync in order to find a specific type of USB device.</summary>
    /// <param name="usbClass">A UsbDeviceClass object for the device class specified by the app.</param>
    /// <returns>String formatted as an AQS query.</returns>
    [MethodImpl]
    public static extern string GetDeviceClassSelector(UsbDeviceClass usbClass);

    /// <summary>Starts an asynchronous operation that creates a UsbDevice object.</summary>
    /// <param name="deviceId">The device instance path of the device. To obtain that value, get the DeviceInformation.Id property value.</param>
    /// <returns>Returns an IAsyncOperation(UsbDevice) object that returns the results of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UsbDevice> FromIdAsync(
      string deviceId);
  }
}
