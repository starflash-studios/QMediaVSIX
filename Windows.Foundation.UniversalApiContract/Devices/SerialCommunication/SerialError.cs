// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.SerialError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  /// <summary>Defines values for error conditions that can occur on the serial port.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SerialError
  {
    /// <summary>The hardware detected a framing error.</summary>
    Frame,
    /// <summary>A character-buffer overrun has occurred. The next character is lost.</summary>
    BufferOverrun,
    /// <summary>An input buffer overflow has occurred. There is either no room in the input buffer, or a character was received after the end-of-file (EOF) character.</summary>
    ReceiveFull,
    /// <summary>The hardware detected a parity error.</summary>
    ReceiveParity,
    /// <summary>The application tried to transmit a character, but the output buffer was full.</summary>
    TransmitFull,
  }
}
