// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.ISmsMessageBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This interface specifies base functionality for all SMS message types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(753991216, 65104, 20422, 170, 136, 76, 207, 226, 122, 41, 234)]
  public interface ISmsMessageBase
  {
    /// <summary>Gets the message type of this message.</summary>
    /// <returns>An enumeration value specifying the message type of the message.</returns>
    SmsMessageType MessageType { get; }

    /// <summary>Gets the unique device identifier associated with this message.</summary>
    /// <returns>The device identifier, as a string.</returns>
    string DeviceId { get; }

    /// <summary>Gets the cellular class of the message.</summary>
    /// <returns>An enumeration value specifying the cellular class of the message.</returns>
    CellularClass CellularClass { get; }

    /// <summary>Gets the message class of this message.</summary>
    /// <returns>An enumeration value specifying the SMS message class of this message.</returns>
    SmsMessageClass MessageClass { get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    string SimIccId { get; }
  }
}
