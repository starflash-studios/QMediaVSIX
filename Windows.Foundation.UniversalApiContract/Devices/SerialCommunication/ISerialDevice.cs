// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.ISerialDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SerialCommunication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3783773382, 8720, 16719, 182, 90, 245, 85, 58, 3, 55, 42)]
  [ExclusiveTo(typeof (SerialDevice))]
  internal interface ISerialDevice : IClosable
  {
    uint BaudRate { get; set; }

    bool BreakSignalState { get; set; }

    uint BytesReceived { get; }

    bool CarrierDetectState { get; }

    bool ClearToSendState { get; }

    ushort DataBits { get; set; }

    bool DataSetReadyState { get; }

    SerialHandshake Handshake { get; set; }

    bool IsDataTerminalReadyEnabled { get; set; }

    bool IsRequestToSendEnabled { get; set; }

    SerialParity Parity { get; set; }

    string PortName { get; }

    TimeSpan ReadTimeout { get; set; }

    SerialStopBitCount StopBits { get; set; }

    ushort UsbVendorId { get; }

    ushort UsbProductId { get; }

    TimeSpan WriteTimeout { get; set; }

    IInputStream InputStream { get; }

    IOutputStream OutputStream { get; }

    event TypedEventHandler<SerialDevice, ErrorReceivedEventArgs> ErrorReceived;

    event TypedEventHandler<SerialDevice, PinChangedEventArgs> PinChanged;
  }
}
