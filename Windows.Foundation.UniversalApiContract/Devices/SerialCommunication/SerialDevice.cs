// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.SerialDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Represents a serial port. The object provides methods and properties that an app can use to find the port (in the system).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (ISerialDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SerialDevice : ISerialDevice, IClosable
  {
    /// <summary>Gets or sets the baud rate.</summary>
    /// <returns>The baud rate of the serial port.</returns>
    public extern uint BaudRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the break signal state.</summary>
    /// <returns>Toggles the TX line to enable or disable data transmission.</returns>
    public extern bool BreakSignalState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the number of bytes received by the last read operation of the input stream.</summary>
    /// <returns>The number of bytes received by the last read operation of the input stream.</returns>
    public extern uint BytesReceived { [MethodImpl] get; }

    /// <summary>Gets the state of the Carrier Detect (CD) line.</summary>
    /// <returns>Detects the state of Carrier Detect line. If the line is detected, value is **true**; otherwise, **false**.</returns>
    public extern bool CarrierDetectState { [MethodImpl] get; }

    /// <summary>Gets the state of the Clear-to-Send (CTS) line.</summary>
    /// <returns>Detects the state of Clear-to-Send line. If the line is detected, value is **true**; otherwise, **false**.</returns>
    public extern bool ClearToSendState { [MethodImpl] get; }

    /// <summary>The number of data bits in each character value that is transmitted or received, and does not include parity bits or stop bits.</summary>
    /// <returns>The number of data bits in each character value that is transmitted or received.</returns>
    public extern ushort DataBits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the state of the Data Set Ready (DSR) signal.</summary>
    /// <returns>Indicates whether DSR has been sent to the serial port. If the signal was sent, value is **true**; otherwise, **false**.</returns>
    public extern bool DataSetReadyState { [MethodImpl] get; }

    /// <summary>Gets or sets the handshaking protocol for flow control.</summary>
    /// <returns>One of the values defined in SerialHandshake enumeration.</returns>
    public extern SerialHandshake Handshake { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that enables the Data Terminal Ready (DTR) signal.</summary>
    /// <returns>Enables or disables the Data Terminal Ready (DTR) signal. **true** enables DTR; Otherwise, **false**.</returns>
    public extern bool IsDataTerminalReadyEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that enables the Request to Send (RTS) signal.</summary>
    /// <returns>Enables or disables the Request to Send (RTS) signal. **true** enables DTR; Otherwise, **false**.</returns>
    public extern bool IsRequestToSendEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parity bit for error-checking.</summary>
    /// <returns>One of the values defined in SerialParity enumeration.</returns>
    public extern SerialParity Parity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the port name for serial communications.</summary>
    /// <returns>The communication port name. For example "COM1".</returns>
    public extern string PortName { [MethodImpl] get; }

    /// <summary>Gets or sets the time-out value for a read operation.</summary>
    /// <returns>The span of time before a time-out occurs when a read operation does not finish.</returns>
    public extern TimeSpan ReadTimeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the standard number of stop bits per byte.</summary>
    /// <returns>One of the values defined in the SerialStopBitCount enumeration.</returns>
    public extern SerialStopBitCount StopBits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the **idVendor** field of the USB device descriptor. The value indicates the vendor identifier for the device as assigned by the USB specification committee.</summary>
    /// <returns>The vendor identifier for the device as assigned by the USB specification committee.</returns>
    public extern ushort UsbVendorId { [MethodImpl] get; }

    /// <summary>Gets the **idProduct** field of the USB device descriptor. This value indicates the device-specific product identifier and is assigned by the manufacturer.</summary>
    /// <returns>The device-defined product identifier.</returns>
    public extern ushort UsbProductId { [MethodImpl] get; }

    /// <summary>Gets or sets the time-out value for a write operation.</summary>
    /// <returns>The span of time before a time-out occurs when a write operation does not finish.</returns>
    public extern TimeSpan WriteTimeout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Input stream that contains the data received on the serial port.</summary>
    /// <returns>Input stream that contains the data received</returns>
    public extern IInputStream InputStream { [MethodImpl] get; }

    /// <summary>Gets an output stream to which the app can write data to transmit through the serial port.</summary>
    /// <returns>The output steam that contains the transfer data.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }

    /// <summary>Event handler that is invoked when error occurs on the serial port.</summary>
    public extern event TypedEventHandler<SerialDevice, ErrorReceivedEventArgs> ErrorReceived;

    /// <summary>Event handler that is invoked when the state of a signal or line changes on the serial port.</summary>
    public extern event TypedEventHandler<SerialDevice, PinChangedEventArgs> PinChanged;

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that the app can pass to DeviceInformation.FindAllAsync in order to find all serial devices on the system.</summary>
    /// <returns>String formatted as an AQS query.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that the app can pass to DeviceInformation.FindAllAsync in order to find a serial device by specifying its port name.</summary>
    /// <param name="portName">The serial port name. For example, "COM1".</param>
    /// <returns>String formatted as an AQS query.</returns>
    [Overload("GetDeviceSelectorFromPortName")]
    [MethodImpl]
    public static extern string GetDeviceSelector(string portName);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that the app can pass to DeviceInformation.FindAllAsync in order to find a specific Serial-to-USB device by specifying it's VID and PID.</summary>
    /// <param name="vendorId">Specifies the vendor identifier for the device as assigned by the USB specification committee. Possible values are 0 through 0xffff.</param>
    /// <param name="productId">Specifies the product identifier. This value is assigned by the manufacturer and is device-specific. Possible values are 0 through 0xffff.</param>
    /// <returns>String formatted as an AQS query.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromUsbVidPid(ushort vendorId, ushort productId);

    /// <summary>Starts an asynchronous operation that creates a SerialDevice object.</summary>
    /// <param name="deviceId">The device instance path of the device. To obtain that value, get the DeviceInformation.Id property value.</param>
    /// <returns>Returns an IAsyncOperation(SerialDevice) object that returns the results of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SerialDevice> FromIdAsync(
      string deviceId);
  }
}
