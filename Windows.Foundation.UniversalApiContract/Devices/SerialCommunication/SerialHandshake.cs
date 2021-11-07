// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.SerialHandshake
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Defines values for hardware and software flow control protocols used in serial communication. The values are used by Handshake property on the SerialDevice object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SerialHandshake
  {
    /// <summary>No protocol is used for the handshake.</summary>
    None,
    /// <summary>When the port is receiving data and if the read buffer is full, the Request-to-Send (RTS) line is set to **false**. When buffer is available, the line is set to **true**. When the serial port is transmitting data, CTS line is set to **false** and the port does not send data until there is room in the write buffer.</summary>
    RequestToSend,
    /// <summary>The serial port sends an Xoff control to inform the sender to stop sending data. When ready, the port sends an Xon control to inform he sender that the port is now ready to receive data.</summary>
    XOnXOff,
    /// <summary>Both **RequestToSend** and **XOnXOff** controls are used for flow control.</summary>
    RequestToSendXOnXOff,
  }
}
